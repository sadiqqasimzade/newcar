using System;
using System.Linq;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "salam";
            string b = "necesen";
            string[] array = { "salam", "necesen", "hello", "world", "!" };
            string[] temp_array = { };
            Console.WriteLine($"{null}"); //

            #region Sting static
            Console.WriteLine($"Concat1:{String.Concat(a, b)}");   //minimum 2 string max 4 string 
            Console.WriteLine($"Concat2:{String.Concat(array)}\n"); //sring arrayinda limit yoxdu

            //elifba sirasi ile ustun olani secir
            Console.WriteLine($"Compare1:{String.Compare("a", "z")}"); // str1>str2  -1
            Console.WriteLine($"Compare2:{String.Compare("z", "a")}"); // str1<str2   1
            Console.WriteLine($"Compare3:{String.Compare("a", "a")}"); // srt1==str2  0
            Console.WriteLine($"Compare4:{String.Compare("aa", "ab")}\n");

            //String.CompareOrdinal(); //String.Compare() kimidi ancaq charlarla isleyir 

            //birinci parametr "bolgu" adlanir qalan parametrlerden sonra yazilir
            Console.WriteLine($"Join1:{String.Join("+", "1", "2", "salam", "hello")}"); //metodunda  params isledilib ona gore istenilen qeder string ve uzun massiv qebul edir
            Console.WriteLine($"Join2:{String.Join(" ", array)}\n");

            Console.WriteLine($"IsNullOrWhiteSpace1:{String.IsNullOrWhiteSpace("")}");
            Console.WriteLine($"IsNullOrWhiteSpace2:{String.IsNullOrWhiteSpace(" ")}");
            Console.WriteLine($"IsNullOrWhiteSpace3:{String.IsNullOrWhiteSpace($"{null}")}");
            Console.WriteLine($"IsNullOrWhiteSpace3:{String.IsNullOrWhiteSpace("a")}\n");

            Console.WriteLine($"Empty:{String.Empty == ""}\n");//null

            Console.WriteLine($"Equals1:{String.Equals(a, b)}");
            Console.WriteLine($"Equasl2:{String.Equals("a", "a")}\n");

            //String.Format(); //???
            #endregion

            #region lazimsiz
            Console.WriteLine($"ReferenceEquals before:{String.ReferenceEquals(array, temp_array)}");
            temp_array = array;
            Console.WriteLine($"ReferenceEquals after :{String.ReferenceEquals(array, temp_array)}");

            string copyed;
            copyed = String.Copy(a);
            Console.WriteLine($"copyed:{copyed}\n");
            #endregion

            #region strings
            Console.WriteLine($"ToUpper:{a.ToUpper()}");
            Console.WriteLine($"ToLower:{a.ToLower()}\n");

            Console.WriteLine($"Length:{a.Length}\n");

            a = "SalamZHello";
            Console.WriteLine($"Min:{a.Min()}");//ascii-da A-Z a-z den kicikdi
            Console.WriteLine($"Max:{a.Max()}\n");

            Console.WriteLine($"Contains1:{a.Contains('a')}");
            Console.WriteLine($"Contains2:{a.Contains("dgas")}");
            Console.WriteLine($"Contains3:{a.Contains("z")}");
            Console.WriteLine($"Contains4:{a.Contains("Z")}\n");

            Console.WriteLine($"Type1:{a.GetType()}");
            Console.WriteLine($"Type2:{a.GetTypeCode()}\n");

            Console.WriteLine($"CompareTo:{a.CompareTo("s")}"); //String.Compare
            Console.WriteLine($"EndsWith1:{a.EndsWith("o")}");
            Console.WriteLine($"EndsWith2:{a.EndsWith("loo")}");
            Console.WriteLine($"StartWith1:{a.StartsWith("S")}");
            Console.WriteLine($"StartWith2:{a.StartsWith("Saa")}\n");

            Console.WriteLine($"Equals:{a.Equals(b)}");
            Console.WriteLine($"IndexOf:{a.IndexOf('Z')}");
            Console.WriteLine($"IsSorted:{a.IsNormalized()}");
            Console.WriteLine($"Sort:{a.Normalize()}");//sort
            Console.WriteLine($"Remove:{a.Remove(0, 4)}");
            Console.WriteLine($"RemoveAll:{a.Remove(0)}"); //tam silir
            Console.WriteLine($"Replace:{a.Replace('a', 'b')}");//charlari evez edir
            Console.WriteLine($"Substring:{a.Substring(0, 5)}\n"); //verilen indexler arasindaki metni cixarir


            Console.WriteLine($"Trim:{a.Trim()}"); // qabaqdaki bosluqlari silir
            Console.WriteLine($"Clone:{a.Clone()}"); //ozunu qaytarir    ???
            Console.WriteLine($"Insert:{a.Insert(4, a)}\n");//????
            #endregion

            #region arrays

            int[] intarray = { 1, 2, 3, -4, -6, -5, 11, 0, 65, 12, 333 };
            Array.ForEach(intarray, (x) => Console.Write(x + "|"));
            Console.WriteLine($"\n{intarray.Length}");
            Console.WriteLine($"{intarray.Rank}");

            Console.WriteLine("\nsorted:");
            Array.Sort(intarray);
            foreach (int x in intarray)
            {
                Console.Write(x + "|");
            }

            Console.Write("\nBinarySearch:");
            Console.WriteLine(Array.BinarySearch(intarray, 11));
            foreach (int x in intarray)
            {
                Console.Write(x + "|");
            }

            Console.WriteLine("\nReverse");
            Array.Reverse(intarray);                             //arrayi reverse edir
            foreach (int x in intarray)
            {
                Console.Write(x + "|");
            }

            Console.WriteLine("\nClear");
            Array.Clear(intarray, 0, 3);                        //2 index arasindaki elementleri silir
            foreach (int x in intarray)
            {
                Console.Write(x + "|");
            }

            Console.WriteLine("\nCopy");
            int[] intarray2 = new int[intarray.Length];
            Array.Copy(intarray, intarray2, 5);
            foreach (int x in intarray2)
            {
                Console.Write(x + "|");
            }

            Console.WriteLine("\n\n");


            #endregion

            #region Stringbuilder
            int size = 100;
            StringBuilder sb = new StringBuilder(size);

            for (int c = 0; c < 10; c++)
            {
                sb.Append(c);
            }
            Console.WriteLine($"String from SB:{sb}");
            Console.WriteLine($"SB length:{sb.Length}");
            Console.WriteLine($"SB size:{sb.Capacity}");
            Console.WriteLine($"SB Max Size:{sb.MaxCapacity}");
            Console.WriteLine($"New max Size{sb.EnsureCapacity(101)}"); //ovverride maxsize
            Console.WriteLine($"Type:{sb.GetType()}");
            Console.WriteLine($"Remove:{sb.Remove(0, 1)}");
            Console.WriteLine($"Insert: {sb.Insert(0, 11)}");
            Console.WriteLine($"Replace:{sb.Replace('4', '5')}");
            sb.Clear();
            Console.WriteLine($"SB length:{sb.Length}");





            #endregion

            Console.WriteLine($"{null}");



            #region garbage control   RAM USAGE WARNING!
            //string test = "."; //garbage control test
            //while(true)
            //{
            //    test += test;
            //    Console.Write(test);
            //}
            #endregion




            Console.WriteLine($"{null}");
            Console.ReadLine();
        }

    }
}
