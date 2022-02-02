using System.Reflection;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Client.Services;
using FluentValidation;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices(c =>
{
    c.SnackbarConfiguration.HideTransitionDuration = 300;
    c.SnackbarConfiguration.ShowTransitionDuration = 300;
});
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IDataValidatorService, DataValidatorMockService>();

await builder.Build().RunAsync();