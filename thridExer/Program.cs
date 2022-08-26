// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введи тут число - ");
int x = Convert.ToInt32(Console.ReadLine());

void TablCube(int [] x)
{
  int index = 0;
  int llength = x.Length;
  while (index < llength)
  {
    x[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }  
}
void PrCH(int[] massive)
{
  int lenght = massive.Length;
  int index = 0;
  while(index < lenght)
  {
    Console.Write(massive[index]+ " ");
    index++;
  }
} 

int[] secondmassive = new int[x+1];
TablCube(secondmassive);
PrCH(secondmassive);