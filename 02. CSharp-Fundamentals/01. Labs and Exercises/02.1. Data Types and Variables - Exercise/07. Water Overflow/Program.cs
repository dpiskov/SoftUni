//int n = int.Parse(Console.ReadLine());

//int tankCapacity = 255;

//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    int quantity = int.Parse(Console.ReadLine());

//    if (sum + quantity >= tankCapacity)
//    {
//        Console.WriteLine("Insufficient capacity!");
//    }

//    if (sum + quantity <= tankCapacity)
//    {
//        sum += quantity;
//    }
//}

//Console.WriteLine(sum);


const int CAPACITY = 255;
int n = int.Parse(Console.ReadLine());

int totalQuantity = CAPACITY;

for (int i = 0; i < n; i++)
{
    int currQuantity = int.Parse(Console.ReadLine());
    if (totalQuantity - currQuantity >= 0)
    {
        totalQuantity -= currQuantity;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

int totalFieldQuantity = CAPACITY - totalQuantity;
Console.WriteLine(totalFieldQuantity);