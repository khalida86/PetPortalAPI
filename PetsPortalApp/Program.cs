using PetsPortalApp;
using PetsPortalApp.Context;
using PetsPortalApp.Repository;
using PetsPortalApp.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<PetContext>();
builder.Services.AddSingleton<IPetManager, PetManager>();
//builder.Services.AddSingleton<IPetsRepository, PetsRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

//app.MapPetControllerEndpoints();

app.Run();
