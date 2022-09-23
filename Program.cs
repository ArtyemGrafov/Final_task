string[] array = {"qwerty", "df", "-4d", "fggbhh", "09gg", "dsdfsd"};
string[] result = {};
int count = 0;

Console.Clear();

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        count++;
        result = AddToArray(result, count, array[i]);
    }
}

Console.Write($"Result : [{string.Join(", ", result)}]");

/////////////////////////////////////////////////

string[] AddToArray(string[] arr, int count, string str)
{
    string[] res = new string[count];
    for (int i = 0; i < res.Length - 1; i++)
        res[i] = arr[i];
    res[count - 1] = str;
    return res;
}