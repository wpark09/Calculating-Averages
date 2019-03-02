using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonil_EX2A
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            //Sum of numbers
            double value;
            List<double> listSum = new List<double>();

            for (int k = 0; k < 10; k++)
            {
                Console.Write($"{k + 1}. Enter a number between 0 and 100: ");
                value = Convert.ToDouble(Console.ReadLine());
                if (value >= 0 && value <= 100)
                {
                    listSum.Add(value);
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    k--; //Repeat iteration if input is invalid
                }
            }

            double sum = listSum.Sum();
            Console.WriteLine($"Sum of ten numbers is: {sum}");

            //Average ten scores

            double score;
            List<double> listAverage = new List<double>();


            for (int j = 0; j< 10; j++)
            {
                Console.Write($"{j + 1}. Enter your score: ");
                score = Convert.ToDouble(Console.ReadLine());
                if (score >= 0 && score <= 100)
                {
                    listAverage.Add(score);
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    j--; //Repeat iteration if input is invalid
                }
            }

            double averageScore;
            averageScore = listAverage.Average();
            char letterAverage = gradeGenerator(averageScore);

            Console.WriteLine($"Your average score is: {averageScore}. Your letter grade is {letterAverage}.");

            

            //Avg a SPECIFIC # of scores

            Console.WriteLine("Enter the number of test scores: ");
            int n = int.Parse(Console.ReadLine());

            double scoreSpecific;
            List<double> listSpecific = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}. Enter score #{i}: ");
                scoreSpecific = Convert.ToDouble(Console.ReadLine());

                if (scoreSpecific >= 0 && (scoreSpecific <= 100))
                {
                    listSpecific.Add(scoreSpecific);
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    i--; //Repeat iteration if input is invalid
                }
            }

                double scoreSpecificNum;
                scoreSpecificNum = listSpecific.Average();

                char letterSpecific = gradeGenerator(scoreSpecificNum);
                Console.WriteLine($"The average score is: {scoreSpecificNum}. {letterSpecific}.");
                

            //Avg a NON-SPECIFIC # of scores

            double scoreNonSpecific;
            List<double> listNonSpecific = new List<double>();

            char answer = 'y';

            while (answer == 'Y' || answer == 'y')
            {
                for (int l = 0; l != -1; l++)
                {
                    Console.WriteLine($"Enter score #{l + 1}");
                    scoreNonSpecific = Convert.ToDouble(Console.ReadLine());

                    if (scoreNonSpecific >= 0 && (scoreNonSpecific <= 100))
                    {
                        listNonSpecific.Add(scoreNonSpecific);

                        double scoreNonSpecificNum;
                        scoreNonSpecificNum = listNonSpecific.Average();
                        char letterNonSpecific = gradeGenerator(scoreNonSpecificNum);
                        Console.WriteLine($"You have entered {l + 1} test scores. The average score is {scoreNonSpecificNum} and letter grade is {letterNonSpecific}.");
                        

                        Console.WriteLine("Do you want to continue? (Y/N)");
                        answer = Convert.ToChar(Console.ReadLine());

                        switch (answer)
                        {
                            case 'y':
                                Console.WriteLine("Enter next score.");
                                break;

                            case 'Y':
                                Console.WriteLine("Enter next score.");
                                break;

                            case 'n':
                                return;
                                break;

                            case 'N':
                                return;
                                break;

                            case 'a':
                                answer = Convert.ToChar(Console.ReadLine());
                                if (answer == 'y' || answer == 'Y')
                                {
                                    goto case 'y';
                                }
                                else if (answer == 'n' || answer == 'N')
                                {
                                    goto case 'n';
                                }
                                else
                                {
                                    goto default;
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid input. Do you want to continue? (Y/N)");
                                goto case 'a';
                                break;
                        }
                    }

                    else if (scoreNonSpecific > 100 || scoreNonSpecific < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid score.");
                        l--;
                    }
                }
            }
        }
        double grade;

        static char gradeGenerator(double grade)
        {
            char letterGrade;

            if (grade >= 90.0)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80.0)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70.0)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60.0)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
    }
}
