//Лекция 3 по знакомству с языками программирования

// методы имеет воозращаемый тип 
// 1 Вид
// ничего не принимают ничего не возвращают
// void Method1()
// {
//     Console.WriteLine("Avtorstvo");
// }
// Method1(); 
// Обязательно со скобками



// 2 Вид
// что-то принимают ничего не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i= 0;
//     while (i < count)
//     {
//          Console.WriteLine(msg);
//         i++;//Инкримент увеличение на еденицу деккримент уменьшение на 1
//     }

// }
// Method21(count: 4, msg:"Новый текст");

// 3 Вид
// ничего принимают что-то возвращают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);


// 4 Вид
// что-то принимают что-то возвращают


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


//FOR - собирает всё в кучу

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for ( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//      Console.WriteLine();
// }

// ======== Работа с Текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом Согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// // string s = "qwerty"
// //             012
// // s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// string newText_2 = Replace(newText, 'к', 'К');
// Console.WriteLine(newText_2);
// string newText_3 = Replace(newText_2, 'С', 'с');
// Console.WriteLine(newText_3);


//=====Работа с массивами
//Задача упорядочить массив от меньшего к большему и наоборот

// int[] arr = { 3, 5, 4, 3, 2, 6, 7, 1, 1 };


// void PrintArray(int[] array) // печать массива
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//      Console.WriteLine();
// }

// PrintArray(arr);

// // //Метод перебирает массив и упорядочивает его от меньшего к большему
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++) // цикл записи минимального значения в текущую ячейку массива
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++) // цикл поиска минимального значения в подмассиве 
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
      
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

//Метод перебирает массив и упорядочивает значения от большего к меньшему
// void SelectionSortMaxMin(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//         }
      
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }

// SelectionSortMaxMin(arr);
// PrintArray(arr);