cliente newcliente = new cliente("Victor",664132897,"Calle otero 26","email@gmail.com",true); //{ nombre = "Victor", email = "email@gmail.com", telefono = 664132897, nuevo = true };
Console.WriteLine("Nombre: "+newcliente.Nombre+"\nTeléfono: "+newcliente.Telefono+"\nDirección: "+newcliente.Direccion+"\nEmail: "+newcliente.Email+"\nEs nuevo?: "+newcliente.Nuevo);

public struct cliente 
{
    public cliente(string nombre, int telefono, string direccion, string email, Boolean nuevo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        Nuevo = nuevo;
    }

      public string Nombre{get;}
      public int Telefono { get; }
      public string Direccion { get; }
      public string Email { get; }
      public Boolean Nuevo { get; }

    public override string ToString() => $"({Nombre}, {Direccion}, {Telefono}, {Email}, {Nuevo})";

}