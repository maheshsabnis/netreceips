# ASP.NET COre Eco-System

1. Directives
	- Objects used on Views (Razor-Pages) for using the CLR Object with Specific Behavior
	- @page: The Page Objet, this can also have a Navigation URL for ROuting
	- @model: The CLR Object bound with View and hence all Tag-Helpers on the View for Data Binding
		- All public properties of the Model class will be exposed to View
	- @using: Using the NAmespace on the View
	- @inject: Injecting the Dependency on View
2. Razor Views
	- .NET 5 has Retired ASP.NET Web Forms
	- PageName.cshtml, a View with C# and HTML
	- PageName.cshtml.cs, a Code-behind aka 'THE PAGE CLASS' aka 'PAGE-MODEL-CLASS'
		- Get()
			- Invokes when a PAge is alled or Requested
		- Post()
			- Invoked hen the Page is Submitted
				- The Page Model itslef will be submitted to Post method
3. Services and MIddlewares for Razor View
	- builder.Services.AddRazorPages();
		- Process the Request for RAzor View with Get/Post methods
	- app.MapRazorPages();
		- Direct Request for the Razor View 
	- asp-page the Tag helper that is used to accept the URL of th Razor View
		- e.g. asp-page="/Index"
			- This will look for Index.cshtml view under the 'Pages' folder and this MUST have @page directive
	- To bind the CLR Object to Razor View with its HTML UI Elements those who are using TagHelper, apply the BindProperty ATtribute on CLR object in PAgeModel class
		-    [BindProperty]
        public Category Category { get; set; }
	- Route to a Razor Page using id
		- <a asp-page="./Edit" asp-route-id="@item.CategoryRowId">Edit</a>
			- Route to Edit View based on id
		- The Edit View OnGet() method will be passed with the 'id' parameter from ROute as follows
			-  public async Task<IActionResult> OnGetAsync(int? id)
        {}
		- REdirect to the Page using following
			- return RedirectToPage("./Index");
		