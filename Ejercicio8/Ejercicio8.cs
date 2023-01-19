
    Console.WriteLine("Escriba un número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Contador hasta el 10;");
if (numero>0)
    {
    Console.WriteLine("Es positivo");
    }else { Console.WriteLine("Es negativo"); }
if (numero > 10) {
    do
    {
        Console.WriteLine(numero);
        numero--;
    } while (numero >= 10);
}
if (numero < 10)
{
    do {
        Console.WriteLine(numero);
        numero++;
    } while (numero <= 10);
}
else {
    Console.WriteLine("El número ya es 10");
}