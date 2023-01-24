//Crear archivos TXT y realizar operaciones

using System.IO;

string texto;


// Crear un archivo y escribirlo

try
{
    StreamWriter sw = new StreamWriter("miArchivo.txt", true); //Con true directamente pasa a modo append,si lo abrimos sin el true,borramos todo.
    sw.WriteLine("Nueva linea");
    sw.WriteLine("Siguiente linea");
    sw.Close();
}
catch(Exception ex)
{
    Console.WriteLine("Ha ocurrido un error" + ex.Message);
}

//Leer el archivo
try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close(); //Cerramos el stream asociado al archivo
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido un error" + ex.Message);

}
finally
{
    Console.WriteLine("Final del try-catch-finally");
}

/*Operaciones con archivos
 * Crear archivo
 * leer archivo
 * Escribir -> Escribe el archivo pero borra lo que ya estaba
 * Append -> Añadir al archivo
 */
  