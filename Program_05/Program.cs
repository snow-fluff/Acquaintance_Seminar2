// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

for (int num = 1; num < 101; num++)
{
    Console.WriteLine();
    if (num % 3 == 0)
    {
        Console.Write("Fizz");
    }
    if (num % 5 == 0)
    {
        Console.Write("Buzz");
    }
    if (num % 3 != 0 & num % 5 != 0)
    {
        Console.Write(num);
    }
}