using System;
namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Console.WriteLine("Wpisz proszę jedną cyfrę od 1-7");
                Console.WriteLine("Podaj cyfrę");
              
                int cyfra=1 ;

                Int32.TryParse(Console.ReadLine(), out cyfra);

                {
                    if (cyfra==1)
                    {
                        Console.WriteLine("poniedziałek:");
                    }
                    else if (cyfra ==2)
                    {
                        Console.WriteLine("Wtorek:");
                    }
                    else if (cyfra ==3)
                    {
                        Console.WriteLine("Środa:");
                    }
                    else if (cyfra == 4)
                    {
                        Console.WriteLine("Czwartek:");
                    }
                    else if (cyfra == 5)
                    {
                        Console.WriteLine("Piątek:");
                    }
                    else if (cyfra == 6)
                    {
                        Console.WriteLine("Sobota");
                    }
                    else if (cyfra == 7)
                    {
                        Console.WriteLine("Niedziela");
                    }
                    else if (cyfra >7 )
                    {
                        Console.WriteLine("Podaleś złą cyfrę");
                    }
                    else if (cyfra < 1)
                    {
                        Console.WriteLine("Podaleś złą cyfrę");
                    }
                }


            }
        }
    }
}