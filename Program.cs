using DataConstruct_And_Algorithm;
using System;

public class Program
{
    public static void Main()
    {
       LinkList<int> list = new LinkList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        int a = list.Delete(1);
      
          for(int i = 0; i < list.GetLength(); i++)
        {
            System.Console.WriteLine(list[i]+"");
        }
        
    }
}