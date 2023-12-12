using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

string file = @"C:/Users/Strahinja/source/repos/Advent3/Advent3/input.txt";
string input = File.ReadAllText(file);
string[] turns = input.Split(new string[] { "\r\n" }, StringSplitOptions.None);
int sum = 0;
for (int o = 0; o < turns.Length; o += 3)
{
       string first = turns[o];
       string second = turns[o + 1];
       string third = turns[o + 2];
    for (int i = 0; i < first.Length; i++)
    {
        for (int j = 0; j < second.Length; j++)
        {
            for (int z = 0; z < third.Length; z++) {
                if (first[i] == second[j] && second[j] == third[z])
                {
                    char letter = first[i];
                    if (Char.IsUpper(letter))
                    {
                        int value = letter - 38;
                        sum += value;
                    }
                    else if (Char.IsLower(letter))
                    {
                        int value = letter - 96;
                        sum += value;
                    }
                    goto LoopEnd;
                }
            }
        }
    }

LoopEnd:
    {
        Console.WriteLine(sum);
    }
}