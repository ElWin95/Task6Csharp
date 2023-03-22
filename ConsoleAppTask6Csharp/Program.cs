namespace ConsoleAppTask6Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    string strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out int c))
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    string strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out int n))
            //    {
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        a[i] = int.Parse(Console.ReadLine());
            //    }

            //    Console.Write("Massivin uyğunluğu: ");

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            Console.Write(a[i] + " ");
            //        }
            //    }

            //    Console.ReadKey();
            #endregion
            #region Task2
            //    string strC, strN;
            //    int c, n;
            //    double numAverage;
            //    int sum = 0;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        a[i] = int.Parse(Console.ReadLine());
            //    }

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            sum += a[i];
            //            count++;
            //        }
            //    }
            //    numAverage = sum / count;
            //    Console.WriteLine($"Ededi ortasi: {numAverage}");

            //    Console.ReadKey();
            #endregion
            #region Task3
            //    string strC, strN;
            //    int c, n;
            //    double geometricMean;
            //    int product = 1;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        a[i] = int.Parse(Console.ReadLine());
            //    }

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) > c)
            //        {
            //            product *= a[i];
            //            count++;
            //        }
            //    }
            //    geometricMean = Math.Pow(product, 1.0 / count);
            //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");

            //    Console.ReadKey();
            #endregion
            #region Task4
        //    string strC, strN;
        //    int c, n;
        //L1:
        //    Console.Write("C deyerini daxil edin: ");
        //    strC = Console.ReadLine();
        //    if (!int.TryParse(strC, out c))
        //    {
        //        goto L1;
        //    }
        //L2:
        //    Console.Write("Massivin uzunluğunu daxil edin: ");
        //    strN = Console.ReadLine();
        //    if (!int.TryParse(strN, out n))
        //    {
        //        goto L2;
        //    }
        //    int[] a = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
        //        a[i] = int.Parse(Console.ReadLine());
        //    }
        //    int[] result = Array.FindAll(a, x => Math.Abs(x) > c);
        //    Array.Sort(result);
        //    Array.Reverse(result);

        //    Console.WriteLine($"Massivde mutleq deyeri {c}-den boyuk olan elementlerdir");
        //    foreach (int i in result)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadKey();
            #endregion
        }
    }
}