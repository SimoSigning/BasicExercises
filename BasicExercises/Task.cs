using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class Task
    {
        public void task62(string a)
        { //En dag når jeg får tid skal jeg prøve at lave en mere elegant og mindre rodet løsning. Men det her giver forventet output til de foreslåede input..
            string Newa = "";
            string FirstStr = "";
            string LastStr = "";
            int FirstParenthesisIndex = 0;
            int LastParenthesisindex = 0;
            int FirstIndexToFirstParenthesis = 0;
            int LastIndexToLastParenthesis = 0;
            int ParenthesisCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == '(' || a[i] == ')')
                {
                    ParenthesisCounter++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    FirstIndexToFirstParenthesis++;
                    FirstParenthesisIndex = i;
                    break;
                }
                else
                {
                    FirstIndexToFirstParenthesis++;
                }
            }
            for (int i = a.Length - 1; i > 0; i--)
            {
                if (a[i] == ')')
                {
                    LastIndexToLastParenthesis++;
                    LastParenthesisindex = i;
                    break;
                }
                else
                {
                    LastIndexToLastParenthesis++;
                }
            }
            for (int i = FirstParenthesisIndex + 1; i < a.Length; i++)
            {
                if (a[i] == '(' || a[i] == ')')
                {
                    break;
                }
                else
                {
                    FirstStr += a[i];
                }
            }
            for (int i = LastParenthesisindex - 1; i > 0; i--)
            {
                if (a[i] == '(' || a[i] == ')')
                {
                    break;
                }
                else
                {
                    LastStr += a[i];
                }
            }
            char[] FirstStrChar = FirstStr.ToCharArray();
            for (int i = 0; i < FirstStrChar.Length; i++)
            {
                FirstStrChar[i] = FirstStrChar[FirstStrChar.Length - 1 - i];
            }
            FirstStrChar[FirstStrChar.Length - 1] = FirstStr[0];
            FirstStr = "";
            for (int i = 0; i < FirstStrChar.Length; i++)
            {
                FirstStr += FirstStrChar[i];
            }
            int hmm;
            string hmm01;
            string hmm02;
            string hmm03;
            if(ParenthesisCounter > 2)
            {
                hmm = a.Length - FirstStr.Length - LastStr.Length - FirstIndexToFirstParenthesis - LastIndexToLastParenthesis;
                hmm01 = a.Substring(0, FirstIndexToFirstParenthesis);
                hmm02 = a.Substring(FirstIndexToFirstParenthesis + FirstStr.Length, hmm);
                hmm03 = a.Substring(FirstIndexToFirstParenthesis + FirstStr.Length + hmm + LastStr.Length, LastIndexToLastParenthesis);
                Newa =
                    hmm01 +
                    LastStr +
                    hmm02 +
                    FirstStr +
                    hmm03;
            }
            else
            {
                hmm = a.Length - FirstIndexToFirstParenthesis - LastIndexToLastParenthesis;
                hmm01 = a.Substring(0, FirstIndexToFirstParenthesis);
                hmm02 = a.Substring(FirstIndexToFirstParenthesis + FirstStr.Length, hmm+1);
                Newa =
                    hmm01 +
                    LastStr +
                    hmm02;
            }
            for (int i = 0; i < Newa.Length; i++)
            {
                if(Newa[i] == '(' || Newa[i] == ')')
                {
                    Newa = Newa.Remove(i, 1);
                }
            }
            Console.WriteLine(Newa);
        }

        /*
        public void task61(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if(a[i] != -5 && a[j] != -5 && a[j] < a[i])
                    {
                        int Temp = a[i];
                        a[i] = a[j];
                        a[j] = Temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public int task60(int[][] a)
        {
            int Summer = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if(a[i][j] == 0)
                    {
                        a[i + 1][j] = 0;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Summer += a[i][j];
                }
            }
            return Summer;
                              
                     new int[][] {
                    new int[]{1, 0, 3, 2},
                    new int[]{0, 6, 0, 1},
                    new int[]{4, 0, 3, 0}
                    
        }
        
        public bool task59(int[] a)
        {
            bool IsItPossible = true;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        IsItPossible = false;
                        break;
                    }
                }
            }
            return IsItPossible;
        }
        public int task58(int[] a)
        {
            int Min = a[0];
            int Max = a[0];
            int Counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > Max)
                {
                    Max = a[i];
                }

                if(a[i] < Min)
                {
                    Min = a[i];
                }
            }
            for (int i = Min; i <= Max; i++)
            {
                Counter++;
            }
            int Missing = Counter - a.Length;
            return Missing;
        }
        public int task57(int[] a)
        {
            int Max = a[0] * a[1];
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] * a[i + 1] > Max)
                {
                    Max = a[i] * a[i + 1];
                }
            }
            return Max;
        }
        public bool task56(string a)
        {
            bool returner = true;
            for (int i = 0;  i<a.Length; i++)
            {
                if(a[i] != a[a.Length-1-i])
                {
                    returner = false;
                    break;
                }
            }
            return returner;
        }
        public bool task55(int[] a, int b)
        {
            int Max = a[0] * a[1];
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i]*a[i+1] > Max)
                {
                    Max = a[i] * a[i + 1];
                }
            }
            if(Max == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double task54(double a)
        {
                return Math.Ceiling(a/ 100);
        }
        public bool task53(int[] a)
        {
            bool Returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 != 0)
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
        }
        public void task52(int[] a, int[] b, int[] c)
        {
            int[][] ArrArr = { a, b, c };
            int[] NewArr = new int[3];
            for (int i = 0; i < NewArr.Length; i++)
            {
                NewArr[i] = ArrArr[i][(ArrArr[i].Length-1)/ 2];
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.WriteLine(NewArr[i]);
            }
        }
        public int task51(int[] a)
        {
            int Max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > Max)
                {
                    Max = a[i];
                }
            }
            return Max;
        }
        public void task50(int[] a)
        {
            int first = a[0];
            for (int i = 0; i < a.Length-1; i++)
            {
                a[i] = a[i + 1];
            }
            a[a.Length - 1] = first;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            } 
        }
        public bool task49(int[] a, int[] b)
        {
            if(a[0] == b[0] || a[a.Length-1] == b[b.Length-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task48(int[] a)
        {
            if(a[0] == a[a.Length-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int task47(int[] a)
        {
            int Returner = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Returner += a[i];
            }
            return Returner;
        }
        public bool task46(int[] a, int b)
        {
            if(a[0] == b || a[a.Length-1] == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int task45(int[] a, int b)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == b)
                {
                    counter++;
                }
            }
            return counter;
        }
        public string task44(string a)
        {
            string NewString = "";
            for (int i = 0; i < a.Length; i+=2)
            {
                    NewString += a[i];
            }
            return NewString;
        }
        public bool task43(string a)
        {
            if(a.Length >= 5)
            {
                if(a.Substring(0,5) == "wwwww" || a.Substring(0, 5) == "WWWWW")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string task42(string a)
        {
            if(a.Length >= 4)
            {
                string FirstFour = a.Substring(0, 4);
                string Rest = a.Substring(4, a.Length - 4);
                return FirstFour.ToLower() + Rest;
            }
            else
            {
                return a.ToUpper();
            }
        }
        public bool task41(string a)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 'w' || a[i] == 'W')
                {
                    counter++;
                }
            }
            if(counter >= 1 && counter <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int task40(int a, int b)
        {
            if(a == b)
            {
                return 0;
            }
            else
            {
                if (Math.Abs(20 - a) < Math.Abs(20 - b))
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
        }
        public string task39(int a, int b, int c)
        {
            List<int> IntegerList = new List<int>() { a, b, c };
            int Max = IntegerList[0];
            int Min = IntegerList[0];
            for (int i = 0; i < IntegerList.Count; i++)
            {
                if(IntegerList[i] > Max)
                {
                    Max = IntegerList[i];
                }

                if(IntegerList[i] < Min)
                {
                    Min = IntegerList[i];
                }
            }
            return "Min: " + Min.ToString() + " Max: " + Max.ToString();
        }
        public string task38(string a)
        {
            if(a.Substring(0,2) == "PH")
            {
                return "PH";
            }
            else
            {
                return a;
            }
        }
        public string task37(string a)
        {
            string Returner = string.Empty;
            if(a.Substring(1,2) == "HP")
            {
                Returner = a.Remove(1, 2);
            }
            else
            {
                return a;
            }
            return Returner;
        }
        public bool task36(int a, int b)
        {
            if(a >= -10 && a <= 10 || b >= -10 && b <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task35(int a, int b)
        {
            if(a < 100 && b > 200 || b < 100 && a > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task34(string a, string w)
        {
            if (a.Substring(0, w.Length) == w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task33(int a)
        {
            if(a % 3 == 0 || a % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string task32(string a)
        {
            string NewString = a.Substring(a.Length - 4, 4);
            return NewString + NewString + NewString + NewString;
        }
        public void task31(int[] a, int[] b)
        {
            int[] newArr = new int[a.Length];
            if(a.Length == b.Length)
            {
                
                for (int i = 0; i < a.Length; i++)
                {
                    newArr[i] = a[i] * b[i];
                }
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
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
        {
            int PrimeCounter = 0;
            int PrimeSum = 2;
            int PotentialPrime = 3;
            bool IsPrime;
            while(PrimeCounter < 499) // Den skal starte fra én mindre end 500 for at give forventet resultat.
            {
                IsPrime = true;
                for (int i = 2; i < PotentialPrime; i++)
                {
                    if(PotentialPrime % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if(IsPrime == false)
                {
                   PotentialPrime++;
                }
                else
                {
                    PrimeSum += PotentialPrime;
                    PotentialPrime++;
                    PrimeCounter++;
                }
            }
            return PrimeSum;
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
            int SpaceCounter = 0;
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
            return "The longest word in the string is: " + wordString[MaxLengthIndex];
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
        }*/
    }
}