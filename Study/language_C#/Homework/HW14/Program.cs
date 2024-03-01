﻿using System;
//Задача 3: Реверсирование одномерного массива
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 6, 7, 8, 9}; // Исходный массив
        int temp;
        // Вывод исходного массива
        Console.Write("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        // Реверсирование массива
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            // Меняем местами элементы
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        // Вывод измененного массива
        Console.Write("\n Перевернутый массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}