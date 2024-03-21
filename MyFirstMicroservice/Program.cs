using MyFirstMicroservice.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

List<CardsDto> cards = [
    new (
        "214214",
        "Still",
        "Ainda",
        1,
        "2024-04-01",
        new DateOnly(2024, 4, 22)
    ),
];

app.MapGet("/", () =>
{
    return "Hello World";
})
.WithName("HelloWorld")
.WithOpenApi();

app.MapGet("/card", () =>
{
    return cards;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();


