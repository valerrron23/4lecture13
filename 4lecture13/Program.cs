using System;

namespace lecture13_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] i = { //задание элементов массива
			4,
            3,
            7,
            23,
            6,
            8,
            123,
            6,
            32
        };
            QuickSort(i, 0, 8); //быстрая сортировка
            foreach (int w in i) //выполнять для каждого указанного элемента
            {
                Console.WriteLine(w); //вывод
            }

            Console.ReadKey(); //ожидание нажатия клавиши

        }

        private static int[] QuickSort(int[] a, int i, int j)
        {
            if (i < j) //выполнять, если верно условие
            {
                int q = Partition(a, i, j); //задание переменной
                a = QuickSort(a, i, q); //быстрая сортировка
                a = QuickSort(a, q + 1, j);//быстрая сортировка
            }
            return a; //возврат значения переменной
        }

        private static int Partition(int[] a, int p, int r)
        {
            int x = a[p]; //задание массива
            int i = p - 1; //задание переменной целочисленного типа
            int j = r + 1; //задание переменной целочисленного типа
            while (true) //выполнять, пока логическое значение истинно
            {
                do
                {
                    j--; //декремент
                }
                while (a[j] > x); //выполнять, пока верно условие
                do
                {
                    i++; //инкремент
                }
                while (a[i] < x); //выполнять, пока верно цсловие
                if (i < j) //выполнять, если верно условие
                {
                    int tmp = a[i];//задание массива
                    a[i] = a[j]; //задание массива
                    a[j] = tmp; //присвоение массива переменной
                }
                else//другой исход
                {
                    return j; //возврат j
                }
            }
        }

    }
}