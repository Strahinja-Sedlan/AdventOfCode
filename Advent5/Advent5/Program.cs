using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Linq;

var file = File.ReadAllLines(@"C:/Users/Strahinja/source/repos/Advent5/Advent5/input.txt");
var input = new List<string>(file);
//string[] turns = input.Split(new string[] {" ", "\r\n" }, StringSplitOptions.None);

var stacks = new List<List<string>>()
{
    new List<string>() { "j", "h", "p", "m", "s", "f", "n", "v" },
    new List<string>() { "s", "r", "l", "m", "j", "d", "q" },
    new List<string>() { "n", "q", "d", "h", "c", "s", "w", "b" },
    new List<string>() { "r", "s", "c", "l" },
    new List<string>() { "m", "v", "t", "p", "f", "b" },
    new List<string>() { "t", "r", "q", "n", "c" },
    new List<string>() { "g", "v", "r" },
    new List<string>() { "c", "z", "s", "p", "d", "l", "r" },
    new List<string>() { "d", "s", "j", "v", "g", "p", "b", "f" },
};
foreach (var item in input)
{
    var vals = item.Split(" ");

    int move = Int32.Parse(vals[1]);
    int from = Int32.Parse(vals[3]) - 1;
    int to = Int32.Parse(vals[5]) - 1;

    var crate = stacks[from].TakeLast(move).ToList();
    stacks[to] = stacks[to].Concat(crate).ToList();
    stacks[from].RemoveRange(stacks[from].Count - move, move);
}
string output = "";
foreach (var stack in stacks)
{
    output += stack.Last();
}
Console.WriteLine(output);