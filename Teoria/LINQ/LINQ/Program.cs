//LINQ  sintaxis parecida a SQL

//Nuestro origen de datos
int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//2.Obtener datos de una consulta

var consulta =
    from numero in numbers
    where (numero % 2)==0
    select numero;

//3.Ejecutar consulta

foreach (var numero in consulta)
{ 
    Console.WriteLine(numero);
}


//Clases anonimas -> Crear objetos sin necesitar de una estructura

var coche = new { Marca = "Ford", Puertas = 6, ITV = true, Matricula = "5566KZG" };
Console.WriteLine(coche.Marca);
Console.WriteLine(coche.Puertas);
Console.WriteLine(coche.Matricula); 
