using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hh_w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывод масива
            int[] r = SetupMas();
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }

            //Console.WriteLine();
            //for (int i = 0; i < EvenNumbers(SetupMas()).Length; i++)
            //{
            //    Console.Write(EvenNumbers(SetupMas())[i]);
            //}
            //int[] resEven = EvenNumbers(EvenNumbers(SetupMas()));
            //foreach (var item in resEven)
            //{
            //Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int[] resNotEven = NotEvenNumbers(NotEvenNumbers(SetupMas()));
            //foreach (var item in resNotEven)
            //Console.Write(item + " ");

            //Console.WriteLine();    
            //int[] reverseMas = ReverseMas(r);
            //Console.WriteLine(reverseMas.Length);
            //foreach (var item in reverseMas)
            //    Console.Write(item + " ");
            //
            //bool reverse = true;
            //int[] newMas = SortMas(r, reverse);
            //foreach (var item in newMas)
            //{
            //    Console.Write(item + " ");
            //}


            Console.ReadLine();
        }
        /// <summary>
        /// Метод создания масива на 100 элементов
        /// </summary>
        /// <returns>Масив int на 100 элементов</returns>
        static int[] SetupMas()
        {
            Random r = new Random();
            int[] mas = new int[100];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-100, 100);
            }
            return mas;
        }
        /// <summary>
        /// Поиск четных элементов массива
        /// </summary>
        /// <param name="mas"></param>
        /// <returns>Массив с четными элементами</returns>
        static int[] EvenNumbers(int[] mas)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                    result.Add(mas[i]);
            }
            return result.ToArray();
        }
        /// <summary>
        /// Метод поиска не четных элементов
        /// </summary>
        /// <param name="mas"></param>
        /// <returns>Массив с не четными элементами</returns>
        static int[] NotEvenNumbers(int[] mas)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 1)
                    result.Add(mas[i]);
            }
            return result.ToArray();
        }
        /// <summary>
        /// Метод разворота массива
        /// </summary>
        /// <param name="mas"></param>
        /// <returns>Развернутый массив</returns>
        static int[] ReverseMas(int[] mas)
        {
            int[] newMass = new int[mas.Length];
            int temp = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                newMass[i] = mas[mas.Length - 1 - i];
            }
            return newMass;
        }
        /// <summary>
        /// Метод сортировки массива
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="revers"></param>
        /// <returns>Отсортированный массив, по умолчанию от меньшего к большему,
        /// при передаче revers=true - от большего к меньшему</returns>
        static int[] SortMas(int[] mas, bool revers=false)
        {
            if (!revers)
            {
                int temp;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }

            }
            else
            {
                int temp;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] < mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
            }
            return mas;
        }
    }
}
