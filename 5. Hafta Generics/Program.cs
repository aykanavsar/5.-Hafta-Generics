using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3 };
        PrintArray(array);

        string[] array2 = { "A", "B", "C" };
        PrintArray(array2);

        

        
        Point p = new Point();
        DisplayStructType(p);
        Shape circle = new Circle();
        DisplayShapeType(circle);


        CreatInstance<Point>();
    }

    public abstract class Shape
    {

    }
    public class Circle : Shape
    {

    }

    public static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);    
        }
    }

    
       
    

    public void GenericMethod<T>(T i)
    {
        Console.WriteLine(i);
    }

    public static void DisplayClassType<T>(T item) where T : class
    {

    }

    public static void DisplayStructType<T>(T item) where T : struct
    {

    }

    public static void DisplayShapeType<T>(T item) where T : Shape
    {

    }

    public static T CreatInstance<T>() where T : new()
    {
        return new T();

    }

    public static void DisplayCompatableType<T>(T item) where T : IComparable<T>
    {

    }

    public static void DisplayType<T>(T item) where T : class, IEntity, new()
    {

    }
}