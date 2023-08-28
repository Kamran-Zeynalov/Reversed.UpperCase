namespace String.Reverse.UppreCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string random = "ey babek kebab ye";

            char[] chars = random.ToCharArray();
            Array.Reverse(chars);

            string reversed = new(chars);
            Console.WriteLine(reversed.ToUpper());

        }
    }
}