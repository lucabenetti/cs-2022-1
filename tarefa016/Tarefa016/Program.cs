var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/runtime", (IHostEnvironment hostEnvironment) =>
{
    return hostEnvironment.EnvironmentName;
});

app.MapGet("/closure", (IHostEnvironment hostEnvironment) =>
{
    int global = 1;
    int retorno;

    Action closure = delegate
    {
        retorno = global + 1;
    };
    closure();

    return retorno;
});

app.Run();