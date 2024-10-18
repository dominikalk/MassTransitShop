using Blazor.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("ProductsAPI", client =>
    client.BaseAddress = new Uri("https://localhost:7148/"));

builder.Services.AddHttpClient("OrdersAPI", client =>
    client.BaseAddress = new Uri("https://localhost:7089/"));

await builder.Build().RunAsync();