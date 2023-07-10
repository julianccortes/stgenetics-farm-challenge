using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using STgenetics.Farm.Client;
using STgenetics.Farm.Client.Repository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5555/api/")
});


builder.Services.AddMudServices();
builder.Services.AddScoped<IAnimalsRepository, AnimalsRepository>();

await builder.Build().RunAsync();
