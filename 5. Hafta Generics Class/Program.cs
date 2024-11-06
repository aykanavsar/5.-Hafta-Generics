using _5._Hafta_Generics_Class;
public class Program
{
    public static void Main(string[] args)
    {
        GenericStack<int> stack = new GenericStack<int>();

        Console.WriteLine(stack.IsEmpty());

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());

        GenericStack<string> str5tack   = new GenericStack<string>();

        str5tack.Push("A");
        str5tack.Push("B");
        str5tack.Push("C");

        Console.WriteLine(str5tack.Pop());
        Console.WriteLine(str5tack.Peek());
        Console.WriteLine(str5tack.Pop());

    }
}


    
