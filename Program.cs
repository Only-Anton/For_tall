int n = 6;
int [] arr = new int [n];
int i = 0;
while (i < n)
{
    arr[i] = new Random().Next(0, 9);
    Console.Write($"{arr[i]},");
    Thread.Sleep(1000);
    i+=1;
}
i = 0;
while (i < n - 1)
{   
    if (arr[i] > arr[i+1])
    {    
        int cheng = arr[i+1];
        arr[i+1] = arr[i];
        arr[i] = cheng;
        int tochka = i*2;
       // if (i == 0) tochka = 0;
        Console.SetCursorPosition(tochka, Console.CursorTop);
        Console.Write($"{arr[i]}");
        Thread.Sleep(1000);
        Console.SetCursorPosition(tochka+2, Console.CursorTop);
        Console.Write($"{arr[i+1]}");
        Thread.Sleep(1000);
        if (i > 0) i-=1;
    }    
    else i+=1;
}

// 012345678910111213141516
// 0 1 2 3 4 5   6   7    8
// Console.Write("Результат: ");
// for (int i = 0; i < 21; i++)
// {
//     Console.SetCursorPosition(12, Console.CursorTop); // Устанавливаем курсор в начало текущей строки
//     Console.Write(i);

//     // Приостанавливаем выполнение программы на 1000 миллисекунд (1 секунда)
//     Thread.Sleep(500);
//     }

// Console.WriteLine("\nГотово!");
  