namespace Assignment_2._3;

public class ReadText
{
    private string line;
    public void ReadTextFile()
    {
        try
        {
            StreamReader sr = new StreamReader("F:\\Example.txt");
            line = sr.ReadLine();

            while (line !=null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
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