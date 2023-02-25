using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());


            int totalMinutesOfExam = hourOfExam * 60 + minuteOfExam;
            int totalMinutesOfArrival = hourOfArrival * 60 + minuteOfArrival;
            int minuteDifference = totalMinutesOfArrival - totalMinutesOfExam;
            int hourDifference = 0;



            // case 1 - late 
            if (totalMinutesOfArrival > totalMinutesOfExam)
            {

                if (minuteDifference > 59)
                {
                    hourDifference = minuteDifference / 60;
                    minuteDifference = minuteDifference % 60;
                    if (minuteDifference < 10)
                    {
                        Console.WriteLine($"Late\n{hourDifference}:0{minuteDifference} hours after the start");
                    }

                    else
                    {
                        Console.WriteLine($"Late\n{hourDifference}:{minuteDifference} hours after the start");
                    }
                }

                else if (minuteDifference <= 59)
                {
                    Console.WriteLine($"Late\n{minuteDifference} minutes after the start");
                }
            }// case 2 - on time 
            else if (totalMinutesOfExam - totalMinutesOfArrival <= 30 || totalMinutesOfExam - totalMinutesOfArrival == 0)
            {
                minuteDifference = Math.Abs(minuteDifference);

                if (minuteDifference == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (minuteDifference <= 30)
                {
                    Console.WriteLine($"On time\n{minuteDifference} minutes before  the start");
                }


            }//case 3 - early
            else if (totalMinutesOfExam - totalMinutesOfArrival > 30)
            {

                minuteDifference = Math.Abs(minuteDifference);

                if (minuteDifference > 59)
                {
                    hourDifference = minuteDifference / 60;
                    minuteDifference = minuteDifference % 60;
                    if (minuteDifference < 10)
                    {
                        Console.WriteLine($"Early\n{hourDifference}:0{minuteDifference} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"Early\n{hourDifference}:{minuteDifference} hours before the start");
                    }

                }
                else if (minuteDifference <= 59)
                {
                    Console.WriteLine($"Early\n{minuteDifference} minutes before  the start");
                }
            }
        }

    }
}


    ////Вход
    //int examHours = int.Parse(Console.ReadLine());
    //int examMinutes = int.Parse(Console.ReadLine());
    //int arrivalHours = int.Parse(Console.ReadLine());
    //int arrivalMinutes = int.Parse(Console.ReadLine());

    //string late = "Late";
    //string onTime = "On time";
    //string early = "Early";

    //int examTime = (examHours * 60) + examMinutes;
    //int arrivalTime = (arrivalHours * 60) + arrivalMinutes;

    //int totalMinutesDifference = arrivalTime - examTime;

    //string studentArrival = late;

    //if (totalMinutesDifference <= -30)
    //{
    //    studentArrival = early;
    //}
    //else if (totalMinutesDifference <= 30)
    //{
    //    studentArrival = onTime;
    //}

    //string result = string.Empty;

    //if (totalMinutesDifference != 0)
    //{
    //    int hoursDifference = Math.Abs(totalMinutesDifference / 60);
    //    int minutesDifference = Math.Abs(totalMinutesDifference % 60);

    //    if (hoursDifference > 0)
    //    {
    //        result = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);
    //    }
    //    else
    //    {
    //        result = minutesDifference + " minutes";
    //    }
    //    if (totalMinutesDifference < 0)
    //    {
    //        result += " before the start";
    //    }
    //    else
    //    {
    //        result += " after the start";
    //    }
    //}

    ////Изход
    //Console.WriteLine(studentArrival);
    //if (!string.IsNullOrEmpty(result))
    //{
    //    Console.WriteLine(result);
    //}
