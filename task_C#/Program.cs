/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
На примере: ["'hello", "2", "world", " :-)"] -> ["2", ":-)"] */

string[] inpArr = {"Задан массив:  hello", "2", "world", ":-)"};
Console.WriteLine($"{String.Join(", ", inpArr)}"); 
string[] endArr = DesArr(inpArr);
Console.Write($"Вывод c символами < или = трём:  [{String.Join(", ", endArr)}]");

string[] DesArr(string[] inp) {string[] end = new string[]{}; int j = 0;
for (int i = 0; i < inp.Length; i++)
if (inp[i].Length <= 3) {Array.Resize(ref end, end.Length + 1); end[j] = inp[i]; j++;}
return end;}  