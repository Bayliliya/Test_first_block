// Данная программа из массива строк формирует новый массив, состоящий из строк длина которых меньше или равна 3 символам
string[] array = { "123", "dfdggd", "fgfh", "abc", ":-)", "^_^", "1111" };

//распечатка
Console.Write("[");
Printarray(array);
Console.Write("] -> ");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count += 1;
}
//Console.WriteLine(count);
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