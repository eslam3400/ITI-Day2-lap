using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu(){
            Console.WriteLine();
            Console.WriteLine("Please Choose One Of The Following Options :D");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Character To ASCII Code");
            Console.WriteLine("2- ASCII code To Character");
            Console.WriteLine("3- Even Or Odd");
            Console.WriteLine("4- Math OP On Two Given Numbers");
            Console.WriteLine("5- Calculate The Grade By Degree");
            Console.WriteLine("6- Multiplication Table");
            Console.WriteLine("7- Avarage Degree Of Subjects");
            Console.WriteLine("0- To Exit App");
            Console.WriteLine();
            selection();
        }

        public static void selection(){
            System.Console.Write("Enter Your Selection: ");
            string selected = Console.ReadLine();
            switch (selected[0])
            {
                case '0':
                    Environment.Exit(0);
                    break;
                case '1':
                    System.Console.WriteLine();
                    char_to_ascii();
                    stay_or_leave();
                    break;
                case '2':
                    System.Console.WriteLine();
                    ascii_to_char();
                    stay_or_leave();
                    break;
                case '3':
                    System.Console.WriteLine();
                    odd_or_even();
                    stay_or_leave();
                    break;
                case '4':
                    System.Console.WriteLine();
                    math_op();
                    stay_or_leave();
                    break;
                case '5':
                    System.Console.WriteLine();
                    grade_calc();
                    stay_or_leave();
                    break;
                case '6':
                    System.Console.WriteLine();
                    multiplication_table();
                    stay_or_leave();
                    break;
                case '7':
                    System.Console.WriteLine();
                    avg_subjects_degree();
                    stay_or_leave();
                    break;
                default:
                    Console.WriteLine("I Think You Made Invalid Inpute Please Try Again Later");
                    menu();
                    break;
            }
        }

        public static void stay_or_leave(){
            System.Console.WriteLine();
            System.Console.WriteLine("If You Wanna Return To The Main Menu Type 1 And Type 0 If You Wanna Exit");
            string selected = Console.ReadLine();
            switch (selected[0])
            {
                case '0':
                    Environment.Exit(0);
                    break;
                case '1':
                    menu();
                    break;
                default:
                    System.Console.WriteLine("Please Make Sure That You Type One Of The Two Given Options");
                    stay_or_leave();
                    break;
            }
        }

        public static void char_to_ascii(){
            Console.Write("Enter The Character You Wanna Get The ASCII Code Of: ");
            string code = Console.ReadLine();
            System.Console.WriteLine("The ASCII Code Is: "+Convert.ToInt32(code[0]));
        }

        public static void ascii_to_char(){
            Console.Write("Enter The ASCII Code You Wanna Get The Character Of: ");
            string code = Console.ReadLine();
            System.Console.WriteLine("The ASCII Code Is: "+Convert.ToChar(Convert.ToInt32(code)));
        }

        public static void odd_or_even(){
            System.Console.Write("Enter The Number You Wanna Know If It's Even Or Odd: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2 ==0)
            {
                System.Console.WriteLine("Number "+number+" Is Even");
            }
            else
            {
                System.Console.WriteLine("Number "+number+" Is Odd");
            }
        }

        public static void math_op(){
            System.Console.Write("Enter The First Number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter The Second Number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The Sum Of The Two Numbers Is: "+(first_number+second_number));
            System.Console.WriteLine("The Subtraction Of The Two Numbers Is: "+(first_number-second_number));
            System.Console.WriteLine("The Multiplication Of The Two Numbers Is: "+(first_number*second_number));
        }

        public static void grade_calc(){
            System.Console.Write("Enter The Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 85){
                System.Console.WriteLine("Your Grade Is Exellant");
            }
            else if (grade >= 75){
                System.Console.WriteLine("Your Grade Is Very Good");
            }
            else if (grade >= 65){
                System.Console.WriteLine("Your Grade Is Good");
            }
            else if (grade >= 50){
                System.Console.WriteLine("Your Grade Is Weak");
            }
            else{
                System.Console.WriteLine("Ohh! Sorry You Didn't Pass :'( ");
            }
        }

        public static void multiplication_table(){
            for (int i = 1; i <= 10; i++)
            {
                System.Console.Write(i+":");
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.Write(" "+(i*j));
                }
                System.Console.WriteLine();
            }
        }

        public static void avg_subjects_degree(){
            System.Console.Write("Enter The Number Of Subjects: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] subjects_degrees = new int[number];
            int sum = 0;
            int counter = 1;
            foreach (int degree in subjects_degrees)
            {
                System.Console.Write("Inset The Subject Number "+counter+" Degree: ");
                subjects_degrees[degree] = Convert.ToInt32(Console.ReadLine());
                sum += subjects_degrees[degree];
                counter++;
            }
            System.Console.WriteLine("The Avarage Of Your Subjects Degrees Is: "+((Convert.ToDouble(sum)/Convert.ToDouble(number))));
        }
    }
}