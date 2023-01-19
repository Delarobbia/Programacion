
int precio = 25;
int descuento = 20;
string Cupon = "a3F567";

Console.WriteLine("Hola, inserte:\nNombre:" );
string nombre = Console.ReadLine();
Console.WriteLine("Email: ");
string email = Console.ReadLine();
Console.WriteLine("Cupon: ");
string cupon = Console.ReadLine();
if (cupon == Cupon)
{
    Console.WriteLine("Su precio con el descuento es: " + (precio * (1 - descuento / 100)));
}
else {
    Console.WriteLine("Su precio es: "+precio+"$");
}