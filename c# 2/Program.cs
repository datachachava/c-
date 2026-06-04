namespace c__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // davaleba 1

            Console.WriteLine("Enter Your Age");
            string ageStr = Console.ReadLine();

            bool ageIsValid = int.TryParse(ageStr, out int age);

            if (ageIsValid && age >= 18)
            {
                Console.WriteLine("gilocav! xmis uflebis micema gaqvs!");
            }
            else if (ageIsValid && age < 18)
            {
                Console.WriteLine("samwuxarod xmis micemis ufleba jer ar gaqvt");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


            // davaleba 2

            Console.WriteLine("Enter First Number");
            string firstNumStr = Console.ReadLine();
            Console.WriteLine("Enter Second Number");
            string secondNumStr = Console.ReadLine();
            Console.WriteLine("Enter Third Number");
            string thirdNumStr = Console.ReadLine();

            bool firstNumIsValid = int.TryParse(firstNumStr, out int firstNum);
            bool secondNumIsValid = int.TryParse(secondNumStr, out int secondNum);
            bool thirdNumIsValid = int.TryParse(thirdNumStr, out int thirdNum);

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine(firstNum + " is biggest");
            }
            else if (secondNum > thirdNum && secondNum > thirdNum)
            {
                Console.WriteLine(secondNum + " is biggest");

            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.WriteLine(thirdNum + " is biggest");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }



            // davaleba 3


            Console.WriteLine("Enter First Number");
            string firstNumStrr = Console.ReadLine();
            Console.WriteLine("Enter Second Number");
            string secondNumStrr = Console.ReadLine();

            bool firstNumIsValidd = int.TryParse(firstNumStrr, out int firstNumm);
            bool secondNumIsValidd = int.TryParse(secondNumStrr, out int secondNumm);

            if (firstNumm != secondNumm)
            {
                Console.WriteLine(firstNumm + secondNumm);
            }
            else if (firstNumm == secondNumm)
            {
                Console.WriteLine((firstNumm + secondNumm) * 3);
            }
            else
            {
                Console.WriteLine("invalid input");
            }



        }
    }

}
