// Данная программа из массива строк формирует новый массив, состоящий из строк длина которых меньше или равна 3 символам

Console.WriteLine("Введите количество элементов массива");
int n = Enter();

string[] array = new string[n];

EnterArray();

//функция для заполнения массива
void EnterArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива подиндексом {i}");
        array[i] = Console.ReadLine();

    }
}
//EnterArray(n);


//распечатка
Console.Write("[");
Printarray(array);
Console.Write("] -> ");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count += 1;
}

string[] arrayModify = FillModifyArray(array, count);
//распечатка
Console.Write("[");
Printarray(arrayModify);
Console.Write("]");

//функция заполнения нового массива

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

// //функция для ввода массива
// void EnterArray(int num, string massiv)
// {

//     for (int i = 0; i < num; i++)
//     {
//         Console.WriteLine($"Введите элемент массива подиндексом {i}");
//         massiv[i] = Console.ReadLine();

//     }

// }