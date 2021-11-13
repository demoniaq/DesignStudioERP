using DesignStudioErp.Persistence.Context;
using System.Reflection;
using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Persistence;

var builder = WebApplication.CreateBuilder(args);

#region Automapper
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IApplicationDbContext).Assembly));
});
#endregion Automapper

#region Add services to the container.
builder.Services.AddPersistance(builder.Configuration, "ConnectionStrings:MsSqlConnection");
#endregion Add services to the container.

#region CORS
builder.Services.AddCors(options =>
{
    // Политика доступ всем
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
        // TODO
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

app.UseCors("AllowAll"); // TODO Временно полный доступ

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
#endregion Configure the HTTP request pipeline

app.Run();
