using finance_tracker_client.Components;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var serverBaseUrl = builder.Configuration["ServerBaseUrl"];

if (string.IsNullOrEmpty(serverBaseUrl))
{
    throw new InvalidOperationException("The 'ServerBaseUrl' configuration is not defined.");
}

builder.Services.AddMudServices();

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(serverBaseUrl)
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
