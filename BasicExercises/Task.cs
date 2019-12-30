using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class Task
    {
        public void task30(string a)
        {
            char[] hmm = a.ToCharArray();
            char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            double Summarizer = 0;
            for (int i = 0; i < hmm.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if(hmm[i] == Numbers[j])
                    {
                        double HexaInt = 0;
                        switch(Numbers[j])
                        {
                            case 'A': HexaInt = 10; break;
                            case 'B': HexaInt = 11; break;
                            case 'C': HexaInt = 12; break;
                            case 'D': HexaInt = 13; break;
                            case 'E': HexaInt = 14; break;
                            case 'F': HexaInt = 15; break;
                            default: HexaInt = int.Parse(Numbers[j].ToString()); break;
                        }
                        Summarizer += HexaInt * Math.Pow(16, hmm.Length-1-i);
                    }
                }
            }
            Console.WriteLine(Summarizer);
        }
        public string task28(string a)
        {
            string[] aArr = a.Split(' ');
            string Returner = string.Empty;
            for (int i = aArr.Length-1; i >= 0; i--)
            {
                Returner += aArr[i] + " ";
            }
            return Returner;
        }
        public int task27(int a)
        {
            string AStr = a.ToString();
            int Sum = 0;
            for (int i = 0; i < AStr.Length; i++)
            {
                Sum += int.Parse(AStr[i].ToString());
            }
            return Sum;
        }
        public int task26()
        {//Denne her er udfordrene og jeg skal tænke videre over mulige løsninger i fremtiden.
            int counter = 0;
            int PrimeSum = 0;
            int PotentialPrime = 2;
            while(counter < 500)
            {
                if(task26HelperFunction(PotentialPrime) == true)
                {
                    PrimeSum += PotentialPrime;
                    counter++;
                    PotentialPrime++;
                }
                else
                {
                    PotentialPrime++;
                }
            }
            return PrimeSum;
        }
        public bool task26HelperFunction(int a)
        {
            if(a == 1){return false;}

            if(a == 2){return true;}

            for (int i = 2; i < a; i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void task25()
        {
            for (int i = 0; i <= 99; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public string task24(string a)
        {
            //Løsning med split
            string[] wordArray = a.Split(' ');
            int CurrentLongest = wordArray[0].Length;
            int LongestIndex = 0;
            for (int i = 0; i < wordArray.Length; i++)
            {
                if(wordArray[i].Length > CurrentLongest)
                {
                    CurrentLongest = wordArray[i].Length;
                    LongestIndex = i;
                }
            }
            return "The Longest word in the string is: " + wordArray[LongestIndex];
            //Løsning uden split for the lolz
         /*   int SpaceCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == ' ')
                {
                    SpaceCounter++;
                }
            }
            string[] wordString = new string[SpaceCounter + 1];
            int TempIndex = 0;
            int wordStringIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                string TempStr = "";
                if(a[i] == ' ')
                {
                    for (int j = TempIndex; j < i; j++)
                    {
                        TempStr += a[j];
                    }
                    TempIndex = i + 1;
                    wordString[wordStringIndex] = TempStr;
                    wordStringIndex++;
                }
                else if(i == a.Length -1)
                {
                    for (int j = TempIndex; j < a.Length; j++)
                    {
                        TempStr += a[j];
                    }
                    wordString[wordStringIndex] = TempStr;
                }
            }
            int CurrentMaxLength = wordString[0].Length;
            int MaxLengthIndex = 0;
            for (int i = 0; i < wordString.Length; i++)
            {
                if(wordString[i].Length > CurrentMaxLength)
                {
                    CurrentMaxLength = wordString[i].Length;
                    MaxLengthIndex = i;
                }
            }
            return "The longest word in the string is: " + wordString[MaxLengthIndex];*/
        }
        public string task23(string a)
        {
            string UpperABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ#";
            string LowerABC = "abcdefghijklmnopqrstuvwxyzæøå#";
            char[] aArray = a.ToCharArray();
            a = string.Empty;
            for (int i = 0; i < aArray.Length; i++)
            {
                for (int j = 0; j < UpperABC.Length; j++)
                {
                    if(aArray[i] == UpperABC[j])
                    {
                        aArray[i] = LowerABC[j];
                    }
                }
            }
            for (int i = 0; i < aArray.Length; i++)
            {
                a += aArray[i];
            }
            return a; //or just return a.ToLower();
        }
        public bool task22(int a)
        {
            if(Math.Abs(100-a) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task21(int a, int b)
        {
            if(a == 20 || b == 20 || a + b == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int task20(int f, int l)
        {
            if(f >= l)
            {
                return 2 * (f - l);
            }
            else
            {
                return l - f;
            }
        }
        public int task19(int a, int b)
        {
            if(a == b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
        }
        public bool task18(int a, int b)
        {
            if(a < 0 && b > 0 || a > 0 && b < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string task17(string a)
        {
            return a.Substring(0, 1) + a + a.Substring(0, 1);
        }
        public string task16(string c)
        {
            if(c.Length > 2)
            {
                return c.Substring(c.Length - 1, 1) + c.Substring(1, c.Length - 2) + c.Substring(0, 1);
            }
            else
            {
                return c;
            }

        }
        public string task15(string c, int i)
        {
            string Returner = string.Empty;
            Returner = c.Remove(i, 1);
            return Returner;
        }
        public void task14(int c)
        {
            int Fahren = c * 9 / 5 + 32;
            int Kelvin = c + 273;
            Console.WriteLine("Fahrenheit: " + Fahren.ToString() + " Kelvin: " + Kelvin.ToString());
        }
        public void task13(int a)
        {
            for (int i = 0; i < 5; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(a.ToString() + a.ToString() + a.ToString());
                }
                else if(i > 0 && i < 4)
                {
                    Console.WriteLine(a.ToString() + " " + a.ToString());
                }
                else
                {
                    Console.WriteLine(a.ToString() + a.ToString() + a.ToString());
                }
            }
        }
        public void task12(int a)
        {
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");

            Console.WriteLine("");

            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
            Console.Write(a);

            Console.WriteLine("");

            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);
        }
        public string task11(int a)
        {
            return "you look older than " + a.ToString();
        }
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