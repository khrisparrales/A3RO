/*
 * Created by SharpDevelop.
 * User: khris
 * Date: 04/02/2021
 * Time: 15:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace A3RO
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matrizn2 = new int[10,10];
            int ta;
            int [] VECES=new int[10];
            int [] numeros=new int[] { 1,2,3,4,5,6,7,8,9,10};
            Random num10ale = new Random();
             ta = 0; 
            Console.SetCursorPosition(68, 1); Console.WriteLine("valor " + " veces " + " procentaje ");
            for (int ifil = 0; ifil <= matrizn2.GetUpperBound(0); ifil++)
            {
               
                for (int jcol = 0; jcol <= matrizn2.GetUpperBound(1); jcol++)
                {
                       
                    Console.SetCursorPosition(jcol * 5, (ifil + 1) * 2); matrizn2[ifil, jcol] = num10ale.Next(1, 11);
                    if(matrizn2[ifil,jcol]==numeros[ifil])
                    {
                        ta +=1;
                        VECES[ifil]+=1;
                        //sasa[ifil] = jcol;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0;i<=9;i++)
            {
                
                    	Console.SetCursorPosition(68, (2 + i) * 2);Console.WriteLine((i+ 1) + "        " + ta);
                    Console.SetCursorPosition(88, (2 + i) * 2); Console.WriteLine(matrizn2[ta, jcol]); Console.SetCursorPosition(90, (2 + i) * 2); Console.WriteLine("%");
            }
                    Console.ForegroundColor = ConsoleColor.White;
                }
             
            }
            for (int ifil = 0; ifil <= matrizn2.GetUpperBound(0); ifil++)
            {
                for (int jcol = 0; jcol <= matrizn2.GetUpperBound(1); jcol++)
                {
                    Console.SetCursorPosition((jcol + 3) * 5, (ifil + 2) * 2); Console.Write(matrizn2[ifil, jcol]);
                }
            }
          
            Console.ReadKey();
		}
	}
}