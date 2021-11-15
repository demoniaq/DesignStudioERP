using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Application.Repo;
using DesignStudioErp.Dto.MeasDto;
using DesignStudioErp.Persistence.Context;
using DesignStudioErp.Persistence.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

#region Automapper
builder.Services.AddAutoMapper(config =>
{       
    config.AddProfile(new AssemblyMappingProfile(typeof(MeasUnitBaseDto).Assembly)); // Находим сборку по классу MeasUnitBaseDto
    //config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly())); // Текущая сборка
    //config.AddProfile(new AssemblyMappingProfile(typeof(IApplicationContext).Assembly));
});
#endregion Automapper

#region Add services to the container.
builder.Services.AddPersistance(builder.Configuration, "ConnectionStrings:MsSqlConnection"); // TODO remove constant
builder.Services.AddScoped(typeof(IRepo<>), typeof(Repo<>)); // Add generic Repo
#endregion Add services to the container.

#region CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});
#endregion CORS

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

#region Init Db
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        // TODO handle exception
    }
}
#endregion Init Db

#region Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

app.UseRouting();
app.UseHttpsRedirection();

app.UseCors("AllowAll"); // TODO temporary

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
#endregion Configure the HTTP request pipeline

app.Run();
