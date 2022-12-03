//group1
//void Method1()
{
    //Console.WriteLine("Author name");
}

//Method1();


//group2
//void Method21(string msg, int count)
//{
    //int i = 0;
    //while(i < count)
    //{
        //Console.WriteLine(msg);
        //i++;
    //}
//}
//Method21(msg: "Text", count: 4);
//Method21(count: 4, msg: "new Text");


//group3
//int Method3() 
// {
// 	return DateTime.Now.Year;
// }

//int year = Method3();
//Console.WriteLine(year);

//group4
/*string Method4(int count,  string text)
{
	int i = 0;
	string result = String.Empty;

	while (i < count)
	{
	result = result + text;	
	i++;
	}
    return result;
}*/


// string Method4(int count,  string text)
// {
	
// 	string result = String.Empty;
//     for (int i = 0;i < count;i++)
// 	{
// 	    result = result + text;	
// 	}
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2;i <= 10;i++)
// {
// 	for (int j = 2;j <= 10;j++)
//     {
// 	Console.WriteLine($"{i}*{j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача:
// Дан текст. В нем нужно все пробелы заменить черточками, маленькие “к” заменить большими “К”, а большие “С” заменить маленькими “с”. Нужно определиться со значениями всех дано, что значит “дан”, что значит “черточка”, с или c. Для компа

// string text = "— Я думаю, — сказал князь, улыбаясь,"
//               + "— что, ежели бы вас послали "
//               + "вместо нашего милого Винценгероде," 
//               + "вы бы взяли приступом согласие прусского короля. "
//               + "Вы так красноречивы. Вы дадите мне чаю?";

//         // string s = "qwerty"
//         //             012345
//         // s[3]//
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
// {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }
//     return result;
// }
// string newText = Replace(text,'к', 'К');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text,'к', 'К');
// Console.WriteLine(newText);


int [] arr = {1,5,4,3,2,6,7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length ; i++) 
    {
        int minPosition = i;
        
        for (int j = i + 1; j  < array.Length - 1; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        } 

        int temporary = array[i];
        array [i] = array[minPosition];
        array [minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);