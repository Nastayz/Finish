﻿/*Задача. Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых <= 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтися исключительно массивами.
["hello","2","world",":-)"]->["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]
["Russia","Denmark","Kazan"]->[]*/


string[] arr = {"hello","2","world",":-)"};

Console.WriteLine();
Console.Write("Массив: [");
Console.Write(string.Join(", ", arr));
Console.Write("]");

int count = 0;
int symbolsLength = 3;

for (int i = 0; i < arr.Length; i++) {
	if(arr[i].Length <= symbolsLength) {
		count++;
	}   
}

Console.WriteLine();
Console.Write("Полученный массив: [");
string[] arrNew = new string[count];
int j = 0;
for (int i = 0; i < arr.Length; i++) {
    if (arr[i].Length <= symbolsLength) {
        arrNew[j] = arr[i];
        if (i != arr.Length - 1) {
            Console.Write(arrNew[j] + ", ");
        }
        else {
            Console.Write(arrNew[j]);
        }
        j++;
    }
}
Console.Write("]");