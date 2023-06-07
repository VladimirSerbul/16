using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("заполнение Random");
            int[] array = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                array[i] = rnd.Next(1, 7);
                Console.Write(array[i] + "  ");
            }
            Chain();
            Console.WriteLine("заполнение Randomize");
            for (int i = 0; i < 1000; i++)
            {
                array[i] = rnd.Next(1, 7);
                Console.Write(array[i] + "  ");
            }
            Chain();
            void Chain()
            {
                Console.WriteLine();
                int k = 1;
                int el = array[0];
                int ind = 0;
                int maxk = k;
                int maxel = el;
                int maxind = ind;

                for (int i = 0; i < 999; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        k += 1;
                        if (k > maxk)
                        {
                            maxk = k;
                            maxel = el;
                            maxind = ind;
                        }
                    }
                    else
                    {
                        k = 1;
                        el = array[i + 1];
                        ind = i + 1;
                    }
                }
                Console.WriteLine("длина самой длинной цепочки " + maxk);
                Console.WriteLine("элемент самой длинной цепочки " + maxel);
                Console.WriteLine("первый индекс самой длинной цепочки " + maxind);
            }

            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}

