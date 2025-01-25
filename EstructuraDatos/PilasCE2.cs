public static class PilasCE2{
    public static void run(){
        Stack<int> torre1 = new Stack<int>();
        Stack<int> torre2 = new Stack<int>();
        Stack<int> torre3 = new Stack<int>();

        torre1.Push(3);
        torre1.Push(2);
        torre1.Push(1);


        imprimirPila(torre1,"Torre 1");
        imprimirPila(torre2,"Torre 2");
        imprimirPila(torre3,"Torre 3");

        torre2.Push(torre1.Pop());

        imprimirPila(torre1,"Torre 1");
        imprimirPila(torre2,"Torre 2");
        imprimirPila(torre3,"Torre 3");

        torre3.Push(torre1.Pop());
        imprimirPila(torre1,"Torre 1");
        imprimirPila(torre2,"Torre 2");
        imprimirPila(torre3,"Torre 3");

        //función para imprimir los datos de una pila en pantalla
        void imprimirPila(Stack<int> pila, string nombrePila){
            Console.WriteLine();
            Console.WriteLine($"Los datos de la pila {nombrePila} son: ");
            foreach (var item in pila)
            {
                Console.WriteLine(item);
            }
        }
    }
}