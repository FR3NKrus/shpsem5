//   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
   
    int [] CreatArray(int size){
      int [] array = new int [size];
      for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
      }
      return array;
    }
   
    int [] ShowArray(int [] array){
      Console.WriteLine($"Ваш массив:");
      for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
      }
      return array;
    }
   
    void EvenNum(int [] array){
      int count = 0;
      for (int i = 0; i < array.Length; i++){
        if (array[i] %2 == 0) count += 1;
      }
      Console.WriteLine("");
      Console.WriteLine ($"Количество чётных чисел в массиве: {count}");
    }

    Console.WriteLine ("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] newarray = ShowArray(CreatArray(size));
    EvenNum(newarray);
 

    // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
    // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
   
    // int [] CreatArray(){
    //   int [] array = new int [123];
    //   for (int i = 0; i < array.Length; i++){
    //     array[i] = new Random().Next(0, 200);
    //   }
    //   return array;
    // }
   
    // int [] ShowArray(int [] array){
    //   Console.WriteLine($"Ваш массив:");
    //   for (int i = 0; i < array.Length; i++){
    //     Console.Write($"{array[i]}, ");
    //   }
    //   return array;
    // }

    // int NumOver(int [] array){
    //   int count = 0;
    //     for (int i = 0; i < array.Length; i++){
    //       if (array[i] > 9 && array[i] < 100) count += 1;
    //   }
    //   return count;
    // }

    // int [] newarray = ShowArray(CreatArray());
    // int count = NumOver(newarray);
    // Console.WriteLine("");
    // Console.Write($"Количество чисел в диапозоне от 10 до 99: {count} ");
   
   
    // [5, 18, 123, 6, 2] -> 1
    // [1, 2, 3, 6, 2] -> 0
    // [10, 11, 12, 13, 14] -> 5


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    // int [] CreatArray(int size, int min, int max){
    //   int [] array = new int [size];
    //   for (int i = 0; i < array.Length; i++){
    //     array[i] = new Random().Next(min, max);
    //   }
    //   return array;
    // }
   
    // int [] ShowArray(int [] array){
    //   Console.WriteLine($"Ваш массив:");
    //   for (int i = 0; i < array.Length; i++){
    //     Console.Write($"{array[i]} ");
    //   }
    //   return array;
    // }

    // int NumOver(int [] array){
    //   int summ = 0;
    //     for (int i = 1; i < array.Length; i+=2) summ += array[i];
    //   return summ;
    // }

    // Console.WriteLine ("Введите размер массива: ");
    // int size = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите минимальное число: ");
    // int min = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите максимальное число: ");
    // int max = Convert.ToInt32(Console.ReadLine());

    // int [] newArray = ShowArray(CreatArray(size, min, max));
    // int summ = NumOver(newArray);
    // Console.WriteLine("");
    // Console.WriteLine($"Сумма чисел на нечетных индексах: {summ}");

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//     Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    //   double [] CreatArray(int size, int min, int max){
    //   double [] array = new double [size];
    //   for (int i = 0; i < array.Length; i++){
    //     array[i] = Convert.ToDouble(new Random().Next(min*100, max*100)/100.0);
    //   }
    //   return array;
    // }
   
    // double [] ShowArray(double [] array){
    //   Console.WriteLine($"Ваш массив:");
    //   for (int i = 0; i < array.Length; i++){
    //     Console.Write($"{array[i]} ");
    //   }
    //   return array;
    // }

    // double MaxArray(double [] array){
    //   double [] count = new double [array.Length];
    //   double max = array[0];
    //     for (int i = 0; i < array.Length; i++){
    //       if (array[i] > max) max = array[i];
    //   }
    //   return max;
    // }

    // double MinArray(double [] array){
    //   double min = array[0];
    //     for (int i = 0; i < array.Length; i++){
    //       if (array[i] < min) min = array[i];
    //   }
    //   return min;
    // }


    // Console.WriteLine ("Введите размер массива: ");
    // int size = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите минимальное число: ");
    // int min = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите максимальное число: ");
    // int max = Convert.ToInt32(Console.ReadLine());

    // double [] newArray = ShowArray(CreatArray(size, min, max));
    // Console.WriteLine("");
    // double minArray = MinArray(newArray);
    // double maxArray = MaxArray(newArray);
    // double razn = Math.Round(maxArray - minArray, 2);
    // Console.WriteLine ($"Разница между максимальным и минимальным числом: {razn}");

// [3 7 22 2 78] -> 76

//     Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

    // int [] CreatArray(int size, int min, int max){
    //   int [] array = new int [size];
    //   for (int i = 0; i < array.Length; i++){
    //     array[i] = new Random().Next(min, max);
    //   }
    //   return array;
    // }
   
    // int [] ShowArray(int [] array){
    //   Console.WriteLine($"Ваш массив:");
    //   for (int i = 0; i < array.Length; i++){
    //     Console.Write($"{array[i]} ");
    //   }
    //   return array;
    // }

    // void ArraySumm(int [] array){
    //   Console.WriteLine("");
    //   int [] arsm = new int [array.Length];
    //   for (int i = 0; i < array.Length; i++){
    //     if (i < array.Length /2){
    //     arsm[i] = array[i] + array[array.Length -(i+1)];
    //     Console.Write($"{arsm[i]} ");
    //     }
    //     else  {
    //       arsm[i] = array[i];
    //       Console.WriteLine($"{arsm[i]}");
    //       break;
    //     }
    //   }  
    // }
   

    // Console.WriteLine ("Введите размер массива: ");
    // int size = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите минимальное число: ");
    // int min = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine ("Введите максимальное число: ");
    // int max = Convert.ToInt32(Console.ReadLine());

    // int [] newArray = ShowArray(CreatArray(size, min, max));
    // ArraySumm(newArray);
   
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21