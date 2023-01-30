# Знакомство с языком программирования С# / Домашнее задание

## Задача 2. 
### Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 |
a = 2 b = 10 -> max = 10 |
a = -9 b = -3 -> max = -3

[Блок-схема](./Task_2/diagram.drawio.png) | [КОД](./Task_2/Program.cs)

## Задача 4. 
### Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7 | 44, 5, 78 -> 78 | 22, 3, 9 -> 22

[Блок-схема](./Task_4/diagram.drawio.png) | [КОД](./Task_4/Program.cs)

## Задача 6.
### Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да | -3 -> нет | 7 -> нет

[Блок-схема](./Task_6/diagram.drawio.png) | [КОД](./Task_6/Program.cs)

## Задача 8. 
### Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4 | 8 -> 2, 4, 6, 8

[Блок-схема](./Task_8/diagram.drawio.png) | [КОД](./Task_8/Program.cs)

## Задача 10.
### Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5 | 782 -> 8 | 918 -> 1

[Блок-схема](./Task_10/diagram.drawio.png) | [КОД](./Task_10/Program.cs)

## Задача 13.
### Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5 | 78 -> третьей цифры нет | 32679 -> 6

[Блок-схема](./Task_13/diagram.drawio.png) | [КОД](./Task_13/Program.cs)

## Задача 15.
### Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да | 7 -> да | 1 -> нет

[Блок-схема](./Task_15/diagram.drawio.png) | [КОД](./Task_15/Program.cs)

## Задача 19.
### Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет | 12821 -> да | 23432 -> да

[Блок-схема](./Task_19/diagram.drawio.png) | [КОД](./Task_19/Program.cs)

## Задача 21.
### Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84 | A (7,-5, 0); B (1,-1,9) -> 11.53

[Блок-схема](./Task_21/diagrama.drawio.png) | [КОД](./Task_21/Program.cs)

## Задача 23.
### Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27 | 5 -> 1, 8, 27, 64, 125

[блок-схема](./Task_23/diagram.drawio.png) | [КОД](./Task_23/Program.cs)

## Задача 27.
### Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11 | 82 -> 10 | 9012 -> 12

[блок-схема](./Task_27/diagram.drawio.png) | [КОД](./Task_27/Program.cs)

## Задача 30 (она же 777).
### Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
Самое левое число != 0. Данный массив есть двоичное представление десятичного числа [1,0,1,1,0,1,0,0].
Реализовать перевод двоичного числа в десятичное.

[блок-схема](./Task_30_(777)/diagram.drawio.png) | [КОД](./Task_30_(777)/Program.cs)

## Задача 37.
### Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[блок-схема](./Task_37/diagram.drawio.png) | [КОД](./Task_37/Program.cs)

## Задача 41.
### Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2 | 1, -7, 567, 89, 223-> 4

[блок-схема](./Task_41/diagram.drawio.png) | [КОД](./Task_41/Program.cs)

## Задача 43.
### Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

[блок-схема](./Task_43/diagram.drawio.png) | [КОД](./Task_43/Program.cs)

## Задача 47. 
### Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

[блок-схема](./Task_47/diagram.drawio.png) | [КОД](./Task_47/Program.cs)

## Задача 50. 
### Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

[блок-схема](./Task_50/diagram.drawio.png) | [КОД](./Task_50/Program.cs)

## Задача 52. 
### Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

[блок-схема](./Task_52/diagram.drawio.png) | [КОД](./Task_52/Program.cs)