int centuries = int.Parse(Console.ReadLine());

double years = centuries * 100;

double days = (int)(years * 365.2422);

double hours = days * 24;

double minutes = hours * 60;

Console.Write($"{centuries} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");