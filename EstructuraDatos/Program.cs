Console.WriteLine("Universidad Estatal Amazónica");

// miperro(variable) instancia de la clase = objeto
// Perro miperro = new Perro("Firulais");

//Arrays.run();
//Listas.run();
//ListasTarea1.run();
//Pilas.run();
//PilasOtro.run();
//pilasClaseEncuentro.run();

Stack<int> torre1 = new Stack<int>();
Stack<int> torre2 = new Stack<int>();
Stack<int> torre3 = new Stack<int>();

torre1.Push(3);
torre1.Push(2);
torre1.Push(1);

ImprimirTorre(torre1);

// foreach (var item in torre1)
// {
//     Console.WriteLine(item);
// }
Console.WriteLine();

torre2.Push(torre1.Pop());
ImprimirTorre(torre2);
// 

// foreach (var item in torre2)
// {
//     Console.WriteLine(item);
// }

void ImprimirTorre(Stack<int> pila){
    foreach (var item in pila)
    {
        Console.WriteLine(item);
    }
}