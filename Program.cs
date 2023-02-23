string[] array1 = new string[5] { "123", "23", "hello", "world", "res" }; //объявление списка
string[] array2 = new string[array1.Length]; // создание списка для заполнения минимальными значениями списка array1
void SearchMinElement(string[] array1, string[] array2) // метод который заполняет array2 из array1
{
    int count = 0; //  дополнительный счетчик для перебора позиции массива
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) // если элемент меньше 3 символов, положить в список array2 наименьший элемент
        {
            array2[count] = array1[i]; 
            count++;
        }
    }
}
void PrintArray(string[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SearchMinElement(array1, array2); // метод который считает и добавляет в array2 элементы меньше 3 из array1
PrintArray(array2); 