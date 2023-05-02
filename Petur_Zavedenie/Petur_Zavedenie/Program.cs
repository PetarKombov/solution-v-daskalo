internal class Program
{
    private static void Main()
    {
        Console.Write("Kolko gosti ? ");
        var gosti = double.Parse(Console.ReadLine());

        Console.Write("Masa za pushachi ili ne pushachi?");

       var pushaci = Console.ReadLine();
        //vuprosi za gostite
        double ovcharski, troshiq, mlecni;
        double totalsalati;
        double kebapche, agneshko, kartof;
        double totalosnovni;
        double torta, sladoled, kremkaramel;
        double totaldeserti;
        double chai, rakij, kafe;
        double totaltoplinapitki;
        double voda, kola, bira;
        double totalstydeninapitki;
        
        double ovcharski1, troshiq1, mlecni1;
        double totalsalati1;
        double kebapche1, agneshko1, kartof1;
        double totalosnovni1;
        double torta1, sladoled1, kremkaramel1;
        double totaldeserti1;
        double chai1, rakij1, kafe1;
        double totaltoplinapitki1;
        double voda1, kola1, bira1;
        double totalstydeninapitki1;


        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        Console.Write("Колко Салати?");
        double salati = double.Parse(Console.ReadLine());
        if (salati > 0)
        {
            Console.Write("Колко овчарски салати");
             ovcharski = double.Parse(Console.ReadLine());
            Console.Write("Колко троший ");
             troshiq = double.Parse(Console.ReadLine());
            Console.Write("Колко млечни салати");
             mlecni = double.Parse(Console.ReadLine());           
            totalsalati = ovcharski * 5.50 + troshiq * 3.70 + mlecni * 4.85;
        }
        else
        {
            Console.WriteLine();
        }


        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Колко основни ястия?");
        double osnovni = double.Parse(Console.ReadLine());

        if (osnovni > 0)

        {
            Console.Write("Колко кебапчета");
             kebapche = double.Parse(Console.ReadLine());
            Console.Write("Колко агнешко ");
            agneshko = double.Parse(Console.ReadLine());
            Console.Write("Колко Пържени картофи");
            kartof = double.Parse(Console.ReadLine());
            totalosnovni= kebapche * 3.00 + agneshko * 25.00 + kartof * 10.00;
        }

        else
        {
            Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        Console.Write("Колко напитки?");
        double drink = double.Parse(Console.ReadLine());
        Console.WriteLine("Колко Топли напитки?");
        double toplinapitki = double.Parse(Console.ReadLine());
        Console.WriteLine("Колко Студени напитки?");
        double stydeninapitkii = double.Parse(Console.ReadLine());
        if (toplinapitki > 0)
        {
            Console.Write("Колко Ракий");
             rakij = double.Parse(Console.ReadLine());
            Console.Write("Колко Кафета  ");
             kafe = double.Parse(Console.ReadLine());
            Console.Write("Колко чайове? ");
             chai = double.Parse(Console.ReadLine());
            totaltoplinapitki = rakij * 3.50+kafe *2 +chai *0.7;
        }
        else
        {

        }
        if (stydeninapitkii > 0)
        {
            Console.Write("Колко Кока Коли  ");
             kola = double.Parse(Console.ReadLine());        
            Console.Write("Колко Води ");
             voda = double.Parse(Console.ReadLine());
            Console.Write("Колко Бири  ");
             bira = double.Parse(Console.ReadLine());
            totalstydeninapitki = bira * 3.50 + voda * 1 + kola * 2;
        }
        else
        {

        }

        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Колко Десерти?");
        double deserti = double.Parse(Console.ReadLine());
        if (deserti > 0)
        {
            Console.Write("Колко Торти");
             torta = double.Parse(Console.ReadLine());
            Console.Write("Колко Сладоледи ");
             sladoled = double.Parse(Console.ReadLine());
            Console.Write("Колко Крем карамели");
             kremkaramel = double.Parse(Console.ReadLine());
            totaldeserti = torta * 3.50 + sladoled * 3.00 + kremkaramel * 3.50;
        }


        Console.WriteLine("Oshte neshto bihte li izkali?");
       var oshte = Console.ReadLine();
        if (oshte == "да")
        {
            
            Console.Write("Колко Салати?");
            double salati1 = double.Parse(Console.ReadLine());
            if (salati1 > 0)
            {
                Console.Write("Колко овчарски салати");
                ovcharski1 = double.Parse(Console.ReadLine());
                Console.Write("Колко троший ");
                troshiq1 = double.Parse(Console.ReadLine());
                Console.Write("Колко млечни салати");
                mlecni1 = double.Parse(Console.ReadLine());
                totalsalati1 = mlecni1 * 3.70 + troshiq1 * 4.85 + ovcharski1 * 5.50;
            }
            else
            {
                Console.WriteLine();
            }
           


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Колко основни ястия?");
            double osnovni1 = double.Parse(Console.ReadLine());
            if (osnovni1 > 0)
            {
                Console.Write("Колко кебапчета");
                kebapche1 = double.Parse(Console.ReadLine());
                Console.Write("Колко агнешко ");
                 agneshko1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Пържени картофи");
                 kartof1 = double.Parse(Console.ReadLine());
                totalosnovni1 = kebapche1 * 3.50 + agneshko1 * 25 + kartof1 * 10;
            }
            else
            {
                Console.WriteLine();
            }

           

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            Console.Write("Колко напитки?");
            double piini1 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Колко Топли напитки?");
            double toplinapitki1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Колко Студени напитки?");
            double stydeninapitkii1 = double.Parse(Console.ReadLine());
            if (toplinapitki1 > 0)
            {
                Console.Write("Колко Ракий");
                 rakij1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Кафета  ");
                 kafe1 = double.Parse(Console.ReadLine());
                Console.Write("Колко чайове? ");
                 chai1 = double.Parse(Console.ReadLine());
                totaltoplinapitki1 = rakij1 *3.50  +kafe1* 2 + chai1 *0.8 ;
            }
            else

            if (stydeninapitkii1 > 0)
            {
                Console.Write("Колко Кока Коли  ");
                 kola1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Води ");
                 voda1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Бири  ");
                 bira1 = double.Parse(Console.ReadLine());
            }
            else


               

                Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Колко Десерти?");
            double deserti1 = double.Parse(Console.ReadLine());
            if (deserti1 > 0)
            {
                Console.Write("Колко Торти");
                 torta1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Сладоледи ");
                 sladoled1 = double.Parse(Console.ReadLine());
                Console.Write("Колко Крем карамели");
                 kremkaramel1 = double.Parse(Console.ReadLine());
                totaldeserti1 = torta1 *3 +sladoled1 * 2 +kremkaramel1 *2.50 ;
            }


        }


        Console.WriteLine("Как бихте изкали да платите?  Кеш или карта?");
        Console.WriteLine("Кеш или карта?");
        string plashtane = Console.ReadLine();
        if (plashtane == "Кеш")
        {

            double total = 0;
            Console.WriteLine();
        }
        else
        {
            //Iz4isli 5% ot cqlata suma kato bakshish!
            Console.WriteLine();
        }
    }
}