using WAD_17191.Application;
using WAD_17191.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ApplicationService();
builder.Services.InfrastructureService(builder.Configuration);

builder.Services.AddCors(options =>
{
	options.AddPolicy(
		name: "CorsPolicy",
		builder =>
		{
			builder
				.WithOrigins("http://localhost:4200")
				.AllowAnyOrigin()
				.AllowAnyHeader()
				.AllowAnyMethod();
		}
	);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
