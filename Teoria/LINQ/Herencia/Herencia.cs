///Herencia

coche Dacia = new coche();
Dacia.combustible = "Gasolina";
Console.WriteLine(Dacia.combustible);
Console.WriteLine(DateTime.Now);//Escribir la hora actual
Dacia.arrancar("Victor");
class vehiculo
{ 
    public string combustible { get; set; }
    public string aforo { get; set;}

    //Polimorfismo
    public void arrancar()
    {
        Console.WriteLine("Prensió a la primera");
    }
    public void arrancar(string nombre)
    { 
        Console.WriteLine(nombre+" Ha encendido el coche");
    }
}

class coche : vehiculo
{
    public int ruedas{get; set;}
    public int puertas { get; set;}
    public string color { get; set;}
    public void ponermusica()
    {
        Console.WriteLine("Radio encendida");
    }
}