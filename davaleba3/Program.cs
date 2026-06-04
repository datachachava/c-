namespace davaleba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               დავალება 1:
Login სისტემა: პროგრამაში გვაქვს 
username: admin
password: 1234
მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
 თუ სწორია კონსოლში გამოიტანე:
Welcome!
 თუ არა:
Access denied
*/

            //Console.WriteLine("enter your username");
            //string usernameStr = Console.ReadLine();
            //Console.WriteLine("enter your password");
            //string passwordStr = Console.ReadLine();

            //if (usernameStr == "admin" && passwordStr == "1234")
            //{
            //    Console.WriteLine("You have full accses");
            //}
            //else { 
            //    Console.WriteLine("Access denied"); 
            //    }


            /* Calculator (switch-ით)
მომხმარებელი შეიყვანს:
•	რიცხვი 1
•	ოპერატორი (+ - * /)
•	რიცხვი 2
კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)
 */

            //Console.WriteLine("enter first number");
            //string num1Str = Console.ReadLine();
            //Console.WriteLine("enter an operator");
            //string operatorStr = Console.ReadLine();
            //Console.WriteLine("enter second number");
            //string num2Str = Console.ReadLine();

            //bool isNum1Valid = int.TryParse(num1Str, out int num1);
            //bool isNum2Valid = int.TryParse(num2Str, out int num2);
            //bool isOperatorValid = char.TryParse(operatorStr, out char operatorr);

            //switch (operatorr)
            //{
            //    case '+':
            //        Console.WriteLine(num1 + num2);
            //        break;
            //    case '-':
            //        Console.WriteLine(num1 - num2);
            //        break;
            //    case '*':
            //        Console.WriteLine(num1 * num2);
            //        break;
            //    case '/':

            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}



            /*

            დავალება 3 :
მომხმარებელს შეაყვანინე ასაკი:
            დაადგინე და კონსოლში გამოიტანე:
•	ბავშვი(0–12)
•	თინეიჯერი(13–19)
•	ზრდასრული(20–64)
•	პენსიონერი(65 +)
*/

            //Console.WriteLine("enter age");
            //string ageStr = Console.ReadLine();

            //bool isAgeValid = byte.TryParse(ageStr, out byte age);

            //if (age > 0 && age <= 12)
            //{
            //    Console.WriteLine("you are a kid");
            //} else if (age > 12 && age <= 19)
            //{
            //    Console.WriteLine("you are a teen");
            //} else if (age > 19 && age <= 64)
            //{
            //    Console.WriteLine("you are an adult");
            //} else if (age > 64)
            //{
            //    Console.WriteLine("you are pensioner");
            //}





        }
    }
}