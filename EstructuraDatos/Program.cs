Console.WriteLine("Universidad Estatal Amazónica");

class Persona{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    Persona(string cedula, string nombres, string direccion, string telefono){
        Cedula = cedula;
        this.Nombres = nombres;
        this.Direccion = direccion;
        Telefono = telefono;
    } 
}

class Producto
{
    public int id { get; set; }
    // nombre fue creado con prop
    public string nombre { get; set; }

    //constructor
    Producto(int id, string nombre){
        this.id = id;
        this.nombre = nombre;
    }
}

class Perro{
    private string nombre;

    //constructor
    Perro(string _nombre){
        nombre = _nombre;
    }

    //metodo set permite poner un valor
    public void setNombre(string dato){
        nombre = dato;
    }

    //método get permite obtener el valor
    public string getNombre(){
        return nombre;
    }
}