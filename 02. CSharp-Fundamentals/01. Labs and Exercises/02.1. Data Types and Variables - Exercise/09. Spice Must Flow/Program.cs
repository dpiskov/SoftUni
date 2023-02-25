int yield = int.Parse(Console.ReadLine());

int totalYield = 0;

int day = 0;

if (yield < 100)
{
    Console.WriteLine(day);
    Console.WriteLine(totalYield);
}
else
{
    while (yield >= 100)
    {
        totalYield += yield - 26;
        yield -= 10;
        day++;
    }

    totalYield -= 26;
    Console.WriteLine(day);
    Console.WriteLine(totalYield);
}





//    while (yield >= 100)
//    {

//        if (day != dayCopy)
//        {
//            yield -= drop;

//            if (yield >= 100)
//            {
//                totalYield += yield;
//            }
//            else
//            {
//                totalYield -= 26;
//                break;
//            }
//        }

//        totalYield -= 26;

//        day++;
//    }
//}

//Console.WriteLine(day);
//Console.WriteLine(totalYield);