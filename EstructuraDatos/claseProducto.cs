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