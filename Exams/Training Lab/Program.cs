using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var studenHour = int.Parse(Console.ReadLine());
            var studentMinute = int.Parse(Console.ReadLine());
            var examStartTime = examHour * 60 + examMinute;
            var studentTime = studenHour * 60 + studentMinute;
            var differenceMinute = studentTime - examStartTime;
            if (differenceMinute<-30)
            {
                Console.WriteLine("Early");
            }
            else if (differenceMinute<=0)
            {
                Console.WriteLine("On Time");
            }
            else
            {
                Console.WriteLine("Late");
            }
            if (differenceMinute != 0)
            {
                var hours = Math.Abs(differenceMinute / 60);
                var minutes = Math.Abs(differenceMinute % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (differenceMinute < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }
    }
}
