using BlazorTodoApp;
using BlazorTodoApp.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient tan?m?
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// LocalStorage ve servis kay?tlar?
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<TaskService>();

// Uygulamay? ba?lat
await builder.Build().RunAsync();
