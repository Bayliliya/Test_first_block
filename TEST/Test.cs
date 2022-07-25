// Данная программа из массива строк формирует новый массив, состоящий из строк длина которых меньше или равна 3 символам
string [] array = {"123", "dfdggd", "fgfh", "abc", ":-)", "^_^"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count +=1;
} 
Console.WriteLine(count);