using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class Task
    {
        public string task10(int a, int b, int c)
        {
            return ((a + b) * c).ToString() + " " + ((a * b) + (b * c)).ToString();
        }
        public int task9(int a, int b, int c, int d)
        {
            return (a + b + c + d) / 4;
        }
        public void task8(int a)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(a * i);
            }
        }
        public string task7(int a, int b)
        {
            return (a + b).ToString() + " " + (a - b).ToString() + " " + (a * b).ToString() + " " + (a / b).ToString() + " " + (a % b).ToString();
        }
        public int task6(int a, int b, int c)
        {
            return a * b * c;
        }
        public string task5(int a, int b)
        {
            return b.ToString() + " " + a.ToString();
        }
        public int task4(int a)
        {
            switch(a)
            {
                case 1: return -1 + 4 * 6;
                case 2: return (35 + 5) % 7;
                case 3: return 14 + -4 * 6 / 11;
                case 4: return 2 + 15 / 6 * 1 - 7 % 2;
                default: return 0;
            }
        }
        public int task3(int a, int b)
        {
            return a / b;
        }
        public int task2(int a, int b)
        {
            return a + b;
        }
        public string task1(string Name)
        {
            return "Hello " + Name;
        }
    }
}