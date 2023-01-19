// See https://aka.ms/new-console-template for more information
Console.WriteLine("Que lenguaje estás aprendendo?");
string lenguaje = Console.ReadLine();
Console.WriteLine("Empiezo en " + lenguaje);


//nulos
int? numero = null;

//Para escribir todo como quramos, usamos @"" al poner loq eu vamos a imprimir

Console.WriteLine(@"Hola, puedo poner \n o \t o ""comillas""");

//Trabajar con cadenas

//Substarer los primeros 10 caracteres
string cadena = "Esta es una frase de prueba";
string cadena2 = cadena.Substring(0, 10);

//Reemplazar palabras
string cadena3 = cadena.Replace("prueba", "principiante");

//Quitar espacios al inicio y al final del string
string cadena4 = "     Espacios a lo loco      ";
string cadena5 = cadena4.Trim();

//Encontrar caracter
int index = cadena.IndexOf('s');

//Añadir a un string

string añadir = "Holita";
cadena += añadir;


//Crear arrays

int[] array = new int[2];

//Iterar string
foreach (int valor in array)
{
    Console.WriteLine(valor);
}

//Ordenar array
Array.Sort(array);


//Definir funciones

int suma(int a, int b)
{
    return a + b;
}

int c = suma(3, 2);

//Clases  se puede usar static para crear una funcion dentro de una clase que puede ser usada sin necesidad de crear un elemento    

var moto = new motos();
class motos
{
    public void arrancar()
    {
        Console.WriteLine("arranca");
    }
}