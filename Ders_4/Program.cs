void dersIzahi()
{
    void kecen_ders_izahi()
    {
        // datetime type
        DateTime date = DateTime.UtcNow;
        Console.WriteLine(date.DayOfWeek);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);
        Console.WriteLine(date.Millisecond);
        Console.WriteLine(date.ToString("dd/MM/yyy"));

        Console.WriteLine(date.Kind);


        /* var studentType = (StudentType)int.Parse(Console.ReadLine());

         if (studentType == StudentType.BadStudent)
         {
             Console.WriteLine("qiymeti -- 1");
         }*/

        DateTime date1 = DateTime.UtcNow;
        Console.WriteLine(date1.TimeOfDay.ToString("hh"));
        Console.WriteLine(date1.Add(TimeSpan.Parse("5.22:11:24")));
        Console.WriteLine(TimeSpan.FromDays(2));
        Console.WriteLine(date1.ToLongDateString());
    }

    //arrays
    int[] array1 = new int[3];
    array1[0] = 99;
    array1[1] = 98;
    array1[2] = 97;
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine(array1[i] + array1[i]);
    }
    int[] array2 = new int[5];
    Random rand = new Random();
    int toplami = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = rand.Next(0, 200);
        Console.WriteLine("{0}-ededin  {1}", i + 1, array2[i]);
        toplami += array2[i];

    }
    Console.WriteLine("Hamsinin toplami: {0}", toplami);
    var resulte = array2.Max();
    var resulte2 = array2.Min();
    Console.WriteLine("Ardicilligin MAX qiymeti {0}", resulte);
    Console.WriteLine("Ardicilligin MIN qiymeti {0}", resulte2);

    //2dim arrays
    int[,] array3 = new int[3, 3];
    for (int i = 0;i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = rand.Next(0, 10);
            Console.WriteLine("sizin ardicilligin {0} setrin {1} sutunun qiymeti {2} " ,i+1, j+1, array3[i,j]);
            toplami += array3[i, j];
        }
    }
    Console.WriteLine("Hamsinin toplami {0}",toplami);
}
dersIzahi();
//enum type
public enum StudentType
{
    BadStudent = 5,
    GoodStudent = 10,
    VeryGoodStudent = 15,
    ExcelentStudent = 20
}





