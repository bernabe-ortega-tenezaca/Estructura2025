Console.WriteLine("Universidad Estatal Amazónica");

class Persona{

}

class Producto
{
    
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