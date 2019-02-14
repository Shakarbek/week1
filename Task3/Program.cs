using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); /* с помощью int.Parse превращаем введенную строку в число*/
            string a = Console.ReadLine(); /*введем массив как строку*/

            int[] m = new int[n]; /*создаем массив, который имеет n чисел*/
            string[] b = a.Split(); /*создаем еще одну строку, которая состоит из подстрок строки а*/

            for (int i=0; i<n; i++)
            {
                m[i] = int.Parse(b[i]);/*переобразуем подстроки р в числа массива m*/

            }
            for(int i=0; i<n; i++)
            {
                Console.Write(m[i] + " " + m[i]+ " ");//выводим числа массива дублируя

            }
        }
    }
}
