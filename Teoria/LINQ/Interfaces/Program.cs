//Interfaces -> Plantillas para clases

class Vehiculo : IVehiculo
{
    void IVehiculo.Arrancar()
    {
        Console.WriteLine("Brummmm");
    }
    string IVehiculo.marca { get; set; }
}


interface IVehiculo
{
    void Arrancar();
    public string marca { get; set; }
}