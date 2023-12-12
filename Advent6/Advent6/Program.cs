using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

string file = @"C:/Users/Strahinja/source/repos/Advent6/Advent6/input.txt";
string input = File.ReadAllText(file);

int start = 0;
int length = 14;
for (int i = 0; i < input.Length; i++)
{
    String each = input.Substring(start, length);
        if (!(each.Length != each.Distinct().Count()))
        {
            Console.WriteLine(i*13+13);
            break;
        }
        else
        {
            start += 13;
        }
}
