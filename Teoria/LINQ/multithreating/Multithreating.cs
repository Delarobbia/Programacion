//Multithreading
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
/*//Sin Multitreathing
Stopwatch cronometro = new Stopwatch();
cronometro.Start();
// tarea 1
Thread.Sleep(1000);

// trea 2
Thread.Sleep(1000);

//tarea 3
 Thread.Sleep(1000);

cronometro.Stop();
Console.WriteLine("Este programa ha tardad: " + cronometro.Elapsed);

// Main threating

    Stopwatch cronometro1 = new Stopwatch();
    Thread hiloprincipal = Thread.CurrentThread;
    //Poniendo nombre al hilo
    hiloprincipal.Name = "Hilo principal";
   Console.WriteLine("Estamos en : " + hiloprincipal.Name);
*/
Stopwatch cronometro1 = new Stopwatch();
cronometro1.Start();

//Task1
var task1 = new Task(() =>
{
    var cronometro = new Stopwatch();
    cronometro.Start(); 
    Thread.Sleep(1000);
    cronometro.Stop();
    Console.WriteLine("Este hilo ha tardardo:" + cronometro.Elapsed);
});
// Task2
var task2 = new Task(() =>
{
    Stopwatch crono2 = new Stopwatch();
    crono2.Start();
    Thread.Sleep(1000);
    crono2.Stop();
    Console.WriteLine("Este hilo ha tardado : " + crono2.Elapsed);
});

//Task 3
var task3 = new Task(() =>
{
    Stopwatch crono3 = new Stopwatch();
    crono3.Start();
    Thread.Sleep(1000);
    crono3.Stop();
    Console.WriteLine("Este hilo ha tardado : " + crono3.Elapsed);
});


task1.Start();
task2.Start();
task3.Start();
//Recolectamos los task
await task1;
await task2;
await task3;
cronometro1.Stop();
Console.WriteLine("El programa entero ha tardado: "+cronometro1.Elapsed);
//Recibir las tareas
// Finalizamos el programa
/*static void iniciarhilos()
  {
    Console.WriteLine("Iniciando nuevo hilo...");
  }
*/