
Console.WriteLine("Lenguajes:\n1.C++\n2.Java\n3.C#");
Console.WriteLine("Seleccione lenguaje:");
int sel = Convert.ToInt32(Console.ReadLine());
switch (sel)
{
    case 1:
        break;
    case 2:
        Console.WriteLine("System.out.printl(Hola mundo)");
        break;
    case 3:
        Console.WriteLine("Hola Mundo");
        break;
    default:
        break;
}


