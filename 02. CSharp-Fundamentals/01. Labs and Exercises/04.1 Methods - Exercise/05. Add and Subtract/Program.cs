int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int addedResult = Add(num1, num2, num3);
int result = Subtract(addedResult, num3);
PrintResult(result);

static int Add(int num1, int num2, int num3) => num1 + num2;

static int Subtract(int result, int num3) => result - num3;

static void PrintResult(int number) => Console.WriteLine(number);