var host = DIHost.CreateDefaultHost();
host.Services.AddConsoleServices(
    host.Configuration.GetSection("CatsEndpoints").Get<CatsEndpoints>());
host.Build();

var view = host.GetRequiredService<ICatsView>();
await view.RenderCatsAsync();