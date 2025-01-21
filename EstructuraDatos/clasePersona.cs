public class Persona{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Persona(string cedula, string nombres, string direccion, string telefono){
        Cedula = cedula;
        this.Nombres = nombres;
        this.Direccion = direccion;
        Telefono = telefono;
    }

    public string getPersona(){
        return "Nombre: " + Nombres + " Dirección: " + Direccion;
    } 
}