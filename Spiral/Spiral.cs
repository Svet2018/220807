// Выведите таблицу размером n×n, заполненную числами от 1 до n^2 
//по спирали, выходящей из левого верхнего угла и 
//закрученной по часовой стрелке, как показано в примере (здесь n=5):

// 1  2  3  4  5
// 16 17 18 19 6
// 15 24 25 20 7
// 14 23 22 21 8
// 13 12 11 10 9

int GetMyNum()
{
    System.Console.WriteLine("Введите число:");
    int getNumder = Convert.ToInt32(Console.ReadLine());
    return getNumder;
}

int Exponentiate(int number)
{
    int num = 1;
    for (int i = 0; i < number ; i++)
    {
        num = number * number;
    }
    System.Console.WriteLine(num);
    return num;   
}

int [,] GenerateArray(int arg)
{
    int [,] array = new int [arg, arg];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            System.Console.WriteLine($"{array[i,j]} ");
        }
        System.Console.WriteLine(s);
    }
    return array;
}

int a = Exponentiate(GetMyNum());
int [,] aa = GenerateArray(a);
System.Console.WriteLine(a);
System.Console.WriteLine(aa);
//GenerateArray(GetMyNum());
