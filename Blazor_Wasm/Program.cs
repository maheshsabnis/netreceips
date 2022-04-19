using Blazor_Wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor_Wasm.GlobalState;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// Load the Component in HTML Element with 'id' as 'app'
// wwwroot/index.html <div id="app">
builder.RootComponents.Add<App>("#app");
// HeadOutlet is a standard COmponent that will
// added after HTML page Header
builder.RootComponents.Add<HeadOutlet>("head::after");
// The HttpClient class is registered into the DI Container
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the Application State as SIgnleton
builder.Services.AddSingleton<ApplicationStateService>();
// Run the Application Asynchrnously
await builder.Build().RunAsync();
