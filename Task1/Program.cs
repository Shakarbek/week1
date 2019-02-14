using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    { /*создаем функцию, чтобы определить простое ли число или составное*/
        static bool f(int k)
        {
            if (k <= 1) return false;
            if (k == 2) return true;
            else
            {
                bool t = true;
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0) //проверим делится ли к на числа с 2 до к. Если будет хоть одно число, прерываем.
                    {
                        t = false;
                        break;
                    }
                }
                return t;

            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); /* с помощью int.Parse превращаем введенную строку в число*/

            string a = Console.ReadLine();/*создаем множество как строку*/

            int[] k = new int[n]; /*создаем массив, который имеет n чисел*/
            string[] p = a.Split();/*создаем еще одну строку, которая состоит из подстрок строки а*/

            for (int i = 0; i < n; i++)
            {

                k[i] = int.Parse(p[i]);/*переобразуем подстроки р в числа массива к*/

            }
            int cnt = 0;/*счетчик(число простых чисел во множестве)*/
            for (int i = 0; i < n; i++)
            {
                if (f(k[i]) == false) k[i]=0; /*с помощью функций определим каждое число массива. если это не простое число, превращаем число в 0 */
                else cnt++;/*если это простое число, то прибавляем 1 к счетчику*/
            }
            Console.WriteLine(cnt);/*выводим количество простых чисел */
            Console.WriteLine("=============");
            for (int i = 0; i < n; i++)
            {
                if (k[i] != 0) Console.Write(k[i] + " ");/*так как все числа кроме простых равны 0, мы должны вывести на экран все числа кроме 0*/
            }
        }
    }
}
