int[] array = { 1, 3, 5, 7, 12, 67, 2, 99 };

int n = array.Length;

Console.Write("Enter the number you want to find: ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;
bool findnumber = false;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine("The needed number is the " + index + " element");
        findnumber = true;
    }
    index++;
}
if(findnumber == false)
{
    Console.WriteLine("Couldn't find the needed number");
}