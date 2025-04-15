namespace Assignment_2._3;

public class WriteText
{
    public void WriteTextFile()
    {
        try
        {
            StreamWriter sw = new StreamWriter("F:\\Example.txt");
            sw.WriteLine("Hello World");
            sw.WriteLine("This is a test");
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}