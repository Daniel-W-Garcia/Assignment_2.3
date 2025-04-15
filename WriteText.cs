namespace Assignment_2._3;

public class WriteText
{
    public void WriteTextFile()
    {
        try
        {
            StreamWriter sw = new StreamWriter("F:\\Example.txt");
            sw.WriteLine("""
                         Here are some basic details about me:
                         Name: Louie Lunchmeat
                         Age: 21
                         Gender: Male
                         Address: 123 Main Street, New York, NY 10001
                         """);
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