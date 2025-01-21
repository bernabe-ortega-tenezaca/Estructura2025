public static class Arrays{
    public static void run(){

        Console.WriteLine("Clase 3 - arrays y matrices");

        //datos primitivos (int, string, double, boolean)
        string[] nombres = new string[4]; // un array de 4 strings

        //datos compuestos(clases)
        Persona[] personas = new Persona[4]; // un array de 4 objetos persona

        //Persona persona1= new Persona()
        Persona persona1 = new Persona("1234567890", "Adan", "Puyo", "09878890");

        personas[0] = persona1;
        // Console.WriteLine(personas[0].Nombres);
        // Console.WriteLine(personas[0].Direccion);
        // Console.WriteLine($"Su cedula {personas[0].Cedula} ha sido registrado");

        Console.WriteLine(personas[0].getPersona());

    }
}