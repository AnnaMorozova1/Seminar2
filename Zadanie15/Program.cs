using System;
class Program
{
    static void SelectDay()
    {
        string[] Day = { "Понедельник", "Вторник", "Среда", "Четверг", 
                        "Пятница", "Суббота", "Воскресенье" };
        WriteSelect(Day);
        Console.WriteLine("Укажите день недели: ");
        int numberDay=Convert.ToInt32(Console.ReadLine());
        if (numberDay<6)
        {
            Console.WriteLine(Day[numberDay-1]+ " Будний день ");
        }
        else if (numberDay>5)
        {
            Console.WriteLine(Day[numberDay-1]+ " Выходной день");
        }
        
      
    }
static void WriteSelect(string[] args) 
    {
        for (int i = 0; i < args.Length - 1; i++)
        {
            Console.Write(i + 1 + "-" + args[i] + ",");
        }
        Console.WriteLine(args.Length + "-" + args[args.Length - 1] + ".");
    }

    static void Main(string[] args)
    {
        SelectDay();       
    }
}
      
    
   