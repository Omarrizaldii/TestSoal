using SoalNo3MembuatAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.UseHttpsRedirection();

//var customers = new List<Customer> {
//    new Customer {Id = 1, Nama = "omar", Address="tangerang" }
//};

//app.MapGet("/customer", () =>
//{
//    return customers;
//});
app.UseAuthorization();

app.MapControllers();

app.Run();