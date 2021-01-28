
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace Variable_og_Datatyper
{



    class Program
    {
        static void Main(string[] args)
        {
            Guessanumb();
        }
        //Opgave 1
        static int NumbersAdd(int a, int b)
        {
            return a + b;
        }
        static double NumbersDivide(double a, double b)
        {
            return a / b;
        }
        static int NumbersModulus(int a, int b)
        {
            return a % b;
        }
        static double NumbersPotens(double a, double b)
        {
            return Math.Pow(a, b);
        }
        //opgave 2
        static string NumbersPythagoras(int a, int b)
        {
            string temp = "";
            if (a > b)
            {
                temp += "A er større end b";
            }
            else
            {
                temp += "B er større end a";
            }
            return temp + (a * a + b * b);
        }
        //opgave 3
        static string AgeandName(string name, int age)
        {
            string temp = "";
            if (age < 3)
            {
                temp += $"{name} du må gå med ble";
            }
            else if (age >= 3 && age < 15)
            {
                temp += $"{name} du må ingenting";
            }
            else if (age > 14 && age < 19)
            {
                temp += $"{name} du må drikke";
            }
            else if (age > 18)
            {
                temp += $"{name} du må stemme og køre bil";
            }
            return temp;
        }
        //opgave 4
        static string Loops()
        {
            string temp = "";
            for (int i = 1; i < 11; i++)
            {
                temp += i;
            }
            return temp;
        }
        //opgave 5
        static string Loopsdesc()
        {
            string temp = "";
            for (int i = 10; i > 0; i--)
            {
                temp += i;
            }
            return temp;
        }
        //opgave 6
        static string NumbLoop(int a)
        {
            string temp = "";
            for (int i = 0; i < 32; i++)
            {
                a += 1;
                temp += a + "\n";
            }
            for (int i = 0; i < 16; i++)
            {
                a -= 1;
                temp += a + "\n";
            }
            return temp;
        }
        //opgave 7
        static string ArrayJob()
        {
            string temp = "";
            int[] array = new int[10];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i;
                temp += array[i];
            }
            string temp2 = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[5] = array[5] * 2;
                temp2 += array[5];
            }
            return temp + temp2;
        }
        //opgave 8
        static string ListJob()
        {
            string temp = "";
            List<int> listnumb = new List<int>();
            List<int> listnumb2 = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                listnumb.Add(i);
                temp += listnumb[i];
            }
            string temp2 = "";
            for (int i = 0; i < listnumb.Count; i++)
            {
                if (listnumb[i] % 3 == 0)
                {
                    listnumb.RemoveAt(i);
                    listnumb[2] = 17;
                    temp2 += listnumb[i];
                }
            }
            listnumb.Reverse();
            listnumb2 = listnumb;
            string temp3 = "";
            foreach (int item in listnumb2)
            {
                temp3 += item;
            }
            return $"{temp} \n  {temp2} \n {temp3}";
        }
        //opgave 9
        static int[] winningnumbers = new int[7];
        static int[] playercoupon = new int[7] { 1, 5, 2, 7, 9, 15, 14 };
        static int numberscorrect = 0;
        static Random rand = new Random();
        static string Ticketgenerator()
        {
            string temp = "";
            for (int i = 0; i < winningnumbers.Length; i++)
            {
                winningnumbers[i] = rand.Next(1, 20);
                temp += winningnumbers[i];
            }
            for (int i = 0; i < winningnumbers.Length; i++)
            {
                foreach (int item in playercoupon)
                {
                    if (winningnumbers[i] == item)
                    {
                        numberscorrect++;
                    }
                }
            }
            return temp;
        }
        static string Winningconditions()
        {

            switch (numberscorrect)
            {
                case 0:
                    return "Desværre makker, du vandt ingenting";

                case 1:
                    return "ya boi, du vandt en 1kr";

                case 2:
                    return "du vandt 10kr";

                case 3:
                    return "du vandt 50k";

                case 4:
                    return "Du vandt 150kr";

                case 5:
                    return "Du vandt 300kr";

                case 6:
                    return "Du vandt en million";
                default:
                    return null;

            }

        }
        //opgave 10
        static void Guessanumb()
        {
            int number = rand.Next(1, 20);
           
            int count = 0;

            while (true)
            {
                int userinput = int.Parse(Console.ReadLine());
                if (userinput > number)
                {
                    Console.WriteLine("Gæt lavere");
                    count++;
                    Console.WriteLine($"Du har brugt {count} forsøg");
                }
                else if (userinput < number)
                {
                    Console.WriteLine("Gæt højere");
                    count++;
                    Console.WriteLine($"Du har brugt {count} forsøg");
                }
                else if (userinput == number)
                {
                    Console.WriteLine("Godt Gættet");
                    count++;
                    Console.WriteLine($"Du brugte {count} forsøg");
                    break;
                }
            }
        }
        //opgave 11
        static int NSumOfNumbers(int a , int b)
        {
            return a + b;
        }
        static int Dividenumbersparameters(int tal1, int tal2)
        {
            return tal1 / tal2;
        }
        static int Modulusparameters(int tal1, int tal2)
        {
            return tal2 % tal1;
        }
        static int ListSum(List<int> list)
        {
            int highestnumber = list.Max();
            return highestnumber;
        }
        static bool CheckX(List<int> list)
        {
            if (list == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            static string AverageList(List<int> list)
            {
                int result = list.Sum();
                double average = result / list.Count;
                return $"{average}";
            }
        }





    }
}

