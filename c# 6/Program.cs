namespace c__6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region hw1

            /* 
             1.	შექმენით jagged array სადაც: თითოეულ სტუდენტს 
            აქვს სხვადასხვა რაოდენობის ქულა. იპოვეთ თითოეულის საშუალო ქულა.
             */

            //int[][] points = [[6, 3, 9, 10], [4, 7, 8, 9], [7, 4, 10, 10]];

            //foreach (var item in points)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        sum += item[i];
            //    }
            //    Console.WriteLine(sum / item.Length);
            //}
            #endregion

            #region hw2

            /* 
             2.	შექმენით რენდომული 4 ნიშნა პასკოდების არაი (10 წევრი). 
            მომხმარებელს შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა არაიში დაუბეჭდეთ “Correct” თუ არა და “Wrong”.
             */

            //var randomPasscode = new Random();
            //int[] password = new int[10];
            //for (int i = 0; i < password.Length; i++)
            //{
            //    password[i] = randomPasscode.Next(1000, 9999);


            //}

            //Console.WriteLine("enter passcode");
            //string userPassword = Console.ReadLine();
            //bool isCorrect = false;
            //foreach (var item in password)
            //{
            //    if (item.ToString() == userPassword)
            //    {
            //        isCorrect = true;
            //    }

            //}

            //Console.WriteLine(isCorrect ? "correct" : "wrong");



            #endregion

            #region hw3

            /* 
             3.	შექმენით int-ების (მათ შორის ნეგატიური რიცხვებიც) მასივი.
            იპოვეთ მინიმალური და მაქსიმალური რიცხვები (არ გამოიყენოთ არაის მეთოდები).
             */

            //int[] numbers = [ 5, -3, 8, 1, -7, 10, -1, 9, 7];

            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //        min = numbers[i];
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //}

            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            #endregion

            #region hw4

            /* 4.	შექმენით სტრინგების მასივი და კონსოლში 
             დაბეჭდეთ ყველა ელემენტის ყველა სიმბოლო (არ გამოიყენოთ არაის მეთოდები).*/


            //string[] words = ["word1", "word2", "word3", "word4", "word5", "word6"];

            //foreach (var word in words)
            //{
            //    foreach (var character in word)
            //    {
            //        Console.Write(character);
            //    }
            //    Console.WriteLine();
            // }

            #endregion

            #region hw5

            /* 
             5.	შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი
            თუ შეიცავს @ სიმბოლოს. (არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).
             */

            string[] emails = ["random@gmail.com", "examplegmail.com", "user@domain.org", "test@yahoo.com"];

            foreach (var item in emails)
            {
                foreach (var symbol in item)
                {
                    if (symbol == '@')
                    {
                        Console.WriteLine("welcome");
                    }
                }
            }

            #endregion
        }
    }
}