using System;

namespace MathQuizz
{
    class Program
    {   
        static string getComment()
        {
            return "bien";
        }
        static  bool AskQuestion(int min, int max)
        {
           
            int a = 0;
            int b = 0;

            while (true)
            {
                Random rnd = new Random();

                a = rnd.Next(min, max);
                b = rnd.Next(min, max);

                int trueAnswer = a + b;
                Console.WriteLine(a + " + " + b + " =");
                string userAnswer = Console.ReadLine();

                try
                {
                    int intUserAnswer = int.Parse(userAnswer);
                    if (intUserAnswer == trueAnswer)
                    {
                   
                        return true;
                       
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("erreur : vous devez entrer un nombre");
                }
            }
            
        }

        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            const int nbQuestion = 3;

            int points = 0;
            bool userAnswer = false;

            for (var i =1; i <= nbQuestion; i++)
            {
                Console.WriteLine("Question " + i + "/" + nbQuestion);
                userAnswer = AskQuestion(min, max);

                if (userAnswer)
                {
                    Console.WriteLine("Bonne réponse!");
                    points += 1;
                    

                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
            }

            Console.WriteLine("Nombre de points : " + points +"/" + nbQuestion);
            
        }
    }
}
