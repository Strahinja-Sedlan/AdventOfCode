using System.Text.RegularExpressions;
using System;
using System.IO;

string file = @"C:/Users/Strahinja/source/repos/ConsoleApp2/ConsoleApp2/input.txt";
string read = File.ReadAllText(file);
string[] rows = read.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.None);
int max = 0;
int max2 = 0;
int max3 = 0;
foreach (string row in rows)
{
    string[] numbers = row.Split(new string[] { "\r\n" }, StringSplitOptions.None);
    int sum = 0;
    foreach (string number in numbers)
    {
        sum += Int32.Parse(number);
        if (max < sum)
        {
            max3 = max2;
            max2 = max;
            max = sum;
        }
        else if (max2 < sum)
        {
            max3 = max2;
            max2 = sum;
        }
        else if (max3 < sum)
        {
            max3 = sum;
        }
    }
}
Console.WriteLine(max);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max + max2 + max3);