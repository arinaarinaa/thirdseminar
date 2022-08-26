// Напишите программу, которая принимает на вход пятизначное число 
// проверяет, является ли оно палиндромом.
//14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Пятизначное число - ");
int x = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(x);

void Proverka(string number)
{
    if(number[0] == number[4] && number[1] == number[3])
    Console.WriteLine("Палиндром");

    else 
    {
        Console.WriteLine("не");
    }
}
Proverka(number);
