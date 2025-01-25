// miperro(variable) instancia de la clase = objeto
// Perro miperro = new Perro("Firulais");
//Arrays.run();
//Listas.run();
//ListasTarea1.run();
//Pilas.run();
//PilasOtro.run();
//pilasClaseEncuentro.run();
//Torres.run();

Console.WriteLine("Universidad Estatal Amazónica");

//Definir una pila
Stack<int> miPila = new Stack<int>();

miPila.Push(4); //Push agrega valores a la pila
miPila.Push(39);
miPila.Push(100);

Console.WriteLine("Los valores de la pila son:");
foreach (var item in miPila)
{
    Console.WriteLine(item);
}

int eliminado = miPila.Pop();//Captura el valor eliminado, el último elemento de la pila
Console.WriteLine();
Console.WriteLine("Los valores de la pila son:");
foreach (var item in miPila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"El valor eliminado es: {eliminado}");

Console.WriteLine($"El ultimo elemento de la pila es {miPila.Peek()}");
Console.WriteLine("Los valores de la pila son:");
foreach (var item in miPila)
{
    Console.WriteLine(item);
}
// Esta solución es ineficiente porque repite mucho código innecesariamente.