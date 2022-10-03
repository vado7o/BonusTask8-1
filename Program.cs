// Задача со звёздочкой1: Задайте одномерный массив, заполненный случайными числами. 
// Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
//Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

Console.Clear();
Console.WriteLine("Программа, показывающая разницу между максимальным и минимальным элементами массива.");

int size = 0;
List<int> evenArray = new List<int>();
List<int> notEvenArray = new List<int>();

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
}

int[] array = FillArray(size, 1, 10);
Console.Write("\nCгенерированный массив - ");
PrintArray(array);
DefineEven(array);
Console.WriteLine("\nМассив с чётными числами - [" + String.Join(", ", evenArray) + " ]");
Console.WriteLine("Массив с НЕчётными числами - [" + String.Join(", ", notEvenArray) + " ]");
double evenAverage = CalcAverage(evenArray);
double notEvenAverage = CalcAverage(notEvenArray);

Console.Write("средн. арифм. значений элементов массива с чётными числами (" + evenAverage + ") ");
if(evenAverage > notEvenAverage)
{
    Console.Write("> средн. арифм. значений элементов с нечётными числами (" + notEvenAverage + ") ");
}
else if(evenAverage < notEvenAverage)
{
    Console.Write("< средн. арифм. значений элементов с нечётными числами (" + notEvenAverage + ") ");
}
else Console.Write("= средн. арифм. значений элементов с нечётными числами (" + notEvenAverage + ") ");

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

void DefineEven(int[] array)
{
    for(int index = 0; index < size; index++) 
    {
        if(array[index] % 2 == 0) 
        {
            evenArray.Add(array[index]);
        }
        else notEvenArray.Add(array[index]);
    }
}

double CalcAverage(List<int> array)
{
    double sum = 0.0;
    for(int index = 0; index < array.Count; index++)
    {
        sum += Convert.ToDouble(array[index]);
    }
    return sum / Convert.ToDouble(array.Count);
}