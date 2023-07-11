using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using STgenetics.Farm.Client;
using STgenetics.Farm.Client.Repository;
using STgenetics.Farm.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5555/api/")
});

builder.Services.AddScoped<IAnimalsRepository, AnimalsRepository>();
builder.Services.AddSingleton<AnimalAppState>();


await builder.Build().RunAsync();
