//Task1

//string verilen = "qara";
//for ( int i = verilen.Length - 1; i >= 0; i--)
//{
//    Console.Write(verilen[i]);
//}

//Task2

//int num = 6;
//int sum = 0;
//for (int i = 1; i < num; i++)
//{
//    if (num%i==0)
//    {
//        sum+= i;
//    }
//}
//if (sum == num)
//{
//    Console.WriteLine(sum + " ededi Perfect numberdir");
//}
//else
//{
//    Console.WriteLine("Eded Perfect number deyil");
//}

//Task3

//char[] sait = { 'A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o' };
//string[] arr = { "Araz", "Arzu", "Akif" };
//int digit;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//    int num = int.Parse(Console.ReadLine());
//    digit = 0;
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        for (int k = 0; k < sait.Length; k++)
//        {
//            if (arr[i][j] == sait[k])
//            {
//                digit++;
//            }
//        }
//    }
//    if (digit == num)
//    {
//        Console.WriteLine("Duzdur");
//    }
//    else
//    {
//        Console.WriteLine("Yanlisdir");
//    }
//}

//TAsk4

//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = { 5, 6, 7, 8 };
//int[] sumArr = new int[arr1.Length + arr2.Length];

//for (int i = 0; i < sumArr.Length; i++)
//{
//    if (i < arr1.Length)
//    {
//        sumArr[i] = arr1[i];
//        Console.Write(arr1[i] + " ");
//    }
//    else
//    {
//        sumArr [i] = arr2[i-arr1.Length];
//        Console.Write(arr2[i - arr1.Length] + " ");
//    }
//}

//Task5

//int[] arr = { 1, 2, 3, 0 };
//int digit = 0;
//for (int i = 0; i < arr.Length-1; i++)
//{
//    if (arr[i] > arr[i+1])
//    {
//        digit++;
//    }
//}
//if  (digit > 0)
//{
//    Console.WriteLine("Sirali array deyil!");
//}
//else
//{
//    Console.WriteLine("Sirali arraydir");
//}