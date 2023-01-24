//Excepciones
try
{
    Console.WriteLine("1 entre 2: " + DivisonSegura(1, 2));
    Console.WriteLine("0 entre 0: " + DivisonSegura(0, 0));
}catch(Exception ex)
{
    Console.WriteLine($"Ha ocurrido el mensaje : "+ex.Message);
}
static double DivisonSegura(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException();
    }
    return a / b;
}