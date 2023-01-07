using static newAddressBook.Controllers.AddressesController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ad = new Addr();
builder.Services.AddSingleton<Addr>(ad);
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    builder
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed((host) => true)
    .AllowCredentials());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();