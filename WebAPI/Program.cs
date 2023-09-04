using Application;
using Application.Interfaces;
using Application.Services;
using Persistence;
using Shared;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddApplicationLayer();

builder.Services.AddSharedInfraestructure(configuration);
builder.Services.AddPersistenceInfraestructure(configuration);
builder.Services.AddApiVersioningExtensions();
builder.Services.AddControllers();
builder.Services.AddHttpClient();

builder.Services.AddPersistenceInfraestructure(configuration);
builder.Services.AddScoped<ICourseServices, CourseServices>();

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseErrorHandlingMiddleware();

app.MapControllers();

app.Run();
