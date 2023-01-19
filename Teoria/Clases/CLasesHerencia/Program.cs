//Generics
Generic<string> str = new Generic<string>();
str.Campo = "holiwi";
Console.WriteLine(str.Campo);
Console.WriteLine(str.Campo.GetType().Name);

public class Generic<T>
{ 
    public T Campo { get; set; }

}