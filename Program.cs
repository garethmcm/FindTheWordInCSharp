public class Program
{
    public static void Main(String[] args) {

        Program program = new Program();
        string[] example = { "hello world, this is a test", "hello,world,test" };
        program.dictionary(example);
        string[] example_input = { "hellocat", "apple,bat,cat,goodbye,hello,yellow,why" };
        program.dictionary(example_input);
        string[] wrongUn = { "hello world, this is a test", "nada" };
        program.dictionary(wrongUn);

    }

    public void dictionary(string[] input)
    {
        // # Assign contents to strings
        string conString = input[0];
        string squidgeOfWords = input[1];
        
        // # Split into individual words
        string[] words = squidgeOfWords.Split(',');

        List<string> foundWords = new List<string>();

        foreach (string word in words)
        {
            if (conString.Contains(word))
            {
                foundWords.Add(word);
            }
        }
        
        Console.WriteLine("The found words in " + squidgeOfWords + " are:");
        
        foreach (string word in foundWords)
        {
            Console.WriteLine(word);
        }
        
        Console.WriteLine("End of list.");

    }
    
}