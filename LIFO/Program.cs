using System;
using System.Collections.Generic;
class Stack<T>
{
    private T[] arr = new T[0];
    //add an element to the top of the stack
    public void Append(T val)
    {
        T[] newarray = new T[arr.Length + 1];
        for(int i=0; i < arr.Length; i++)
        {
            newarray[i] = arr[i];
        }
        newarray[arr.Length] = val;
        arr = newarray;
    }
    //remove an element from the top of the stack
    public void Delete()
    {
        T[] newarray = new T[arr.Length-1];
        for (int i = 0; i < newarray.Length; i++)
            newarray[i] = arr[i + 1];
        arr = newarray;
    }
    //show stack
    public void Show()
    {
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);
    }
    //Show the top of stack
    public void ShowTOP()
    {
        Console.WriteLine(arr[0]);
    }
}
    class Program
    {
        static void Main()
        {
        Stack<int> X = new Stack<int>();

        //add elements to stack
        X.Append(12);
        X.Append(10);
       //remove from the top
        X.Delete();
       //add to the top
        X.Append(21312);
        X.Append(30);
        //show 
        Console.Write("Top ");
        X.ShowTOP();
        Console.WriteLine("All Stack");
        X.Show();
        }
    }
