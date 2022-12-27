// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символам. 

string[] wordsLetters = new string[7]{"world", "55", "318", "home", "book", "old","4589"};
string[] newArray = new string[wordsLetters.Length];
System.Console.WriteLine();
findingValue(wordsLetters, newArray);
printArray(newArray);
System.Console.WriteLine();

void findingValue(string[] wordLetters, string[] newArray)
{
    int count = 0;
    for(int i = 0; i < wordsLetters.Length; i++)
    {
        if(wordLetters[i].Length <= 3)
        {
            newArray[count] = wordLetters[i];
            count++;
        }
    }
}

void printArray(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

