using System;
using System.Numerics;
using System.Data;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array logic
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //string[] arr_temp = new string[n];
            //arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //  sum += arr[i];

            //}
            //Console.WriteLine(sum);
            #endregion

            #region Triplet Comparison Problem
            //int alicePoints =0, bobPoints = 0;
            //int[] tokens_a0 = Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
            //int a0 = validate(tokens_a0[0])? tokens_a0[0] : 0;
            //int a1 = validate(tokens_a0[1]) ? tokens_a0[1] : 0;
            //int a2 = validate(tokens_a0[2]) ? tokens_a0[2] : 0;
            //int[] tokens_b0 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            //int b0 = validate(tokens_b0[0]) ? tokens_b0[0] : 0;
            //int b1 = validate(tokens_b0[1]) ? tokens_b0[1] : 0;
            //int b2 = validate(tokens_b0[2]) ? tokens_b0[2] : 0;

            //CalcPoints(a0, b0, ref alicePoints, ref bobPoints);
            //CalcPoints(a1, b1, ref alicePoints, ref bobPoints);
            //CalcPoints(a2, b2, ref alicePoints, ref bobPoints);

            //Console.WriteLine(string.Format("{0} {1}",alicePoints,bobPoints));
            //Console.ReadLine();
            #endregion

            #region Factorial with Big Integer
            //BigInteger n = BigInteger.Parse(Console.ReadLine());
            //BigInteger count = n;
            //for (BigInteger i = count-1 ; i > 1; i--)
            //{
            //    //Console.WriteLine(string.Format("{0} ={1}x{2}", (n*i) ,n, i));
            //    n *= i;
            //}
            //Console.WriteLine("Ans:"+n);
            //Console.ReadLine();
            #endregion

            #region Custom Encryption
            //string s = Console.ReadLine();
            //double columns =0, rows =0;
            //string input = s.Replace(" ", string.Empty);
            //int characterCount = 0;

            //int charCount = input.Length;
            //while (input.Length > (columns * rows))
            //{
            //    columns = Math.Ceiling(Math.Sqrt(charCount));
            //    rows = Math.Floor(Math.Sqrt(charCount));
            //    charCount++;
            //}

            //Console.WriteLine("Input={0} \nCharCount = {1}\nColumns = {2}\nRows = {3}", input, input.Length, columns, rows);
            //Console.ReadLine();

            //DataTable dt = new DataTable("Characters");
            //for (int i = 1; i <= columns; i++)
            //{
            //    dt.Columns.Add("column" + i);

            //}
            //for (int j = 0; j < rows; j++)
            //{
            //    DataRow dr = dt.NewRow();
            //    for (int k = 0; k < dt.Columns.Count; k++)
            //    {

            //        dr[k] = characterCount < input.Length ? input.Substring(characterCount,1) : string.Empty;
            //        characterCount++;        
            //    }
            //    dt.Rows.Add(dr);
            //}
            //dt.AcceptChanges();

            //foreach (DataColumn dc in dt.Columns)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        Console.Write(dr[dc].ToString());
            //    }
            //    Console.Write(" ");
            //}


            //dt.Dispose();
            //Console.ReadLine();
            #endregion

            #region Pelindrom Number / String
            //string s = Console.ReadLine();
            //string input = s.Replace(" ", string.Empty);
            //s = null;


            //for (int i = 1; i <= input.Length; i++)
            //{
            //    Console.WriteLine("first ={0} Second = {1}", input.Substring(i-1, 1),input.Substring(input.Length - i, 1));
            //    if (input.Substring(i - 1, 1).Equals(input.Substring(input.Length - i, 1)))
            //    {
            //        if (i == input.Length)
            //        {
            //            Console.WriteLine("Pelindrom");
            //        }
            //        else
            //            continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Non Pelindrom");
            //        break;
            //    }
            //}
            //Console.ReadLine();
            #endregion

            #region Lexicograhically greater string
            int size = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] inputArray = new string[size];
            inputArray = s.Split(' ');
            s = null;


            foreach (string str in inputArray)
            {
                
            }
                
           

            Console.ReadLine();
            #endregion

        }

        #region Triplet Comparison Problem methods
        static void CalcPoints(int a, int b, ref int aliceP, ref int bobP)
        {
            if (a > b)
                aliceP++;
            else if (a < b)
                bobP++;
        }

        static bool validate(int x)
        {
            bool result = false;
            if (x > 0 && x < 101)
                return true;
            else
                return result;
        }
        #endregion
    }
}
