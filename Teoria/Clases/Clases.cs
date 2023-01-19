//Clases
Coche coche = new Coche();
coche.retornar();
class Coche
{
    int cilindrada;
    string marca;
    int puertas;

    //Constructos
    public Coche()
    { 
        cilindrada= 0;
        marca = "dacia";
        puertas = 4;
    }
    public void retornar()
    {
        Console.WriteLine("Cilindrada :" + cilindrada);
        Console.WriteLine("Marca: "+marca);
        Console.WriteLine("Puertas: "+puertas);

    }
}
