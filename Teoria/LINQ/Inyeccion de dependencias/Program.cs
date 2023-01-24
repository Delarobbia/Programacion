//Inyeccion de dependencias

using Inyeccion_de_dependencias;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) => 
        services.AddTransient<ITransientOperation, DefaultOperation>()
        .AddScoped<IScopedOperation, DefaultOperation>()
        .AddSingleton<ISingletonOperation, DefaultOperation>()
        .AddTransient<OperationLogger>())
        .Build();

EjemploScopes(host.Services, "Scope 1");

await host.StartAsync();    //Inicio asincrono

static void EjemploScopes(IServiceProvider services, string scope)
{ 
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    OperationLogger logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: == Ejecutando...GetRequiredService<OperationLogger>()");

    Console.WriteLine();
/*
    logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: == Ejecutando...GetRequiredService<OperationLogger>()");
*/
}

