namespace ConsoleAppTask6Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.Write("C dəyərini daxil edin: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Massivin uzunluğunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] dəyərini daxil edin: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Massivin uyğunluğu: ");

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i]) < c)
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.ReadKey();
            #endregion
        }
    }
}