var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    System.Console.WriteLine("/ foi executado");
    return "Hello World!";
    });
app.MapGet("/seunome", () => {
    return "Neemias";
});




app.Run();
