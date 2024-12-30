using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()      // // Only log Information, Warning, Error, Fatal   
    .WriteTo.Console()               // Log to the console
    .WriteTo.File("Logs/myapp.txt",  // Log to a file (rolling daily)
        rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Use Serilog as the logging provider
builder.Host.UseSerilog();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
