Console.WriteLine("type the number of the mission beetween 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
int mission = int.Parse(Console.ReadLine());
if (mission == 3)
{
    Console.WriteLine("Mission 3");
    Console.WriteLine("");
    Console.WriteLine();
    Console.WriteLine("the odd numbers are");
    for (int i = 10; i < 40; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write(", " + i);
        }
    }
    Console.WriteLine();
    Console.WriteLine("the even numbers are: ");
    for (int i = 60; i < 90; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(", " + i);
        }
    }

}

else if (mission == 4)
{
    Console.WriteLine("mission 4");
   Console.WriteLine("put a number: ");
    int num = int.Parse(Console.ReadLine());
    for (int i = 1; i <= num; i++)
   {
     if (num % i == 0)
        {
          Console.Write(" ," + i);
       }
   }

}

else if (mission == 5)
{
    Console.WriteLine("mission 5");
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("put a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num / 10 == 0)
        {
            Console.WriteLine("The number is single-digit");
        }
        else if (num / 10 != 0)
        {
            Console.WriteLine("The number is doul-digit");
        }
    }

}
else if (mission == 6)
{
    Console.WriteLine("mission 6");
    int AvgGrades = 0;
    int HighGrades = 0;
    int LowGrades = 0;
    int AvgGradesInIsrael;
    Console.WriteLine("Please input the average of grades in israel: ");
    AvgGradesInIsrael = int.Parse(Console.ReadLine());
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Please input a grade: ");
        int StudentGrade = int.Parse(Console.ReadLine());
        if (StudentGrade > AvgGradesInIsrael)
        {
            HighGrades++;
        } 

        else if (StudentGrade < AvgGradesInIsrael)
        {
            LowGrades++;
        }

        else if(StudentGrade == AvgGradesInIsrael)
        {
            AvgGrades++;
        }
    }
    Console.WriteLine($"The amount of students that are below the average is: {LowGrades}");
    Console.WriteLine($"The amount of students that are above the average is: {HighGrades}");
    Console.WriteLine($"The amount of students that are average is: {AvgGrades}");
}
else if (mission == 7)
{
    Console.WriteLine("mission7");
    int tested;
    Console.WriteLine("how many people who were tested: ");
    tested = int.Parse(Console.ReadLine());
    int failed = 0;
    int passed = 0;

    for (int i = 0; i < tested; i++)
    {
        Console.WriteLine("put the amount of mistakes: ");
       int Mistakes = int.Parse(Console.ReadLine());
        if (Mistakes > 3)
        {
            failed++;
        } else if (Mistakes <= 3)
        {
            passed++;
        }

    }
    Console.WriteLine($"The amount of people who passed is: {passed}");
    Console.WriteLine($"The amount of people who failed is: {failed}");


}
else if (mission == 8)
{
    Console.WriteLine("mission 8");
    static int multiplier(int x, int y)
    {
        int z = x;
        for (int i = 1; i < y; i++)
        {
            z = z + x;
        }
        Console.WriteLine(z);
        return z;

    }

    Console.WriteLine("put a number: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("put a second number: ");
    int y = int.Parse(Console.ReadLine());
    multiplier(x, y);

}
else if (mission == 9)
{
    Console.WriteLine("mission 9");

    Console.WriteLine("ut a number: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("put a second number: ");
    int y = int.Parse(Console.ReadLine());
    int z = x;
    for (int i = 1; i < y; i++)
    {
        z = z * x;
    }
    Console.WriteLine(z);

}
else if (mission == 10)
{
    Console.WriteLine("mission 10");
    static int function(int first, int second)
    {
        if (first % second == 0)
        {
            Console.WriteLine("This pair is even"); ;
        }
        else if (first % second != 0)
        {
            Console.WriteLine("This pair is odd");
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("please input first number: ");
            int pair = int.Parse(Console.ReadLine());
            Console.WriteLine("please input second number: ");
            int pair2 = int.Parse(Console.ReadLine());

            if (pair % pair2 == 0)
            {
                Console.WriteLine("This pair is even"); ;
            }
            else if (pair % pair2 != 0)
            {
                Console.WriteLine("This pair is odd");
            }
        }


        return 0;
    }

    Console.WriteLine("put first number: ");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("put second number: ");
    int Second = int.Parse(Console.ReadLine());

    function(first, Second);

}
else if (mission == 11)
{
    Console.WriteLine("mission 11");
    static int GroupCalc(int AmountOfKids)
    {

       int Children = 0;
        int Teenagers = 0;
        int childguide = 0;
       int adultguide = 0;
        for (int i = 0; i < AmountOfKids; i++)
        {
            Console.WriteLine("Please enter an age: ");
            int age = int.Parse(Console.ReadLine());
            if ((age >= 8) && (age <= 11))
            {
                Children++;
            }
            else if ((age >= 12) && (age <= 15))
            {
                Teenagers++;
            }
        }
        childguide = Children / 4;
        adultguide = Teenagers / 7;

        int reqchildguide = 150 / 4;
        int reqadultguide = 150 / 7;
        Console.WriteLine($"There are {Children} kids in the age range of: 8-11");
        Console.WriteLine($"{Teenagers} kids in the age range of: 12-15");
        Console.WriteLine($"{reqchildguide - childguide} guides required for children");
        Console.WriteLine($"{reqadultguide - adultguide} guides required for adults");
        return 0;
    }

    Console.WriteLine("put the amount of kids");
    int num = int.Parse(Console.ReadLine());
    GroupCalc(num);
}

else if (mission == 12)
{
    Console.WriteLine("mission 12");
    int num = int.Parse(Console.ReadLine());
    int x = num;
    for (int i = 1; i < num; i++)
    {
        x = x * i;
    }
    Console.WriteLine(x);

}