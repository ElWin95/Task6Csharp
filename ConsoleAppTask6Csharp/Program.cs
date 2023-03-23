using System.Threading.Channels;

namespace ConsoleAppTask6Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /* 1.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek  
              (c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de)
             */
            //    string strC, strN, strA;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
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
            /* 2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq
             */
            //    string strC, strN, strA;
            //    int c, n;
            //    double numAverage;
            //    int sum = 0;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
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
            /* 3.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq
             */
            //    string strC, strN, strA;
            //    int c, n;
            //    double geometricMean;
            //    int product = 1;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
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
            /* 4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq
             */
            //    string strC, strN, strA;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
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
            #region Task5
            /* 5.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementler icinden maximum elementi tapmaq
             */
            //    string strC, strN, strA;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    int[] result = Array.FindAll(a, x => Math.Abs(x) < c);
            //    Array.Sort(result);
            //    Array.Reverse(result);

            //    Console.WriteLine($"Massivde mutleq deyeri {c}-den kicik olan maximum element ashagidakidir.");
            //    foreach (int i in result)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //    Console.ReadKey();
            #endregion
            #region Task6
            /* 6.  X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir ki x[i] = y[i] ^ 2 
               (eyni indexdeki x elementi hemin indexdeki y elementin kvadratina beraber olsun)
             */
            //    string strN1, strN2, strX, strY;
            //    int n1, n2;
            //L1:
            //    Console.Write("X(n) massivin uzunluğunu daxil edin: ");
            //    strN1 = Console.ReadLine();
            //    if (!int.TryParse(strN1, out n1))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //    int[] x = new int[n1];

            //    for (int i = 0; i < n1; i++)
            //    {
            //    l2:
            //        Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //        strX = Console.ReadLine();
            //        if (!int.TryParse(strX, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }
            //L3:
            //    Console.Write("Y(n) massivin uzunluğunu daxil edin: ");
            //    strN2 = Console.ReadLine();
            //    if (!int.TryParse(strN2, out n2))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L3;
            //    }
            //    int[] y = new int[n2];

            //    for (int j = 0; j < n2; j++)
            //    {
            //    l4:
            //        Console.Write("Y[" + (j + 1) + "] deyerini daxil edin: ");
            //        strY = Console.ReadLine();
            //        if (!int.TryParse(strY, out y[j]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l4;
            //        }
            //    }
            //    Console.Write("Netice: ");
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //      for (int j = 0; j < y.Length; j++)
            //        {
            //            if (x[i] == Math.Pow(y[j], 2))
            //            {
            //                Console.Write($"{x[i]} ");
            //            }
            //        }
            //    }

            //    Console.ReadKey();
            #endregion
            #region Task7
            /* 7.  a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk elementlerinin hendesi ve ededi ortasini tapmali
             */
        //    string strN, strA;
        //    int n, max, min;
        //    double numAverage, geometricMean;
        //l1:
        //    Console.Write("Massivin uzunluğunu daxil edin: ");
        //    strN = Console.ReadLine();
        //    if (!int.TryParse(strN, out n))
        //    {
        //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
        //        goto l1;
        //    }
        //    int[] a = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //    l2:
        //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
        //        strA = Console.ReadLine();
        //        if (!int.TryParse(strA, out a[i]))
        //        {
        //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
        //            goto l2;
        //        }
        //    }
        //    max = a[0];
        //    min = a[0];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > max)
        //        {
        //            max = a[i];
        //        }
        //        if (a[i] < min)
        //        {
        //            min = a[i];
        //        }
        //    }
        //    numAverage = (max + min) / 2;
        //    geometricMean = Math.Pow((max * min), 1.0 / 2);
        //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");
        //    Console.WriteLine($"Ededi ortasi: {numAverage}");

        //    Console.ReadKey();
            #endregion
        }
    }
}