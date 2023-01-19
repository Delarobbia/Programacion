
int i;
Console.WriteLine("Introduzca el ancho");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca el alto:");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Está relleno?: ");
Boolean relleno = Convert.ToBoolean(Console.ReadLine());
if (relleno == true)
{ 
    for (i = 0; i < alto; i++) {
        for (int x = 1; x < ancho; x++)
        {
            Console.Write('*');
        }
        Console.WriteLine('*');
    }
}
else
{
    for (i = 0; i < ancho; i++)
    {
        Console.Write('*');
    }
    Console.WriteLine("");
    for (i = 0; i < alto - 2; i++)
    { 
        Console.Write('*');
        for (int x = 0; x < ancho - 2; x++)
        {
            Console.Write(" ");
        }
        Console.Write('*');
        Console.WriteLine("");
    }
    for (i=0; i<ancho; i++)
    {
        Console.Write('*');
    }
}
