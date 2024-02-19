int number = 77;

if (number > 10 && number < 99)
{
    int first_number = number / 10;
    int second_number = number % 10;
    if (first_number > second_number){
        Console.WriteLine("Первое число больше");
    } else if (first_number < second_number){
        Console.WriteLine("Второе число больше");
    } else {Console.WriteLine("Числа равны");}
} else 
{
    Console.WriteLine("Введено неподходящее число");
    }