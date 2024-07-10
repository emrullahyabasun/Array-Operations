namespace Array_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            //Write the code necessary to reverse the letters of each word in place and display the result.
            string[] words = pangram.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                int left = 0;
                int right = letters.Length - 1;
                while (left < right)
                {
                    char temp = letters[left];
                    letters[left] = letters[right];
                    letters[right] = temp;
                    left++;
                    right--;
                }
                words[i] = new string(letters);
            }
            pangram = string.Join(" ", words);
            System.Console.WriteLine(pangram);
        }
    }
}