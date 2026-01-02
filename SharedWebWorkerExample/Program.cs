using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedWebWorkerExample;
using SharedWebWorkerExample.Services;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.WebWorkers;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazorJSRuntime();
builder.Services.AddWebWorkerService();

builder.Services.AddSingleton<ITestService, TestService>();

await builder.Build().BlazorJSRunAsync();
