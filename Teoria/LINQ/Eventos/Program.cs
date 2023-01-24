//Eventos


SuscriptorCalc calculadora = new SuscriptorCalc(1,2);
calculadora.Resultadosuma();
calculadora.ResultadoResta();
/*Edito
 *Determina cuando se lana el evento
 *Definicion del evento
 *Delegado
 */

public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}

public class EditorCalc
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a,int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine("La suma es: " + (a + b));
        }
        else {
            Console.WriteLine("No tienes suscripción a este evento");
        }
    }

    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine("La resta es: " +(a - b));
        }
        else
        {
            Console.WriteLine("No tienes suscripción a este evento");
        }
    }

}

/*Suscriptor
 * Acepta el evento y provee un event handler,es decir
 * Método que será ejecutado cuando ocurra el evento
 */

public class SuscriptorCalc
{
    EditorCalc editor;
    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        Console.WriteLine("Se imprime el resultado de la operación");
    }
    public SuscriptorCalc(int a, int b)
    { 
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EjemploEventHandler;
    }

    public void Resultadosuma()
    {
        editor.Sumar(A, B);
    }

    public void ResultadoResta()
    { 
        editor.Restar(A, B);
    }
}

/*Evento
 * Delegado encapsulado en la clase del editor
 * Delegado -> llama a un método cuando se cumple una condición
 * */