class Producto
{
    public int id { get; set; }
    // nombre fue creado con prop
    public string nombre { get; set; }
    public double[] precios { get; set; }


    //constructor
    Producto(int id, string nombre, double[] precios){
        this.id = id;
        this.nombre = nombre;
        this.precios = precios;
    }
}