using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
//Mine
//X rock 1
//Y paper 2 
//Z Scissors 3 
//His
//A rock 1 
//B paper 2 
//C Scissors 3

//X Loss 0
//Y Draw 3
//Z Won 6

int sum = 0;

string file = @"C:/Users/Strahinja/source/repos/Advent2/Advent2/input.txt";
string input = File.ReadAllText(file);
string[] turns = input.Split(new string[] { "\r\n" }, StringSplitOptions.None);
foreach (string turn in turns)
{
    switch (turn)
    {
        case "A Y":
            sum += 4;
            break;
        case "A X":
            sum += 3;
            break;
        case "A Z":
            sum += 8;
            break;
        case "B X":
            sum += 1;
            break;
        case "B Y":
            sum += 5;
            break;
        case "B Z":
            sum += 9;
            break;
        case "C Z":
            sum += 7;
            break;
        case "C X":
            sum += 2;
            break;
        case "C Y":
            sum += 6;
            break;
    }
    Console.WriteLine(sum);
}
