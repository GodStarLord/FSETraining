using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    class Program
    {
        public void PrimeNumbers()
        {
            
            Console.WriteLine("Enter the minimum value");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the maximum value");
            int max = int.Parse(Console.ReadLine());

            int flag;

            while (min < max)
            {
                flag = 0;

                if (min == 1 || min == 0)
                {
                    ++min;
                    continue;
                }
                        
                for (int i = 2; i <= min / 2; i++)
                {
                    if (min % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if(flag==0)
                    Console.Write($"{min}, ");

                min++;
            }
        }

        public void NonRepeatingNumber()
        {
            Console.WriteLine("Enter 11 number");
            int[] nums = new int[11];

            int flag = 0;

            for (int i = 0; i < 11; i++)
                nums[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                flag = 0;
                int j;
                for (j = 0; j < 11; j++)
                    if (i != j && nums[i] == nums[j])
                        break;
                if (j == 11)
                {
                    flag = 1;
                    Console.WriteLine($"Non repeating Number : {nums[i]}");
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Every Number Repeats");
            }
            
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void CardChecker()
        {
            Console.WriteLine("Enter 16 digit card number");
            var cardNumber = Console.ReadLine();

            if(cardNumber.Length < 16)
                Console.WriteLine("Incorrect card number");
            else
            {
                string reverse = Reverse(cardNumber);
                long rev = long.Parse(reverse);
                int tempSum = 0;
                int evenSum = 0, oddSum = 0;
                for (int i = 1; i < 16; i++)
                {
                    if (i % 2 == 0)
                    {
                        tempSum = Convert.ToInt32(reverse[i] - '0') * 2;
                        if (tempSum > 9)
                        {
                            string temp = tempSum.ToString();
                            tempSum = Convert.ToInt32(temp[0] - '0') + Convert.ToInt32(temp[1] -'0');
                        }

                        evenSum += tempSum;
                    }
                    else
                    {
                        tempSum = Convert.ToInt32(reverse[i] - '0');
                        oddSum += tempSum;
                    }
                }

                int total = evenSum + oddSum;

                if(total%10==0)
                    Console.WriteLine("Card is Valid");
                else
                    Console.WriteLine("Invalid Card");
            }
        }

        public void MeanMode()
        {
            int num;
            List<int> arr = new List<int>();
            do
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    arr.Add(num);
                }
                
            } while (num > 0);

            arr.Sort();

            int meanDivby7 = MeanBy7(arr);
            Console.WriteLine($"Mean of the numbers divisible by 7 : {meanDivby7}");

            int mean;

            mean = arr[(arr.Count)/2];

            Console.WriteLine($"Meadian is : {mean}");

            int flag = 0;
            int mode = 0;
            for (int i = 0; i < arr.Count ; i++)
            {
                flag = 0;
                int j;
                for (j = 0; j < arr.Count ; j++)
                    if (i != j && arr[i] == arr[j])
                        break;
                if (j == arr.Count)
                {
                    flag = 1;
                    mode = arr[i];
                    Console.WriteLine($"Mode : {mode}");
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine($"No mode");
            }
        }

        public int MeanBy7(List<int> arr)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] % 7 == 0)
                {
                    count++;
                    sum += arr[i];
                }
                else
                {
                    return 0;
                }
            }

            return (sum / count);
        }
            
        public static bool CardCheck(string cardNumber)
        {

            if (string.IsNullOrEmpty(cardNumber))
            {
                return false;
            }


            int sumOfDigits = cardNumber.Where((e) => e >= '0' && e <= '9')
                .Reverse()
                .Select((e, i) => ((int) e - 48) * (i % 2 == 0 ? 1 : 2))
                .Sum((e) => e / 10 + e % 10);


                        
            return sumOfDigits % 10 == 0;
        }

        public void Card()
        {
            Console.WriteLine("Enter card number");
            string cn = Console.ReadLine();
            if (CardCheck(cn) == true)
                Console.WriteLine("Card Numer is valid");
            else
                Console.WriteLine("Card Numer is not valid");

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Program program = new Program();

            //program.PrimeNumbers();
            //program.NonRepeatingNumber();
            //program.MeanMode();
            //program.Card();

            program.MeanMode();

            Console.ReadLine();
        }
    }
}
