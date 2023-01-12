// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)

// 2. Создание массива
// int[] <- (int)

// 3. Заполнение массива 0 и 1
// void <- (int[])

// 4. Печать массива
// string <- (int[])

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 6. 10110100 >> 180


int GetNumberByUser(string N)   // 1. Ввод N
{
    Console.Write(N + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)  // 2. Создание массива
{
    return new int[size];
}


void GetBin(int[] colNumber)   // 3. Заполнение массива 0 и 1
{ 
    
    int count = colNumber.Length;
    for (int i = 0; i < count; i++)

    { 
        colNumber[i] = Random.Shared.Next(2);
    }
    colNumber[0] = 1;
}

string Print(int[] numbers)   // 4. Печать массива
{
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
        output = output + numbers[i];
    }

    return output;
}


int ConvertBinToDec(string Print)   // 5. Конвертация из 2-ого в 10-ое
{
    int dec = Convert.ToInt32(Print, 2);
    return dec;
}



int countByUser = GetNumberByUser("Введите N: ");
int[] list = CreateArray(countByUser);
GetBin(list);
string result = Print(list);
ConvertBinToDec(result);
int Decimal = ConvertBinToDec(result);
Console.WriteLine(result + $"  >>  {Decimal}");


