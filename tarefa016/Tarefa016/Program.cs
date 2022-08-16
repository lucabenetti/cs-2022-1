using Tarefa016;

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

app.MapGet("/closure", () =>
{
    int global = 1;
    int retorno = 0;

    Action closure = delegate
    {
        retorno = global + 1;
    };
    closure();

    return retorno;
});

app.MapGet("/logging", (ILogger<Program> logger) =>
{
    var teste = "teste";

    logger.LogInformation(teste);

    return teste;
});

app.MapGet("/generics", () =>
{
    var gato = new Gato();
    var pato = new Pato();

    var animais = new List<Animal>()
    {
        gato,
        pato
    };

    var patoObtido = Obter<Pato>(animais);
    var gatoObtido = Obter<Gato>(animais);

    return $"{patoObtido.ObterNome()} - {gatoObtido.ObterNome()}";
});

T Obter<T>(List<Animal> animais) where T : Animal
{
    return (T)animais.First(x => x is T);
}

app.Run();