using System;

internal class Programm
{
    static void Main(string[] args)
    {
        //int[] numbers = { 5, -6, 7, 20 };

        ////Console.WriteLine(numbers[0]);
        ////Console.WriteLine(numbers[1]);
        ////Console.WriteLine(numbers[2]);

        ////for (var ; condition ; action )

        //for (int i = 0 ; i < numbers.Length ; i++ )
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        // 1 2 3
        int[] numbers = new int[3];
        Random random = new Random();

        // 1 2 3
        // 4 5 6
        // 7 8 9

        Console.WriteLine($"Test check");

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }


}


//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = (int)random.NextInt64(0, 5);
//}

//// calculate amount if number 4
//int result = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]+" ");
//    if (numbers[i] == 4)
//    {
//        result++;
//    }
//}

//foreach(int number in numbers)
//{
//    if (number == 4)
//    {
//        result++;
//    }
//}

//Console.WriteLine(result);
//  int x = number % 10;
//


//        int expectedSumm = 10;
//        int countOfNumber = 0;

//        for (int i = 100; i < 1000; i++)
//        {
//            int result = 0;
//            int currentNumber = i;
//            Console.WriteLine(currentNumber);

//            while (currentNumber > 0)
//            {
//                result += currentNumber % 10;
//                currentNumber = currentNumber / 10;
//            }

//            if (result == expectedSumm)
//            {
//                countOfNumber++;
//                Console.WriteLine(" - true\n");
//            }
//        }







//        Console.WriteLine(result)



//        //for (int i = 0; i < numbers.Length; i++)
//        //{
//        //    Console.Write(numbers[i] + " ");
//        //}

//        //foreach (int number in numbers)
//        //{
//        //    Console.Write(number);
//        //}



//        //int j = 0;
//        //do
//        //{
//        //    Console.Write(numbers[j] + " ");
//        //    j++;
//        //}
//        //while (j < numbers.Length);



//        //int j = -1;
//        //do
//        //{
//        //    Console.WriteLine("I am DO-WHILE cycle");
//        //}
//        //while (j > 0);

//        //for (int i = -1; i > 0; i++)
//        //{
//        //    Console.WriteLine("I am For cycle");
//        //}


//    }





//    //если сумма меньше 100 - начисл 5проц
//    // если больше 200 - начисл 10 проц
//    // от 100 до 200 - начисл 7 проц
//    // вывод сумму вклада с начислен проц

//    //public static void Task6()
//    //{
//    //    int deposite = int.Parse(Console.ReadLine());
//    //    double result = deposite;

//    //    if ((deposite < 100))
//    //    {
//    //        result += deposite * 0.05;
//    //    }
//    //    else if ((deposite >= 100) && (deposite <= 200))
//    //    {
//    //        result += deposite * 0.07;
//    //    }
//    //    else
//    //    {
//    //        result += deposite * 0.1;
//    //    }


//    //    switch (deposite)
//    //    {
//    //        case < 100:
//    //            result += deposite * 0.05;
//    //            break;

//    //        case >= 100 and <= 200:
//    //            result += deposite * 0.07;
//    //            break;
//    //        default:
//    //            result += deposite * 0.1;
//    //            break;





//    //            Console.WriteLine($"your % plus deposite {result}");
//    //    }
//    //}


//    //    //число кратно 2 и 3 тогда (от самого общего к самого конкретному)
//    //    //если кратно только 2
//    //    //если кратно только 3

//    //public static void Task5()
//    //{
//    //    int number = int.Parse(Console.ReadLine());
//    //    if ((number % 2 == 0) && (number % 3 == 0))
//    //    {
//    //        Console.WriteLine($"Divide on 2 and 3 ");
//    //    }
//    //    else if (number % 2 == 0)
//    //    {
//    //        Console.WriteLine($"Divide on 2");
//    //    }
//    //    else if (number % 3 == 0)
//    //    {
//    //        Console.WriteLine($"Divide on 3");
//    //    }


//    //}

//    ////число или равно 5 или 10
//    //public static void Task4()
//    //{
//    //    int number = int.Parse(Console.ReadLine());

//    //    if ((number == 5) || (number == 10))
//    //    {
//    //        Console.WriteLine($"Number is 5 or 10");
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine($"Undefined number");
//    //    }


//    //}


//    //public static void Task3()
//    //{
//    //    int number = int.Parse(Console.ReadLine());

//    //    if ((number >= 5) && (number <= 10))
//    //    {
//    //        Console.WriteLine($"Number bigger than 5 and less 10");
//    //    }
//    //    else
//    //    {
//    //        Console.WriteLine($"Undefined number");
//    //    }


//    //}

//    //public static void Task2()
//    //{
//    //    int numberOne = 1;
//    //    int numberTwo = 2;

//    //    if(numberOne < numberTwo)
//    //    {
//    //        Console.WriteLine($"First number bigger than second number");
//    //    }else
//    //    {
//    //        Console.WriteLine($"Second number bigger than first number");
//    //    }


//    //}


//    //public static void Task1()
//    //{
//    //    double r = double.Parse(Console.ReadLine());
//    //    double h = Convert.ToDouble(Console.ReadLine());

//    //    double v = Math.PI * Math.Pow(r, 2) * h;
//    //    double s = 2 * Math.PI * r * (r + h);

//    //    Console.WriteLine($"Volume: {v}");
//    //    Console.WriteLine($"Square: {s}");
//    //}




//}

