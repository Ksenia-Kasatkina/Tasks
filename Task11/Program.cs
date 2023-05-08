// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число отрезка 100 - 999 -> {number}");

int DeleteCenter (int num)

{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}

Console.WriteLine($"Двузначное число {DeleteCenter(number)}");
