using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;


// These can come from a config file, constants file, etc.
var serviceName = "MyCompany.MyProduct.MyService";
var serviceVersion = "1.0.0";


var builder = WebApplication.CreateBuilder(args);

// Configure important OpenTelemetry settings, the console exporter, and automatic instrumentation


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
