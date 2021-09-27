using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp1lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;
             void types() {
                 //1
                 bool b = true;
                 byte Bt = 16;
                 sbyte sBt = 16;
                 char c = 'a';
                 decimal dec = 123;
                 double dob = -12354;
                 float flo = 524;
                 int i = -7;
                 uint ui = 8;
                 long l = 14523;
                 ulong ul = 15345;
                 short s = -1;
                 ushort us = 42;
                 Console.WriteLine(b);
                 Console.WriteLine(Bt);
                 Console.WriteLine(sBt);
                 Console.WriteLine(c);
                 Console.WriteLine(dec);
                 dob = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine(dob);
                 Console.WriteLine(flo);
                 Console.WriteLine(i);
                 Console.WriteLine(ui);
                 Console.WriteLine(l);
                 Console.WriteLine(ul);
                 Console.WriteLine(s);
                 Console.WriteLine(us);
                 
                 object o = dob;
                 double newdb = (double)o;
                 Console.WriteLine(newdb);
                 var var1 = 123;
             
                 Console.WriteLine(var1.GetType());
                 var var2 = 12.3;
                 Console.WriteLine(var2.GetType());
                 var var3 = 'q';
                 Console.WriteLine(var3.GetType());

                 Nullable<int> nuli;
                 nuli = null;
                 if (Convert.ToBoolean(nuli))
                 {
                     Console.WriteLine(nuli);
                 }
             }
             void strings()
             {
                 string s1 = "qwerty";
                 string s2 = "qwerty";
                 string s3 = "qwerti";
                 Console.WriteLine("s1 == s2:" + (s1 == s2));
                 Console.WriteLine("s2 == s3:" + (s2 == s3));
                 string sconcat = s1 + " " + s2;
                 Console.WriteLine(sconcat);
                 string copy = String.Copy(s3);
                 Console.WriteLine(copy);
                 string sub = sconcat.Substring(3);
                 Console.WriteLine(sub);
                 String[] words = sconcat.Split();
                 foreach (string word in words)
                 {
                     Console.WriteLine(word);
                 }
                 string ins = sconcat.Insert(3, s3);
                 Console.WriteLine(ins);
                 string rem = sconcat.Remove(3, 7);
                 Console.WriteLine(rem);
                 Console.WriteLine($"интерпол: {sconcat}");

                 string emp = "";
                 string snull = null;
                 Console.WriteLine($"empty: {string.IsNullOrEmpty(emp)} \n null: {string.IsNullOrEmpty(snull)}");

                 StringBuilder sb = new StringBuilder(sconcat, 50);
                 sb.Remove(3, 5);
                 sb.Append(" to end");
                 sb.Insert(3, " something ");
                 sb.Insert(0, "1234 ");
                 Console.WriteLine(sb);
             }
            
             void matrix()
             {
                 int[,] mass1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                 for (int i = 0; i < 3; i++)
                 {
                     Console.WriteLine();
                     for (int x = 0; x < 3; x++)
                     {
                         Console.Write("  " + mass1[i, x]);
                     }
                 }
                 Console.WriteLine();
                 string[] sarr = { "car", "apple", "coin" };
                 foreach (string word in sarr)
                 {
                     Console.Write("  " + word);
                 }
                 Console.Write("  length=" + sarr.Length + "\n");

                 Console.Write("change?:");
                 int change = Convert.ToInt32(Console.ReadLine());
                 Console.Write("for?:");
                 string schange = Console.ReadLine();
                 sarr[change - 1] = schange;
                 foreach (string word in sarr)
                 {
                     Console.Write("  " + word);
                 }
                 int[][] starr = { new int[2], new int[3], new int[4] };
                 Console.WriteLine("\nвведите массив:");
                 for (int i = 0; i < 3; i++)
                 {
                     Console.WriteLine();
                     for (int x = 0; x < starr[i].Length; x++)
                     {
                         starr[i][x] = Convert.ToInt32(Console.ReadLine());
                     }
                 }
                 for (int i = 0; i < 3; i++)
                 {
                     Console.WriteLine();
                     foreach (int x in starr[i])
                     {
                         Console.Write("  " + x);
                     }
                 }
                 Console.WriteLine();
                 var varr = new[] { 4, 5, 1 };
                 var vstr = "coin";
                 Console.WriteLine(varr.Length);
                 Console.WriteLine(vstr);
             }
            
            void tuple() 
            {
                ValueTuple < int,string,char,string,ulong > tuple1 = (9,"money",'x',"notchar",666);
                Console.WriteLine(tuple1);
                while (menu != 0)
                {
                    Console.WriteLine("какой элемент вывести(0-exit)?:");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine(tuple1.Item1);
                            break;
                        case 2:
                            Console.WriteLine(tuple1.Item2);
                            break;
                        case 3:
                            Console.WriteLine(tuple1.Item3);
                            break;
                        case 4:
                            Console.WriteLine(tuple1.Item4);
                            break;
                        case 5:
                            Console.WriteLine(tuple1.Item5);
                            break;
                        default:
                            break;
                    }
                }
                    double dobl = (double)tuple1.Item1;
                    Console.WriteLine(dobl);
                    var tuple2 = (9, loot: "money", 'x', "notchar", 666);
                    string tupstr = tuple2.loot;
                    Console.WriteLine(tupstr);
                    (int, long) tuple3 = (5 ,25);
                    (int, double) tuple4 = (5,25);
                    Console.WriteLine(tuple3==tuple4);
                    var _ = 4;
                
            }
            
            int[] funarr = {6,8,5,10};
            string funstr = "qwerty";
            (int, int, int, char) localfunction(int[] funarrf,string funcstrf) 
            {
                int maxf = 0;
                int minf = funarrf[0];
                int sumf = 0;
                char firstf = funcstrf[0];
                for (int i =0;i<funarrf.Length;i++) 
                {
                    if (funarrf[i]>maxf) 
                    {
                        maxf = funarrf[i];
                    }
                    if (funarrf[i] < minf)
                    {
                        minf = funarrf[i];
                    }
                    sumf += funarrf[i];
                }
                return (maxf,minf,sumf,firstf);
            }


            void forcheck() 
            {
                checked 
                {
                    int check = int.MaxValue;
                    Console.WriteLine(check);
                }
            }
            void nocheck() 
            {
                unchecked
                {
                    int ncheck = int.MaxValue+1;
                    Console.WriteLine(ncheck);
                }
            }

            //Console.ReadLine();
            int mmenu;
                mmenu=1;
                while (mmenu != 0) {
                Console.WriteLine("\n 1-типы \n 2-строки \n 3-массивы \n 4-кортежи\n 5-лок. фун.\n 6-проверка\n 0-exit");
                mmenu = Convert.ToInt32(Console.ReadLine());
                switch (mmenu)
                {
                    case 1 :
                        types();
                        break;
                    case 2:
                        strings();
                        break;
                    case 3:
                        matrix();
                        break;
                    case 4:
                        tuple();
                        break;
                    case 5:
                        (int max, int min, int summ, char first) result = localfunction(funarr, funstr);
                             Console.WriteLine(result.max);
                             Console.WriteLine(result.min);
                             Console.WriteLine(result.summ);
                             Console.WriteLine(result.first);
                        break;
                    case 6:
                        forcheck();
                        nocheck();
                        break;
                    case 0:
                        
                        break;
                }
            }


        }
    }
}
