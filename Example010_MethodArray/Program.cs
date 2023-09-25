int[] array = { 16, 23, 36, 46, 52, 46, 16, 79, 78 };
int n = array.Length;
int find = 46;

int index = 0;

while (index<n) 
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}