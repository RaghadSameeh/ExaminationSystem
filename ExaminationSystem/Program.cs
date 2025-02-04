using Autofac.Extensions.DependencyInjection;
using Autofac;
using ExaminationSystem;
using ExaminationSystem.Profiles;
using AutoMapper;
using ExaminationSystem.Helpers;
using Autofac.Core;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//});

//register autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
    builder.RegisterModule(new AutoFacModule()));

//registerProfilesForAutomapper
builder.Services.AddAutoMapper(typeof(Profiles));


var app = builder.Build();
MapperHelper.Mapper = app.Services.GetService<IMapper>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseSwaggerUI(c =>
    //{
    //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    //    c.RoutePrefix = string.Empty;
    //});

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
