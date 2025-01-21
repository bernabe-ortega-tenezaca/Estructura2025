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