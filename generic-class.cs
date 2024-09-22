/*
Crea una clase genérica llamada Caja<T> que pueda almacenar un objeto de cualquier tipo. Esta clase debe tener los siguientes métodos:

Un constructor que reciba el valor a almacenar.
Un método ObtenerElemento() que devuelva el valor almacenado.
Un método MostrarTipo() que imprima el tipo del elemento almacenado.
*/

using System;

class Caja<T> {
    private T valor;

    public Caja(T valor){
        this.valor = valor;
    }

    public T ObtenerElemento(){
        return this.valor;
    }

    public void MostrarTipo(){
        Console.WriteLine($"El tipo de valor es: {ObtenerElemento().GetType()}");
    }        
}

class Program{
    static void Main() {
            var caja = new Caja<string>("Im Adriana, nice to meet u");
            Console.WriteLine(caja.ObtenerElemento());
            caja.MostrarTipo();
    } 
}
