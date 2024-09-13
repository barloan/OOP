using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 (типы данных)
            //1а
            bool a1 = true;
            byte a2 = 255;
            sbyte a3 = -128;
            char a4 = 'a';
            decimal a5 = -1;
            double a6 = 0.225;
            float a7 = 3.4f;
            int a8 = 1;
            uint a9 = 4294967295;
            long a11 = 9000000000;
            ulong a12 = 11;
            short a13 = 32767;
            ushort a14 = 0;
            string a15 = "Hello";
            object a16 = "world";

            Console.WriteLine("Введите переменную типа bool");
            a1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите переменную типа byte");
            a2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите переменную типа sbyte");
            a3 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите переменную типа char");
            a4 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите переменную типа demical");
            a5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите переменную типа double");
            a6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите переменную типа float");
            a7 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите переменную типа int");
            a8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную типа uint");
            a9 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную типа long");
            a11 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ulong");
            a12 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите переменную типа short");
            a13 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ushort");
            a14 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите переменную типа string");
            a15 = Console.ReadLine();
            Console.WriteLine("Введите переменную типа object ");
            a16 = (Console.ReadLine());
            Console.WriteLine();

            //1b (явные/неявные операции приведения)
            double implicitd = a13;
            float implicitf = a13;
            int impliciti = a13;
            long implicitl = a13;
            short implicits = a2;

            int expliciti = (int)(a7);
            short explicitsh = (short)(a7);
            long explicitl = (long)(a8);
            byte explicitb = (byte)(a13);
            sbyte explicits = (sbyte)(a7);

            //1c (упаковка и распоковка)
            Object boxing = a8;
            boxing = 564;
            a8 = (int)boxing;

            //1d (неявно типизированная переменная)
            var value = 33;
            Console.WriteLine(value.GetType());
            Console.WriteLine();

            //1e (nullable)
            double? d = null;
            Console.WriteLine(d);
            Console.WriteLine();

            //1f
            var number = 11;
            //number = true; будет ошибка, так как компилятор 1 раз определяет тип
            Console.WriteLine(number.GetType());
            Console.WriteLine();


            //2 (строки)
            //2a (строковые литералы)
            string lit1 = "a";
            string lit2 = "b";
            string lit3 = "a";
            Console.WriteLine($"Сравнение 1 и 2 строки: {lit1 == lit2} ");
            Console.WriteLine($"Сравнение 2 и 3 строки: { lit2 == lit3}");
            Console.WriteLine($"Сравнение 1 и 3 строки: {lit1 == lit3} ");
            Console.WriteLine();

            //2b  (сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки)
            // интерполирование строк
            string h = "Hello ";
            string w = "world";
            string t = "Какой хороший день";
            Console.WriteLine($"Сцепление строк: {string.Concat(h, w)}");
            Console.WriteLine($"Копирование строки: {String.Copy(w)}");
            Console.WriteLine($"Выделение подстроки: { h.Substring(1)} {w.Substring(0, w.Length - 1)}");
            Console.WriteLine("Разделение строки на слова: ");
            string[] splt = t.Split(new char[] { ' ' });
            foreach (string s in splt)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"Вставка подстроки в заданную позицию: {t.Insert(6, w)}");
            Console.WriteLine($"Удаление заданной подстроки: {t.Remove(0, 6)}");
            Console.WriteLine();

            //2c (пустая строка, string.IsNullOrEmp)
            string st1 = "";
            string st2 = null;
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(st1)}");
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(st2)}"); //вернет true, если st2 равен null или пустой строке
            Console.WriteLine($"Сцепление строк: {string.Concat(st1, st2)}");
            Console.WriteLine($"Сравнение пуст и null строк: {st1 == st2}");
            Console.WriteLine();

            //2d (динамическая строка, используется библиотека System.Text, StringBuilder)
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Remove(7, 4);
            Console.WriteLine($"StringBuilder: {sb}");
            sb.Insert(6,"a");
            Console.WriteLine($"StringBuilder: {sb}");
            Console.WriteLine();



            //3 (массивы)
            //3a 
            int[,] arr = { { 2, 2 }, { 3, 3 }, { 4,4 } };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = 2;
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write($"{arr[i, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //3b (одномерный массив)
            string[] arr1 = { "aaa", "bbb", "ccc", "ddd" };
            foreach (string str in arr1)
            {
                Console.WriteLine($"Массив: \n {str} ");
            }
            Console.WriteLine($"Длина массива: {arr1.Length}");
            Console.WriteLine("Введите номер изменяемого элемента");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиете новый элемент");
            arr1[q] = Console.ReadLine();
            foreach (string str in arr1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            //3c (ступенчатый массив)
            int[][] jaggedarr = new int[3][];
            jaggedarr[0] = new int[2];
            jaggedarr[1] = new int[3];
            jaggedarr[2] = new int[4];
            Console.WriteLine("Заполни ступенчатый массив: ");
            for (int n = 0; n < 2; n++)
            {
                jaggedarr[0][n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int n = 0; n < 3; n++)
            {
                jaggedarr[1][n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int n = 0; n < 4; n++)
            {
                jaggedarr[2][n] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int[] row in jaggedarr)
            {
                foreach (int ar in row)
                {
                    Console.Write($"{ar} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //3d (Неявно типизированные массивы) 
            var arrn = new[] { 1, 2, 3, 4, 5 };
            var strn = "Good day";
            Console.WriteLine($"Массив чисел:");
            for(int i =0; i <5; i++)
            {
                Console.Write(arrn[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Строка: {strn}") ;
            Console.WriteLine();

            //4 кортежи (набор значений, заключенных в круглые скобки)
            //4a,b
            (int, string, char, string, ulong) tupp = (4, "hi", 'l', "tea", 0);
            Console.WriteLine(tupp);
            Console.WriteLine(tupp.Item1);
            Console.WriteLine(tupp.Item3);
            Console.WriteLine(tupp.Item4);
            Console.WriteLine();


            //4c (распоковка кортежа)
            var tupl = (1, 5.3f, 'h');
            //способ 1
            (int numb, float fl, char u) = tupl;
            Console.WriteLine($"Кортеж: {numb} {fl} {u}");
            //способ 2
            int numb1 = tupl.Item1;
            float fl1 = tupl.Item2; 
            char u1 = tupl.Item3;   
            Console.WriteLine($"Кортеж1: {numb1} {fl1} {u1}");
            //способ 3
            (int numb2,_ , char u2) = tupl;
            Console.WriteLine($"Кортеж2: {numb2} {u2}");
            Console.WriteLine();

            //4d (сравнение кортежа)
            (int a, long b) tup1 = (1, 5);
            (short a, byte b) tup2 = (0, 5);
            Console.WriteLine(tup1 == tup2);
            Console.WriteLine();


            //5 локальная функция
            (int, int, int, char) LocalFunction(int[] numbers, string line)
            {
                int max = numbers[0];
                int min = numbers[0];
                int sum = 0;
                int j;
                for( j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > max)
                    {
                        max = numbers[j];
                    }
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                    }
                    sum += numbers[j];
                }
                char frst = line[0];
                var tulep = (max, min, sum, frst);
                return tulep;
            }
            int[] numbers1 = new int[4];
            numbers1[0] = 4;
            numbers1[1] = 9;
            numbers1[2] = -5;
            numbers1[3] = 45;
            string line1 = "gfd";
            Console.WriteLine(LocalFunction(numbers1, line1));
            Console.WriteLine();

            //6 checked/un  (переполнение целочисленной арифметики)
            //6a,b.c 
            int ni = 5;
            int Function2()
            {
                int a = int.MaxValue;
                unchecked
                {
                    a = a + 5;
                    Console.WriteLine(a);

                }
                return a;
            }
            int Function3()
            {
                int a = int.MaxValue;
                checked
                {
                    a = a + 5;
                    Console.WriteLine(a);

                }
                return a;
            }
            Console.WriteLine(Function2());
            Console.WriteLine(Function3());
        }


    }
}
