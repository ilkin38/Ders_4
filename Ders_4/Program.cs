using System.Data;
using System.Security.AccessControl;
/*void dersIzahi()
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


var studentType = (StudentType)int.Parse(Console.ReadLine());

if (studentType == StudentType.BadStudent)
{
Console.WriteLine("qiymeti -- 1");
}

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
for (int i = 0; i < array3.GetLength(0); i++)
{
for (int j = 0; j < array3.GetLength(1); j++)
{
array3[i, j] = rand.Next(0, 10);
Console.WriteLine("sizin ardicilligin {0} setrin {1} sutunun qiymeti {2} ", i + 1, j + 1, array3[i, j]);
toplami += array3[i, j];
}
}
Console.WriteLine("Hamsinin toplami {0}", toplami);
}*/

//enum type
/*public enum StudentType
{
    BadStudent = 5,
    GoodStudent = 10,
    VeryGoodStudent = 15,
    ExcelentStudent = 20
}
*/



void tapsiriqlar()
{
    void tapsiriq1()
    {
        Console.WriteLine("Doguldugunuz gunu qeyd edin: ");
        string bDay = Console.ReadLine();
        Console.WriteLine("Doguldugunuz ayi qeyd edin: ");
        string bMonth = Console.ReadLine();
        DateTime time = DateTime.Now;
        int _month = int.Parse(bMonth) - time.Month;
        int _day = int.Parse(bDay) - time.Day;
        int heftegunu = Convert.ToInt32(time.AddMonths(_month).AddDays(_day).DayOfWeek);
        Console.WriteLine("Sizin novbeti dogum gununuz {0} tarixinie dusur. Bu da heftenin {1} gunune dusur.", time.AddMonths(_month).AddDays(_day), heftegunu);
    }

    void tapsiriq2()
    {
        TimeSpan ts;
    tezeden:
        Console.WriteLine("Dogum Tarixinizi Qeyd Edin (ay/gun/il olaraq)");
        try
        {
            string dogumGunu = Console.ReadLine();
            string[] _dogumGunu = dogumGunu.Split('/');
            DateTime time = DateTime.Now;
            DateTime _time = new DateTime(int.Parse(_dogumGunu[2]), int.Parse(_dogumGunu[0]), int.Parse(_dogumGunu[1]));
            ts = time - _time;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Xeta Bas verdi zehmet olmasa tekrar yoxlayin");
            goto tezeden;
        }

        Console.WriteLine("Bu gune kimi {0} gun yasamisiz.", ts.Days);
    }

    void tapsiriq3()
    {
        Console.Write("Nece Gun sonrasini bilmek isteyirsiz daxil edin -- ");
        int gun = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Now;

        Console.WriteLine("{0} gunden {1} gun sonra heftenin {2} olur", time, gun, time.AddDays(gun).DayOfWeek);
    }

    void tapsiriq4()
    {
        Console.WriteLine("Bu gunun Tarixini Yazin (ay/gun/il olaraq)");
        string Time = Console.ReadLine();
        string[] _Time = Time.Split('/');
        DateTime time = DateTime.Now;
        DateTime _time = new DateTime(int.Parse(_Time[2]), int.Parse(_Time[0]), int.Parse(_Time[1]));
        bool _checkTime = time.Day == _time.Day && time.Month == _time.Month && time.Year == _time.Year;
        if (_checkTime)
        {
            Console.WriteLine("Program Sonlandi bu gunun tarixi {0}", time.ToString("MM/dd/yyyy"));
        }
        else
        {
            Console.WriteLine("Tarixi Sehv Qeyd Elemisiz!");
        }
    }

    void tapsiriq5()
    {
        DateTime time = DateTime.Now;
        TimeSpan _time = TimeSpan.FromDays(1);
        Console.WriteLine(time.ToString());
        while (time.Year == 2024)
        {
            time = time + _time;
        }
        Console.WriteLine(time.AddDays(-1));
    }//tam basa dusmedim

    void tapsiriq6()
    {
        Console.WriteLine("Her hansi bir tarix daxil edin (ay/gun/il olaraq)");
        string tarix = Console.ReadLine();
        string[] _tarix = tarix.Split('/');

        DateTime time = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]));

        int a = Convert.ToInt32(time.DayOfWeek);

        switch (a)
        {
            case 1:
                DateTime _time1 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 6);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time1.ToString("MM/dd/yyyy"));
                break;
            case 2:
                DateTime _time2 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 5);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time2.ToString("MM/dd/yyyy"));
                break;
            case 3:
                DateTime _time3 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 4);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time3.ToString("MM/dd/yyyy"));
                break;
            case 4:
                DateTime _time4 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 3);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time4.ToString("MM/dd/yyyy"));
                break;
            case 5:
                DateTime _time5 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 2);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time5.ToString("MM/dd/yyyy"));
                break;
            case 6:
                DateTime _time6 = new DateTime(int.Parse(_tarix[2]), int.Parse(_tarix[0]), int.Parse(_tarix[1]) + 1);
                Console.WriteLine("Verilmis {0} tarixi ucun heftenin son gunu {1}", time.ToString("MM/dd/yyyy"), _time6.ToString("MM/dd/yyyy"));
                break;
            default:
                Console.WriteLine("Bu gun heftenin son gunudur");
                break;
        }

    }

    void tapsiriq7()
    {
        Console.Write("Sizin ardicilliginiz -- { ");
        int[] array1 = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = rnd.Next(0, 100);
            Console.Write("{0}, ", array1[i]);
        }
        Console.WriteLine("}");
        Console.WriteLine("Ardicilligin en boyuk deyeri --  {0} ", array1.Max());
    }

    void tapsiriq8()
    {
        Console.WriteLine("Heftenin gununu reqemle daxil edin");
        int DayoffWeeek = int.Parse(Console.ReadLine());
        if (DayoffWeeek <= 7)
        {
            Console.WriteLine($"Sizin Daxil etdiyiniz reqeme esasen heftenin gunu {(DayOfWeek)DayoffWeeek}");
        }
        else
        {
            DayoffWeeek = DayoffWeeek % 7;
            Console.WriteLine($"Sizin Daxil etdiyiniz reqeme esasen heftenin gunu {(DayOfWeek)DayoffWeeek}");
        }

    }

    void tapsiriq9()
    {
        string emeliyyatlar(string yazi)
        {
            char[] simvollar = { '+', '-', '/', '*', '%' };

            float cavab = 0;
            for (int i = 0; i < simvollar.Length; i++)
            {
                if (yazi.Contains(simvollar[i]))
                {
                    string[] yaziSp = yazi.Split(simvollar[i]);
                    if (simvollar[i] == '+')
                    {
                        for (int j = 0; j < yaziSp.Length; j++)
                        {
                            cavab += int.Parse(yaziSp[j]);
                        }
                        Console.WriteLine(cavab);
                    }
                    else if (simvollar[i] == '-')
                    {
                        cavab = int.Parse(yaziSp[0]);
                        for (int j = 1; j < yaziSp.Length; j++)
                        {
                            cavab -= int.Parse(yaziSp[j]);
                        }
                        Console.WriteLine(cavab);
                    }
                    else if (simvollar[i] == '/')
                    {
                        cavab = int.Parse(yaziSp[0]) / int.Parse(yaziSp[1]);
                        Console.WriteLine(cavab);
                    }
                    else if (simvollar[i] == '*')
                    {
                        cavab = int.Parse(yaziSp[0]);
                        for (int j = 1; j < yaziSp.Length; j++)
                        {
                            cavab *= int.Parse(yaziSp[j]);
                        }
                        Console.WriteLine(cavab);
                    }
                    else if (simvollar[i] == '%')
                    {
                        cavab = int.Parse(yaziSp[0]) % int.Parse(yaziSp[0]);
                        Console.WriteLine(cavab);
                    }
                    break;
                }
                
                //cavab = Convert.ToInt64(sim1);


            }
            return cavab.ToString();


        }
        //geri:
        //calculyator
        /*Console.WriteLine("               Calculyator Programi");
        Console.WriteLine("Hasi emeliyyati icra etmek isteyirsiz nomresini yazin ve sonra Enter duymesine basin basin");
        Console.WriteLine("1.Toplama\n2.Cixma\n3.Vurma\n4.Bolme\n5.Qaliq hesablamaq\n\n6.Programdan cix");
        int emeliyyat = int.Parse(Console.ReadLine());*/
        string emeliyyat = Console.ReadLine();
        emeliyyatlar(emeliyyat);
        /*switch (emeliyyat)
        {
            case 1:
                Console.Write("1 -ci Ededi daxil edin ");
                var a1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2 -ci Ededi daxil edin ");
                var b1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var c1 = a1 + b1;
                Console.Write("{0}+{1}={2}", a1, b1, c1);
                break;
            case 2:
                Console.Write("1 -ci Ededi daxil edin ");
                var a2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2 -ci Ededi daxil edin ");
                var b2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var c2 = a2 - b2;
                Console.Write("{0}-{1}={2}", a2, b2, c2);
                break;
            case 3:
                Console.Write("1 -ci Ededi daxil edin ");
                var a3 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2 -ci Ededi daxil edin ");
                var b3 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var c3 = a3 * b3;
                Console.Write("{0}x{1}={2}", a3, b3, c3);
                break;
            case 4:
                Console.Write("1 -ci Ededi daxil edin ");
                var a4 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2 -ci Ededi daxil edin ");
                var b4 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var c4 = a4 / b4;
                Console.Write("{0}/{1}={2}", a4, b4, c4);
                break;
            case 5:
                Console.Write("1 -ci Ededi daxil edin ");
                var a5 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2 -ci Ededi daxil edin ");
                var b5 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                var c5 = a5 % b5;
                Console.Write("{0}%{1}={2}", a5, b5, c5);
                break;
            default:
                Console.WriteLine("Yazdiginiz reqeme uygun icra olunacaq emeliyyat yoxdur");

                Console.Clear();
                goto geri;
                break;
        }*/
       
    }

}
tapsiriqlar();




