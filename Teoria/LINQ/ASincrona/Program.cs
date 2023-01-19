using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

//Programacion asíncrona
/*
Stopwatch crono = new Stopwatch();
crono.Start();

//codigo

for (int i = 0; i< 100; i++)
{
    Console.WriteLine("Hola,este es el numero "+i);
}
Thread.Sleep(1000);
crono.Stop();
Console.WriteLine(crono.Elapsed);
*/

//Tarea 1

var task = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine("Task 1: "+crono.Elapsed);
});
var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine("Task 2: "+crono.Elapsed);
});
var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine("Task 3: "+crono.Elapsed);
});

task.Start();
task2.Start();
task3.Start();

await task;
await task2;
await task3;