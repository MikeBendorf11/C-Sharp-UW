//------------------------------------------------- 
// MethodWithThrows.cs by Charles Petzold 
//------------------------------------------------- 
using System;

static uint MyParse(string str)
{
    uint result = 0;
    int i = 0;

    if (str == null)
        throw new ArgumentNullException();

    str = str.Trim();

    if (str.Length == 0)
        throw new FormatException();

    while (i < str.Length)
    {
        if (!Char.IsDigit(str, i))
            throw new FormatException();

        result = checked(10 * result + (uint)str[i] - (uint)'0');

        i++;
    }
    return result;
}