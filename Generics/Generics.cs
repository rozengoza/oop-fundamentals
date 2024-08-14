public class Generics // <T,U> yeta define garera generic class pani  banauna milcha , instance banauda  Generics<string, int> g = new()
{

    // If we have to  allow PrintDetails to  take any data types, we  can do Method  Overloading, but if there are many  requirements  we have to use Generics
    //Generics :- sending type as a parameter instead  of value 

    public void PrintDetails<T, U>(T x, U y) // T, U is Generic Data type :- send type as a parameter
    {
        Console.WriteLine($"Value of X : {x} & Value of Y : {y}");
    }
}