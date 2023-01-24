//Patrones
//Probando Factory
using Patrones.Factory;

Console.WriteLine("Probando Factory");
MetodoCliente(new ConcretoFactory1());
MetodoCliente2(new ConcretoFactory2());
Console.WriteLine();


/*
//Probando singleton
Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton funciona");
}
else
{
    Console.WriteLine("Singleton falló");
}
*/


//Definciiones

void MetodoCliente(IAbstractFactory factory)
{
    var ProductA = factory.CreateProductA();
    Console.WriteLine(ProductA.MetodoA());
    var ProductB = factory.CreateProductB();
    Console.WriteLine(ProductB.MetodoB());
}
void MetodoCliente2(IAbstractFactory factory)
{
    var ProductA1 = factory.CreateProductA();
    Console.WriteLine(ProductA1.MetodoA());
    var ProductB1 = factory.CreateProductB();
    Console.WriteLine(ProductB1.MetodoB());
}