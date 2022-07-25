// Данная программа из массива строк формирует новый массив, состоящий из строк длина которых меньше или равна 3 символам


Console.WriteLine("Введите количество элементов массива");
int n = Enter();

string[] array = new string[n];

//ввод пользователем элементов массива
EnterArray();


Console.Write("[");
Printarray(array);  //вызов функции распечатки массива
Console.Write("] -> ");

int count = CountElement(array, 3);  //вызов функции для подсчета элементоа в новом массиве

string[] arrayModify = FillModifyArray(array, count); // вызов функции для заполнения массива


Console.Write("[");
Printarray(arrayModify);
Console.Write("]");



// функция подсчета элементов массива
int CountElement(string[] array, int num)

{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num) count += 1;
    }

    return count;

}





//функция заполнения модифицированного массива

string[] FillModifyArray(string[] massiv, int number)
{
    int k = 0;
    string[] res = new string[number];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i].Length <= 3)
        {
            res[k] = massiv[i];
            k++;
        }

    }
    return res;

}

//функция распечатки массива
void Printarray(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
        Console.Write($"{massiv[i]}; ");


}

//функция для ввода
int Enter()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Введено не число. Попробуйте снова: ");

    }
    return num;
}

//функция для заполнения массива с клавиатуры
void EnterArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива подиндексом {i}");
        array[i] = Console.ReadLine();

    }
}