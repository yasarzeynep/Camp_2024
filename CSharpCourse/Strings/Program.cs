﻿string city = "Ankara";
foreach (var item in city)
{
Console.WriteLine(item);
}

string city2 = "İstanbul";
string result = city + city2;
Console.WriteLine(result);
Console.WriteLine(String.Format("{0}{1}", city, city2));