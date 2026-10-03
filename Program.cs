var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
    "Hello from TYBScIT DevOps Demo!");

app.MapGet("/student", () =>
    "This application was built using C#, Git, Jenkins and Docker.");

app.Run();
