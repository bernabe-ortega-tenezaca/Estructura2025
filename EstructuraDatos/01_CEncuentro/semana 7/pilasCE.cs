public static class pilasClaseEncuentro{
    public static void run(){
        Stack<int> pilaEnteros = new Stack<int>();

        pilaEnteros.Push(100);
        pilaEnteros.Push(3);
        pilaEnteros.Push(7);

        foreach ( var item in pilaEnteros)
{
    Console.WriteLine(item);
}

//Mostrar el elemento de la parte superior sin eliminar
int ultimoelemento = pilaEnteros.Peek();
Console.WriteLine($"El último elemento es: {ultimoelemento}");

foreach ( var item in pilaEnteros)
{
    Console.WriteLine(item);
}

//Elimina el último elemento
int numeroelminado = pilaEnteros.Pop();
Console.WriteLine();
foreach ( var item in pilaEnteros)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\n se ha eliminado el {numeroelminado}");
    }
}