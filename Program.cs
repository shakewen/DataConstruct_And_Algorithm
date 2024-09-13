public class Program
{
    public static void Main()
    {
        string line = "";

        while ((line = System.Console.ReadLine()) != null)
        {
            int num = int.Parse(line);
            string str = "* ";
            do
            {
                System.Console.WriteLine(str);
                str += "* ";
            } while (num-- != 1);
        };
        return;
    }
}