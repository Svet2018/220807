// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int GetNum()
{
    System.Console.WriteLine("Введите длину массива:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}


int PositiveNumbers()
{
    int posNum = new Random().Next(100, 1000);
    return posNum;
};


int[] GenerateArray(int arg1)
{
  int [] genArray = new int[arg1];
  int length = genArray.Length;
  int index = 0;
  while(index < length)
  {
    genArray[index] = PositiveNumbers();
    index++;
  }
  return genArray;
};


void EvenNumbers(int [] argArray)
{
    int length = argArray.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (argArray[i] % 2 ==0)
        {
            sum = sum + 1;
        }
        System.Console.Write(argArray[i] + ", ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Четных чисел в массиве: {sum}");
}


EvenNumbers(GenerateArray(GetNum()));






