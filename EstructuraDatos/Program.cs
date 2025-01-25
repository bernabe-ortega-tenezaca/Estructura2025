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

Console.WriteLine("Los valores de la pila son:");
foreach (var item in miPila)
{
    Console.WriteLine(item);
}

miPila.Pop();//Elimina el último elemento de la pila
Console.WriteLine();
Console.WriteLine("Los valores de la pila son:");
foreach (var item in miPila)
{
    Console.WriteLine(item);
}