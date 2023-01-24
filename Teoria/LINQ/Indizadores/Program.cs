//Indexadores


//Recurso que nos permite acceder a una estructura de datos de tipo matriz


//Declaracion del indicador
/*
var TemperaturasDiarias = new Temperaturas();
TemperaturasDiarias[3] = 11.5f;
TemperaturasDiarias[9] = 7.5f;

//ver los datos
for (int i = 0; i < TemperaturasDiarias.len; i++)
{
    Console.WriteLine(TemperaturasDiarias[i]);
}
public class Temperaturas
{
    float[] temp = new float[10]
    {
        10f,11f,10f,11f,10f,
        10f,11f,10f,11f,8f
    };

    public int len => temp.Length;

    //Indizador
    public float this[int index]
    { 
        get => temp[index];
        set => temp[index] = value;
    }
}
*/

//Ejemplo dias de la semana

var dias = new DiasSemana();
Console.WriteLine(dias["Lun"]);
try {
    Console.WriteLine(dias["Mar"]);
}catch(ArgumentOutOfRangeException ex) { 
    Console.WriteLine(ex.Message);
}
public class DiasSemana
{
    public string[] dias = {
        "Lun","Mar","Mier","Juev","Vier","Sab","Dom"
    };
    public int this[string dia] => FindDayIndex(dia);

    private int FindDayIndex(string dia)
    {
        for (int j=0;j<dias.Length;j++)
        {
            if (dias[j]== dia)
            {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(dia),"El dia "+dia+"no está en la lista.Comprueba el formato");
        
    }

}