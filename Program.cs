namespace Array_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("reverse Sorted...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Array.Sort(pallets);
            //print the sorted array on console
            Console.WriteLine(string.Join(", ", pallets));

           
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }
    }
}
