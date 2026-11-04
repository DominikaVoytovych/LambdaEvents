using LambdaEvents;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

List<int> items = new List<int>
{ 23,56,4,6,10,42};

//готовий делегат, який вказує на функцію, яка приймає ціле число і повертає true або false
//Predicate<int> predicate = isPeople; //вказуємо на функцію isPeople, яка перевіряє чи число більше 25

var findItems = items.FindAll(x => x > 25); // x=> x>25 - це лямбда вираз

foreach (var item in findItems)
{
    Console.WriteLine(item);
}

//bool isPeople(int i)
//{
//    return i > 25;
//}

List<int> list = new List<int>();
list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 }); //AddRange - додає масив чисел в список

List<int> evenNumbers = list.FindAll(i => i % 2 == 0); //i => i % 2 == 0 - лямбда вираз
// вивести парні числа

Console.WriteLine("Парні числа:");
foreach (int evenNumber in evenNumbers)
{
    Console.Write("{0}\t", evenNumber);
}

//використання лямбда виразів з подіями
ProcessManager manager = new ProcessManager();

// Підписка на події за допомогою лямбда-виразів (+=)
//підписка - використання лямбда виразів, щоб використати події OnProgressChanged та OnCompleted
manager.OnProgressChanged += progress => Console.WriteLine($"Прогрес: {progress}%");
manager.OnCompleted += () => Console.WriteLine("Процес завершено!");

manager.StartProcess();