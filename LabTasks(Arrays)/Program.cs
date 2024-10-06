//Task1
//int[,] numbers =
//{
//    {4, 5, 9, 12},
//    {1, 2, 15, 7},
//    {11, 6, 8, 10},
//    {3 , 13, 0, 17}
//};
//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//Task2
//int sum = 0;
//int[,] numbers =
//{
//    {4, 5, 9, 12},
//    {1, 2, 15, 7},
//    {11, 6, 8, 10},
//    {3 , 13, 0, 17}
//};
//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum = sum + numbers[i, j];
//        }
//    }
//}
//Console.WriteLine(sum);

//Task3
//int sum = 0;
//int[,] numbers =
//{
//    {4, 5, 9, 12},
//    {1, 2, 15, 7},
//    {11, 6, 8, 10},
//    {3 , 13, 0, 17}
//};
//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i < j)
//        {
//            sum = sum + numbers[i, j];
//        }
//    }
//}
//Console.WriteLine(sum);



//Task4
//int sum1 = 0 , sum2 = 0;
//int[,] numbers =
//{
//    {4, 5, 9, 12},
//    {1, 2, 15, 7},
//    {11, 6, 8, 10},
//    {3 , 13, 0, 17}
//};
//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        if (i < j)
//        {
//            sum1 = sum1 + numbers[i, j];
//        }
//        else if (i > j)
//        {
//            sum2 = sum2 + numbers[i, j];
//        }
//    }
//}
//if (sum1 > sum2)
//{
//    Console.WriteLine(sum1 - sum2);
//}
//else
//{
//    Console.WriteLine(sum1 - sum2);
//}