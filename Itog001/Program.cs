// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символам. 



string[] wordsLetters = new string[5]{"world", "55", "318", "home", "book"};
string[] newArray = new string[wordsLetters.Length];

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


