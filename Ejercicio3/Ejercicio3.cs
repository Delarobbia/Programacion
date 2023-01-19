// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese sus datos:\n Nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?:");
string sabe = Console.ReadLine();
Console.WriteLine("Susa datos son:");
Console.WriteLine("Nombre: "+nombre+" Apellido: "+apellido+" edad: "+edad+" Sabe Programar: "+sabe);