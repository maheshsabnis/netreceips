using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Core_WebApp.Services;
using Core_WebApp.CustomFilters;
using Core_WebApp.Data;
using Microsoft.AspNetCore.Identity;

namespace Core_WebApp
{
    public class Startup
    {
        /// <summary>
        /// IConfiguration: This will open appsettings.json and make its settings for the current application
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the dependency container.
        /// <summary>
        /// IServiceCollection: nterface that is used to Register all 'services' (aka dependencies) into the container with their instances(?)
        /// The Method will be invoked using the Host BUilder with its 'UseStartup<Startup>()' method. It will resolve the IServceCOlection and its instance will be passed to the method
        /// The 'ServiceDescriptor' class, used by IServiceCollection to Register various dependency objects as services for the current application with their instance strategies
        /// The ServiceDescriptor has following methods for strategies of instantition
        /// 1. Scopped: A new instace will be created for each new session
        /// 2. Singleton: An instance wil be created once for all sessions and this will be live till the application is running
        /// 3. Transient: The instance will be created for each request
        /// Following Types of Services are registered in Dependency Container
        /// Database Connection, Authentication, Authorization, Session, Caching, Cross-Origin-Resource-SHaring(CORS), Controllers Request Processing (API+Views), Only API, Only Razor View, Custom Services, gRPC, SignelR, Swagger, etc.  
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            // REgister the DAL DbContext
            // BY passing the COnnection Information (Onnection String)
            // by reading Key from the appsettings.json
            services.AddDbContext<EnterpriseContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });

            // The Registration of the Core_WebAppContext into 
            // the Dependency Container
            services.AddDbContext<Core_WebAppContext>(options =>
                  options.UseSqlServer(
                      Configuration.GetConnectionString("Core_WebAppContextConnection")));
            // REgister the Identity Provider Classes in
            // Dependency COntainer
            // UserManager<IdentityUser>: User Management (CRUD)
            // SignInManager<IdentityUser>: User Login Management
            //services.AddDefaultIdentity<IdentityUser>(
                //options =>
                // Navigate to the ConformEmail Page when new User
                // is registered
                //options.SignIn.RequireConfirmedAccount = true
                
                //)
                // Connect to Database for Security using EF Core
             //   .AddEntityFrameworkStores<Core_WebAppContext>()
             //.AddDefaultUI();

            // REgistration of 
            // UserManager<IdentityUser>
            // RoleManager<IdentityRole>
            // SignInManager<IdenttyUser>
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Core_WebAppContext>()
             .AddDefaultUI();

            // Define Policies
            services.AddAuthorization(options => {
                options.AddPolicy("ReadPolicy", policy=> {
                    policy.RequireRole("Manager", "Clerk", "Operator");
                });
                options.AddPolicy("ManagerClerkPolicy", policy => {
                    policy.RequireRole("Manager", "Clerk");
                });
                options.AddPolicy("ManagerPolicy", policy => {
                    policy.RequireRole("Manager");
                });

            });



            // REgister the Custom Services those COntains Business Logic
            //                  Service Interface, Class Implementing Service Interface
            services.AddScoped<IService<Department,int>,DepartmentService>();
            services.AddScoped<IService<Employee, int>, EmployeeService>();

            // COnfigure the Memory Cache
            // THe Same memory where the Host is executing 
            // the Application
            services.AddMemoryCache();

            // COfigure Sessions
            // The Session Time out is 20 Mins for Idle Request
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
               options.IdleTimeout = TimeSpan.FromMinutes(20);
            });



            // Process the Request for API and Views both 
            // for MVC
            // THis is is used to Register Filters at Global Level
            services.AddControllersWithViews(options => {
                //options.Filters.Add(typeof(LogFilterAttribute));
               //Commented because of RAzor View
               //options.Filters.Add(new LogFilterAttribute());
                // REgister the Exception Filter
                // The IModelMetadataProvider will be resolved by the 
                // PIpeline
               // (Comment Because of Razor Views)
               //options.Filters.Add(typeof(AppExceptionFilterAttribute));
            });
            // Add a Service to SUpport an Execution of Razor PAges 
            // for Identity
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// For Middlewares
        /// USe this to provde Vale Added Service to the Request
        /// Exception, HSTS, Https Redirection, Static Files, ROuting,
        /// CORS, Session, Caching, Authentication, Authorization,Custom Middlewares,
        /// EndPoints (The Request Processing for RAzorVeiw, MVC, API)
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            else
            {
        app.UseDeveloperExceptionPage();
             //  app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // Generate ROute Table for 
            // All Controllers (MVC and API)
            app.UseRouting();

            // Use the Cache Middleware
           

            // Use the Sessin Middleware
            app.UseSession();
            // Middleware for USer Authentication
            app.UseAuthentication();
            app.UseAuthorization();

            // MAp the Incomming Request with the COntrollers (MVC and API)
            // MAp the Incomming Request with RAzor Views
            app.UseEndpoints(endpoints =>
            {
                // Map with MVC Controller
                // Use the Route Table to Map with the MVC Controller
                endpoints.MapControllerRoute(
                    name: "default",
                    // Route URL Expression
                    //         HomeCOntroller   The Index Action Method id is optonal        
                    pattern: "{controller=Home}/{action=Index}/{id?}");

               // endpoints.MapControllers(); // API
               // Map Request to RAzor View for Idetity Pages
               endpoints.MapRazorPages(); // Razor View
            });
        }
    }
}
