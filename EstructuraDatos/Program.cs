// miperro(variable) instancia de la clase = objeto
// Perro miperro = new Perro("Firulais");
//Arrays.run();
//Listas.run();
//ListasTarea1.run();
//Pilas.run();
//PilasOtro.run();
//pilasClaseEncuentro.run();
//Torres.run();
//PilasCEC.run();
Console.WriteLine("Universidad Estatal Amazónica");

Stack<int> torre1 = new Stack<int>();
Stack<int> torre2 = new Stack<int>();
Stack<int> torre3 = new Stack<int>();

torre1.Push(3);
torre1.Push(2);
torre1.Push(1);

imprimirTorres();

moverElemento(torre1, torre2);
moverElemento(torre1, torre3);
moverElemento(torre2, torre3);

void moverElemento(Stack<int> origen, Stack<int> destino){
    Console.WriteLine("=============");
    destino.Push(origen.Pop());
    imprimirTorres();
}

void imprimirTorre(Stack<int> pila, string nombrePila){
    if(pila.Count >0){
        Console.WriteLine();
        Console.WriteLine(nombrePila);
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }
    }
}

void imprimirTorres(){
    imprimirTorre(torre1, "Torre 1");
    imprimirTorre(torre2, "Torre 2");
    imprimirTorre(torre3, "Torre 3");
}