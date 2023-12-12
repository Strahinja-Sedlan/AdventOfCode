using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

string file = @"C:/Users/Strahinja/source/repos/Advent4/Advent4/input.txt";
string input = File.ReadAllText(file);
string[] each = input.Split(new string[] { "-", ",", "\r\n" }, StringSplitOptions.None);
int sum = 0;
for (int i = 0; i < each.Length; i += 4)
{
    int first = int.Parse(each[i]);
    int second = int.Parse(each[i + 1]);
    int third = int.Parse(each[i + 2]);
    int fourth = int.Parse(each[i + 3]);
    if ((first <= third && second >= fourth) || (first >= third && second <= fourth) || (first <= third && second >= third) || (first >= third && first <= fourth))
    {
        sum++;
    }
    Console.WriteLine(first);
    Console.WriteLine(second);
    Console.WriteLine(third);
    Console.WriteLine(fourth);
}
Console.WriteLine(sum);