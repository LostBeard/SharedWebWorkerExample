using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedWebWorkerExample;
using SharedWebWorkerExample.Services;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.WebWorkers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// SpawnDev.BlazorJS setup
builder.Services.AddBlazorJSRuntime();

// WebWorkerService
builder.Services.AddWebWorkerService();

// Test service that will be called in the Window context and run in the SharedWebWorker context
// See Home.razor for example usage
builder.Services.AddSingleton<ITestService, TestService>();

await builder.Build().BlazorJSRunAsync();
