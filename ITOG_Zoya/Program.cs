// ЗАДАЧА
// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решение не рекомендуется пользоваться
// коллекциями,  лучше обойтись исключительно массивами
Console.WriteLine("Итоговая задача - общая часть 1");

string[] array1 = new string[6] {"123", "23", "hello", "world", "res", "two"};
string[] array2 = new string[array1.Length];
int n = HreeCharacters(array1, array2);
 Console.WriteLine($"количество элементов массива на три и менее символов = {n} ");
string[] arrayResult = new string[n]; // массив, содержащий только элементы на три и менее символов
TruncationArray(array2, arrayResult);
PrintArray(arrayResult);
    
int HreeCharacters(string[] array1, string[] array2) // Метод фильтрации массива на 3 символа
{
int count=0;
    for (int i = 0; i < array1.Length; i++)
        {
        if(array1[i].Length <= 3)
            {
            array2[count] = array1[i];
            count++;
            }
        };
return count;
};

void TruncationArray(string[] array2, string[] arrayResult) // Метод "усечения" массива до количества ненулевых (непустых) элементов
{ int count=0;
    for (int i = 0; i < array2.Length; i++)
        {
            if(String.IsNullOrEmpty(array2[i])) 
                {;}
               else
                { arrayResult[count] = array2[i];};
                count++;
        };
};
    


