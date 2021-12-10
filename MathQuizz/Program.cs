using System;

namespace MathQuizz
{
    class Program
    {
        static string getComment(int points, int nbQuestion)
        {
            int moyenne = nbQuestion / 2;

            if (points == nbQuestion)
            {
                return "Excellent ! ";
            }
            else if (points == 0)
            {
                return "Il va falloir réviser un peu vos math ...";
            }
            else if (points == moyenne)
            {
                return "Pas mal";
            }
            else
            {
                if (points > moyenne)
                {
                    return "Très bien!";
                }
                else
                {
                    return "Peut mieux faire ...";
                }
            }
        }
        static bool AskQuestion(int min, int max)
        {

            int a = 0;
            int b = 0;


            Random rnd = new Random();

            a = rnd.Next(min, max);
            b = rnd.Next(min, max);
            //Random operator
            int o = rnd.Next(1, 3);
            string strOperator = "";
            int trueAnswer = 0;

            if (o == 1)
            {
                strOperator = "+";
                trueAnswer = a + b;
            }
            else
            {
                strOperator = "x";
                trueAnswer = a * b;
            }


            int intUserAnswer = 0;
            Console.WriteLine(a + strOperator + b + " =");
            string userAnswer = Console.ReadLine();

            try
            {
                intUserAnswer = int.Parse(userAnswer);


            }
            catch
            {
                Console.WriteLine("erreur : vous devez entrer un nombre");
            }

            if (intUserAnswer == trueAnswer)
            {

                return true;

            }
            else
            {
                return false;
            }


        }

        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            const int nbQuestion = 3;

            int points = 0;
            bool userAnswer = false;

            for (var i = 1; i <= nbQuestion; i++)
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

            Console.WriteLine("Nombre de points : " + points + "/" + nbQuestion);

            Console.WriteLine(getComment(points, nbQuestion));

        }
    }
}
