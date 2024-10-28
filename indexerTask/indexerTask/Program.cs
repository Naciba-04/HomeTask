<<<<<<< HEAD
﻿namespace indexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();
            list.Add(1);
            list.Add(2);    
            list.Add(3,4,5);
            list.Add(6,7,8,9);
            Console.WriteLine("List"+"-"+""+list.ToString());
            list.Insert(4, 2);
            Console.WriteLine("Insert" + "-" + "" + list.ToString());
            Console.WriteLine("Sum" + "-" + "" + list.Sum());
            Console.WriteLine("Average" + "-" + "" + list.Average());
            Console.WriteLine("Contains" + "-" + "" + list.Contains(7));
            Console.WriteLine("Index of" + "-" + "" + list.IndexOf(2));
            Console.WriteLine("Last Index of" + "-" + "" + list.LastIndexOf(5));
            Console.WriteLine("Pop" + "-" + "" + list.Pop());
            Console.WriteLine("List" + "-" + "" + list.ToString());
        }
    }
}
=======
﻿namespace indexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();
            list.Add(1);
            list.Add(2);    
            list.Add(3,4,5);
            list.Add(6,7,8,9);
            Console.WriteLine("List"+"-"+""+list.ToString());
            list.Insert(4, 2);
            Console.WriteLine("Insert" + "-" + "" + list.ToString());
            Console.WriteLine("Sum" + "-" + "" + list.Sum());
            Console.WriteLine("Average" + "-" + "" + list.Average());
            Console.WriteLine("Contains" + "-" + "" + list.Contains(7));
            Console.WriteLine("Index of" + "-" + "" + list.IndexOf(2));
            Console.WriteLine("Last Index of" + "-" + "" + list.LastIndexOf(5));
            Console.WriteLine("Pop" + "-" + "" + list.Pop());
            Console.WriteLine("List" + "-" + "" + list.ToString());
        }
    }
}
>>>>>>> aad39f3a6407d40fd1e38c7eb5cc4a967fa737f8
