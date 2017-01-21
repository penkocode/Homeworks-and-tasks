using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var exHour = int.Parse(Console.ReadLine());
            var exMin = int.Parse(Console.ReadLine());
            var stuHour = int.Parse(Console.ReadLine());
            var stuMin = int.Parse(Console.ReadLine());

            var examStartTime = exHour * 60 + exMin;
            var studentAriveTiem = stuHour * 60 + stuMin;
            var diff = studentAriveTiem - examStartTime;

            if (diff <-30)
            {
                Console.WriteLine("Early");
            }
            else if (diff <= 0)
            {
                Console.WriteLine("On Time");
            }
            else
            {
                Console.WriteLine("Late");
            }
            if (diff != 0)
            {
                var hours = Math.Abs(diff / 60);
                var min = Math.Abs(diff % 60);

                if (hours > 0)
                {
                    if (min < 10)
                        Console.Write(hours + ":0" + min + " hours");
                    else
                        Console.Write(hours + ":" + min + " hours");
                }
                else
                    Console.Write(min + " minutes");
                if (diff < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }

        }

    }
}

