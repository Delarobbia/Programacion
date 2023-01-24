/* Delegados
 * 
 * Referencia a un método := variable ----> método
 * 
 * <mmodificador de acceso> delegate <tipo de retorno> <nombre>(<parametros>[]);
 * 
 *  public      delegate        void        ImprimirDocDelegado(string path)
    
    Delegados disponibles por defecto
    - Action<t>                    -> siempre devuelve void de 0 a 16 parametros.
                                      Action<string> -> recibe string, devuelve void
    -anónimos                      -> definir sintaxis lambda
    -Func<in T, out TResult>       -> Func<int, string> -> recibe int y retorna string
    -Predicate<t>                  -> Siempre devuelve un boolean
 */

Console.WriteLine("Escribe un mensaje: ");
var msg =Console.ReadLine();

/*Usando el delegado declarado con delegate void
 * ImprimirDelegadoClase obj = new ImprimirDelegadoClase();
    obj.EjemploDelegate(msg);
*/

/*Usando Action<string>

ImprimirConActionClase obj = new ImprimirConActionClase();
obj.EjemploAction(msg);
*/

//Usando Delegado anonimo
ImprimirConDelegadoAnonimo obj = new ImprimirConDelegadoAnonimo();
obj.EjemploConDelegadoAnonimo(msg);

public delegate void ImprimirDelegado(string value);
public class ImprimirDelegadoClase
{
    private void Imprimir(string value)
    {
        Console.WriteLine("Has recibido: " + value); ;
    }
    public void EjemploDelegate(string str)
    {
        //Declaracion
        ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);
        //Invocacion - Call
        imprimirDelegado(str);
    }
}

public class ImprimirConActionClase
{

    private void Imprimir(string msg)
    {
        Console.WriteLine(msg);
    }

    public void EjemploAction(string msg)
    {
        Action<string> imprimirDelegadoAction = Imprimir;
        imprimirDelegadoAction(msg);
    }
}

public class ImprimirConDelegadoAnonimo
{

    public void EjemploConDelegadoAnonimo(string msg)
    {
        /*
         * Definicion regular
         * 
        Action<string> imprimirconAction = delegate (string msg)
        {
            Console.WriteLine("Desde delegado anonimo: " + msg);
        };
        */

        //Definicion lambda
        Action<string> imprimirConActionLambda = x => Console.WriteLine("Desde delegado anonimo : "+x);
        //imprimirconAction(msg);
        imprimirConActionLambda(msg);

        Func<int, string> resultado = v => "El resultado es: " + v;
        Console.WriteLine(resultado(5));

        Func<int, int, int> multiplicar = (v1, v2) => v1 * v2;
        int producto = multiplicar(3, 2);
        Console.WriteLine(producto);

        //Predicate
        Predicate<int> esMayorDeEdad = e => e <= 18;
        bool mayorDeEdad = esMayorDeEdad(21);
    }



}
    