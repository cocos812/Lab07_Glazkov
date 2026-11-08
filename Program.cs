// Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = 6; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// Задание 1.2
// double[] temps = {14.1, 10.0, 13.9, 9.8, 6.7, 21.0, 26.2};
// foreach (double temp in temps)
// {
//     Console.Write($"{temp} ");
// }

// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int kolvo = 0;
// foreach (int price in prices)
// {
//     sum += price;
//     if (price > 100)
//     {
//         kolvo++;
//     }
// }
// double average = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}, кол-во дороже 100: {kolvo}");


// Задание 3
// int[] prices = { 19, 16, 141, 67, 100, 15 };
// int vin = 0;
// int min = prices[0];
// int maks = prices[0];
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (prices[i] > maks)
//     {
//         vin = i;
//         maks = prices[i];
//     }
// }


// Задание 4
// Console.WriteLine($"Минимум: {min}; Индекс: {vin}");
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 1; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }



// Задание 5
// int[] num = new int[5];
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = Convert.ToInt32(Console.ReadLine());
// }
// int a = 0;
// for (int i = num.Length - 1; i >= 0; i--)
// {
//     if (num[i] % 2 == 0)
//     {
//         a++;
//     }
//     Console.Write(num[i] + " ");
// }
// Console.WriteLine($"Чётных чисел: {a}");


// Задание 6
// string[] names = { "Игорь", "Александр", "Вероника", "Ульяна, "Дмитрий" };
// Console.Write("Введите имя: ");
// string id = "";
// string name = Console.ReadLine();
// for (int i = 0; i < names.Length; i++)
// {
//     if (name == names[i])
//     {
//         ind = Convert.ToString(i);
//         break;
//     }
// }
// Console.WriteLine(ind);



// Итоговая задача. «Журнал оценок»
// int[] grades = [4, 5, 4, 5, 2, 4, 3, 5];
// Console.Write("Оценки: ");
// int dva = 0;
// int patb = 0;
// int sum = 0;
// int max = 0;
// int min = 2;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write(grades[i] + "; ");
//     sum += grades[i];
//     if (grades[i] > max)
//     {
//         max = grades[i];
//     }
//     if (grades[i] <= min)
//     {
//         min = grades[i];
//     }
//     if (grades[i] == 2)
//     {
//         dva++;
//     }
//     else if (grades[i] == 5)
//     {
//         patb++;
//     }
// }
// double average = (double)sum / grades.Length;
// Console.WriteLine($"Средняя оценка: {average}");
// Console.WriteLine($"Наибольшая оценка: {max}; Наименьшая оценка: {min}");
// Console.WriteLine($"Количество двоек: {dva}; Количество пятёрок: {patb}");
// if (average >= 4.5)
// {
//     Console.WriteLine("Отличник");
// } 
// else if (average >= 3.5)
// {
//     Console.WriteLine("Хорошист");
// } 
// else
// {
//     Console.WriteLine("Есть над чем поработать");
// }


// Допзадание
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int a = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = a;
}
foreach (int n in arr)
{
    Console.Write(n + " ");
}
