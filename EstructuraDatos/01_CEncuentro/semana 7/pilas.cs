public static class Pilas{
    public static void run(){
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Pilas (Stack) - Semana 7");

        // Definir una pila
        Stack<int> numeros = new Stack<int>(); // la variable números es una pila

        // método Push que agrega elementos
        numeros.Push(1);
        numeros.Push(2);
        numeros.Push(100);
        numeros.Push(20);


        //imprimir los elementos de la pila
        Console.WriteLine(numeros.Pop()); //Elimina el último elemento y lo imprime
        Console.WriteLine();
        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
    }
}








