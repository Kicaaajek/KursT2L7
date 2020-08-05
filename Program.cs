using System;

namespace Lekcja7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kurs tydzień 2 lekcja 7- operatory logiczne.");
            Console.WriteLine("Zadanie 1");
            zadanie1();
            Console.WriteLine("Zadanie 2");
            zadanie2();
            Console.WriteLine("Zadanie 3");
            zadanie3(); 
            Console.WriteLine("Zadanie 4");
            zadanie4();
            Console.WriteLine("Zadanie 5");
            zadanie5();
            Console.WriteLine("Zadanie 6");
            zadanie6();
            Console.WriteLine("Zadanie 7");
            zadanie7();
            Console.WriteLine("Zadanie 8");
            zadanie8();
            Console.WriteLine("Zadanie 9");
            zadanie9();
            Console.WriteLine("Zadanie 10");
            zadanie10();
            Console.WriteLine("Zadanie 11");
            zadanie11();
            Console.WriteLine("Zadanie 12");
            zadanie12();
            Console.WriteLine("Zadanie 13");
            zadanie13();
        }
        public static void zadanie1()
        {
            int a = 5;
            int b = 5;
            if(a==b)
            {
                Console.WriteLine($"Zmienne {a} i {b} są sobie równe");
            }    
        }

        public static void zadanie2()
        {
            Console.WriteLine("Program sprawdza parzystość wprowadzonej liczby");
            int liczba;
            Console.WriteLine("Podaj liczbę do sprawdzenia: ");
            liczba = int.Parse(Console.ReadLine());
            if(liczba%2==0)
            {
                Console.WriteLine($"Wprowadzona liczba {liczba} jest parzysta");
            }
            else
            {
                Console.WriteLine($"Wprowadzona liczba {liczba} nie jest parzysta");
            }
        }

        public static void zadanie3()
        {
            int a;
            Console.WriteLine("Program sprawdza czy wprowadzona liczba jest dodatnia czy ujemna");
            Console.WriteLine("Wprowadź liczbę do sprawdzenia");
            a = int.Parse(Console.ReadLine());
            if(a>=0)
            {
                Console.WriteLine($"Wprowadzona liczba {a} jest dodatnia");
            }
            else
            {
                Console.WriteLine($"Wprowadzona liczba {a} jest ujemna");
            }
        }

        public static void zadanie4()
        {
            Console.WriteLine("Program sprawdza czy wprowadzony rok jest rokiem przestępnym");
            int rok;
            bool przestepny;
            Console.WriteLine("Wprowadź rok do sprawdzenia: ");
            rok = int.Parse(Console.ReadLine());
            przestepny= DateTime.IsLeapYear(rok);
            if (przestepny)
            {
                Console.WriteLine($"Wprowadzony rok {rok} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"Wprowadzony rok {rok} nie jest rokiem przestępnym");
            }
        }
        public static void zadanie5()
        {
            Console.WriteLine("Program sprawdza czy możesz ubiegać się o stanowisko posła, premiera, senatora, prezydenta");
            Console.WriteLine("Podaj swój wiek");
            int wiek;
            wiek = int.Parse(Console.ReadLine());
            if(wiek>=35)
            {
                Console.WriteLine("Możesz ubiegać się o stanowisko posła, senatora oraz prezydenta");
            }
            else if(wiek>=30)
            {
                Console.WriteLine("Możesz ubiegać się o stanowisko posła oraz senatora");
            }
            else if (wiek>=21)
            {
                Console.WriteLine("Możesz ubiegać się o stanowisko posła");
            }
        }

        public static void zadanie6()
        {
            Console.WriteLine("Podaj swój wzrost, a dowiesz się do jakiej kategorii należysz");
            char plec;
            string zmienna;
            Console.WriteLine("Podaj swoją płeć (K/M)");
            zmienna =Console.ReadLine();
            zmienna = zmienna.ToLower();
            plec = char.Parse(zmienna);
            
            Console.WriteLine("Podaj swój wzrost w cm");
            double wzrost;
            wzrost = double.Parse(Console.ReadLine());
            if (plec == 'k')
            {
                if (wzrost < 140)
                {
                    Console.WriteLine("Jesteś calineczką");
                }
                else if (wzrost < 150)
                {
                    Console.WriteLine("Jesteś latającą wróżką");
                }
                else if (wzrost < 160)
                {
                    Console.WriteLine("Jesteś dziewczynką");
                }
                else if (wzrost < 170)
                {
                    Console.WriteLine("Jesteś zebrą");
                }
                else if (wzrost < 180)
                {
                    Console.WriteLine("Jesteś koniem");
                }
                else if (wzrost < 200)
                {
                    Console.WriteLine("Jesteś żyrafą");
                }
            }
            else
            {
                if (wzrost < 140)
                {
                    Console.WriteLine("Jesteś gnomem");
                }
                else if (wzrost < 150)
                {
                    Console.WriteLine("Jesteś krasnoludem");
                }
                else if (wzrost < 160)
                {
                    Console.WriteLine("Jesteś chłopczykiem");
                }
                else if (wzrost < 170)
                {
                    Console.WriteLine("Jesteś mężczyzną");
                }
                else if (wzrost < 180)
                {
                    Console.WriteLine("Jesteś wysokim męzczycną");
                }
                else if (wzrost < 200)
                {
                    Console.WriteLine("Jesteś olbrzymem");
                }
            }
        }
        public static void zadanie7()
        {
            int[] tab=new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("podaj liczbę: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            int najwieksza = 0;
            for(int i=0;i<2; i++)
            {
                if(tab[i]>tab[i+1])
                {
                    najwieksza = tab[i];
                }
                else
                {
                    najwieksza = tab[i + 1];
                }
            }
            Console.WriteLine($"Najwieksza z liczb to: {najwieksza}");

        }

        public static void zadanie8()
        {
            Console.WriteLine("Program sprawdza czy kandydat może ubiegać się o miejsce na studiach");
            int matematyka;
            int fizyka;
            int chemia;
            int suma;
            Console.WriteLine("Kandydacie podaj swoje wyniki matur z następującyh przedmiotów:");
            Console.WriteLine("Matematyki:");
            matematyka = int.Parse(Console.ReadLine());
            Console.WriteLine("Fizyki: ");
            fizyka = int.Parse(Console.ReadLine());
            Console.WriteLine("Chemii: ");
            chemia = int.Parse(Console.ReadLine());
            suma = matematyka + chemia + fizyka;
            if(chemia>45 && fizyka>55 && matematyka>70 && suma>180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if( matematyka+fizyka>150 || matematyka+chemia>150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Niestety, Twoje wyniki nie są wystarczające");
            }

        }
        public static void zadanie9()
        {
            Console.WriteLine("Program sprawdza do jakiego przedziału kwalifikuje się podana temperatura.");
            Console.WriteLine("Podaj temperaturę: ");
            double temperatura = double.Parse(Console.ReadLine());
            if(temperatura<0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if(temperatura<10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else
            {
                    Console.WriteLine("A weź.. wyprowadzam się na Alaskę.");
            }    
        }
        public static void zadanie10()
        {
            Console.WriteLine("Program sprawdza czy z podanych długości boków można zbudować trójkąd");
            Console.WriteLine("Podaj boki trójkąta:");
            Console.WriteLine(" a= ");
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" b= ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(" c= ");
            c = double.Parse(Console.ReadLine());
            double suma;
            if(a>b)
            {
                if(a>c)
                {
                    suma = b + c;
                    if(suma>a)
                    {
                        Console.WriteLine("Z podanych boków można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych boków nie można zbudować trójkąta");
                    }
                }
                else
                {
                    suma = b + a;
                    if (suma > c)
                    {
                        Console.WriteLine("Z podanych boków można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych boków nie można zbudować trójkąta");
                    }
                }
            }
            else
            {
                if(b>c)
                {
                    suma = a + c;
                    if (suma > b)
                    {
                        Console.WriteLine("Z podanych boków można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych boków nie można zbudować trójkąta");
                    }
                }
                else
                {
                    suma = b + a;
                    if (suma > c)
                    {
                        Console.WriteLine("Z podanych boków można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("Z podanych boków nie można zbudować trójkąta");
                    }
                }
            }
        }

        public static void zadanie11()
        {
            Console.WriteLine("Program zamienia ocenę z liczbowej na opisową");
            Console.WriteLine("Podaj swoją ocenę");
            int ocena = int.Parse(Console.ReadLine());
            switch(ocena)
            {
                case (1):
                    {
                        Console.WriteLine("Niedostateczny");
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Dopuszczający");
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Dostateczny");
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Dobry");
                        break;
                    }
                case (5):
                    {
                        Console.WriteLine("Bardzo dobry");
                        break;
                    }
                case (6):
                    {
                        Console.WriteLine("Celujący");
                        break;
                    }
            }
        }
        public static void zadanie12()
        {
            Console.WriteLine("Program zamienia numer dnia tygodnia na jego nazwę.");
            Console.WriteLine("Podaj numer");
            int numer = int.Parse(Console.ReadLine());
            switch(numer)
            {
                case 1:
                    {
                        Console.WriteLine("Poniedziałek");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Wtorek");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Środa");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Czwartek");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Piątek");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sobota");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Niedziela");
                        break;
                    }
            }
        }

        public static void zadanie13()
        {
            Console.WriteLine("Kalkulator prosty\n");
            int opcja;
            do
            {
                double a, b;
                double wynik=0;
                Console.WriteLine("Podaj pierwszą liczbę: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj numer operacji do wykonania: \n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie\n 5. Wyjście");
                opcja = int.Parse(Console.ReadLine());
                switch(opcja)
                {
                    case 1:
                        {
                            wynik = a + b;
                            break;
                        }
                    case 2:
                        {
                            wynik = a - b;
                            break;
                        }
                    case 4:
                        {
                            if(b!=0)
                            {
                                wynik = a / b;
                            }
                            else
                            {
                                Console.WriteLine("Operacja niemożliwa do wykonania");
                            }
                            break;
                        }
                    case 3:
                        {
                            wynik = a * b;
                            break;
                        }
                }
                Console.WriteLine($"Wynik żadanej operacji to: {wynik}");
            } while (opcja == 5);
        }

    }
}
