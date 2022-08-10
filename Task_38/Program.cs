//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int GetNum()
{
    System.Console.WriteLine("Введите длину массива:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}


double GenerateOfRealNumbers()
{
    int num = new Random().Next(-1000, 1001);
    double number = Convert.ToDouble(num / 10.0);
    return number;
}


double [] ArrayOfRealNumbers(int getNum)
{
    double [] array = new double [getNum];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = GenerateOfRealNumbers();
        index++;
    }
    return array;   
}


void MinMax(double [] argArray)
{
    int length = argArray.Length;
    double max = 0.0;
    double min = 0.0;
    System.Console.WriteLine("Сгенерированный массив вещественных чисел:");
    for (int i = 0; i < length; i++)
    { 
        System.Console.Write(argArray[i] + " ");
        if (max < argArray[i]) max = argArray[i];
        if (min > argArray[i]) min = argArray[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Максимальный элемент массива = {max}");
    System.Console.WriteLine($"Минимальный элемент массива = {min}");
    System.Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {max - min}");
}


MinMax(ArrayOfRealNumbers(GetNum()));


