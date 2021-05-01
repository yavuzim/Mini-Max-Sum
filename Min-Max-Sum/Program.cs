using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Min_Max_Sum
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long toplam, sonuc = 0;
            int sayac = -1;
            long[] sumArr = new long[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                sayac++; toplam = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    toplam += arr[j];
                    if (j + 1 == arr.Count)
                    {
                        sonuc = toplam - arr[sayac];
                        sumArr[sayac] = sonuc;
                    }
                }
            }

            Console.Write("Toplamların En Küçüğü : " + sumArr.Min() + "\n " + "Toplamların En Büyüğü : " + sumArr.Max());
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
            Console.ReadLine();
        }
    }
}
