using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterService converter = new ConverterService();
            bool main = true;
            while (main)
            {
                main = huvudMeny();
            }

        }
        public static bool huvudMeny()
        {
            int meny;
            Console.WriteLine("\nTryck 1 för att hantera elektricitet.  ");
            Console.WriteLine("Tryck 2 för att hantera hastighet.  ");
            Console.WriteLine("Tryck 3 för att hantera temperatur.  ");
            Console.WriteLine("Tryck 4 för att hantera volym i vätska.  ");
            Console.WriteLine("Tryck 5 för att konvertera tid.  ");
            Console.WriteLine("Tryck 6 för att konvertera diameter/radius från area.  ");
            Console.WriteLine("Tryck 7 för att avsluta.");

            while (!int.TryParse(Console.ReadLine(), out meny))
            {
                Console.WriteLine("värdet kan inte hanteras");
            }
            switch (meny)
            {
                case 1:
                    {
                        mainMenyEl();
                        return true;

                    }

                case 2:
                    {
                        mainMenyHastighet();
                        return true;
                    }

                case 3:
                    {
                        mainMenyTemp();
                        return true;
                    }

                case 4:
                    {
                        mainMenyLiquid();
                        return true;
                    }

                case 5:
                    {
                        mainMenyTid();
                        return true;
                    }
                case 6:
                    {
                        mainMenyArea();
                        return true;
                    }

                case 7:
                    {
                        return false;
                    }
                default:
                    return true;

            }


        }

        static void menyVolt()
        {
            ConverterService converter = new ConverterService();
            Console.WriteLine("Skriv in antalet resistans:");
            float res = 0;
            while (!float.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }


            Console.WriteLine("Skriv in antalet ampere:");
            float amp = 0;
            while (!float.TryParse(Console.ReadLine(), out amp))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }


            float inputVoltage = converter.CalculateVoltage(res, amp);


            Console.WriteLine("Resultatet är följande, dina värden blir {0} mycket Volt.", inputVoltage);

        }
        static void menyResistans()
        {
            ConverterService converter = new ConverterService();
            Console.WriteLine("Skriv in antalet Volt:");
            float resVolt = 0;
            while (true)
            {
                try
                {
                    resVolt = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Fel input, try again.");
                    continue;
                }
                break;
            }

            Console.WriteLine("Skriv in antalet ampere:");
            float resAmp = 0;
            while (true)
            {
                try
                {
                    resAmp = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Fel input, try again.");
                    continue;
                }
                break;
            }


            float inputResistance = converter.CalculateResistance(resVolt, resAmp);


            Console.WriteLine("Resultatet är följande, dina värden blir {0} mycket Volt.", inputResistance);
        }
        static void menyAmpere()
        {
            ConverterService converter = new ConverterService();
            Console.WriteLine("Skriv in antalet resistans:");
            float ampRes = 0;
            while (!float.TryParse(Console.ReadLine(), out ampRes))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }


            Console.WriteLine("Skriv in antalet Volt:");
            float ampVolt = 0;
            while (!float.TryParse(Console.ReadLine(), out ampVolt))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            float inputAmpere = converter.CalculateAmps(ampVolt, ampRes);


            Console.WriteLine("\nResultatet är följande, dina värden blir {0} mycket ampere.", inputAmpere);
        }

        static void menySpeed()
        {
            ConverterService converter = new ConverterService();

            float time = 0, distans = 0;
            Console.WriteLine("skriv in distans i meter");
            while (!float.TryParse(Console.ReadLine(), out distans))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("skriv in tid");
            while (!float.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            float inputSpeed = converter.CalculateSpeed(time, distans);

            Console.WriteLine("Resultat är följande, du har färdats i {0} mps", inputSpeed);

        }
        static void menyTravelTime()
        {
            ConverterService converter = new ConverterService();

            float speed = 0, distance = 0;
            Console.WriteLine("skriv in distans i meter");
            while (!float.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("skriv in hastighet i mps");
            while (!float.TryParse(Console.ReadLine(), out speed))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            float inputTime = converter.CalculateTravelTime(distance, speed);

            Console.WriteLine("Resultat är följande, du har färdats i {0} sekunder", inputTime);
        }
        static void menyTraveledDistance()
        {
            ConverterService converter = new ConverterService();

            float time = 0, speed = 0;
            Console.WriteLine("skriv in hastighet mps");
            while (!float.TryParse(Console.ReadLine(), out speed))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            Console.WriteLine("skriv in sekunder som det har tagit");
            while (!float.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            float inputDistance = converter.CalculateTraveledDistance(time, speed);

            Console.WriteLine("Du har färdats i {0} meter", inputDistance);
        }

        static void menyGallonToLiter()
        {
            float gallon;
            ConverterService converter = new ConverterService();
            Console.WriteLine("Skriv in vätskan i gallons");
            while (!float.TryParse(Console.ReadLine(), out gallon)) ;

            float inputGallon = converter.ConvertFromGallonToLiter(gallon);

            Console.WriteLine("vätskan är {0} liter", inputGallon);
        }
        static void menyLiterToGallon()
        {
            float liter;
            ConverterService converter = new ConverterService();
            Console.WriteLine("Skriv in vätskan i gallons");
            while (!float.TryParse(Console.ReadLine(), out liter)) ;

            float inputLiter = converter.ConvertFromGallonToLiter(liter);

            Console.WriteLine("vätskan är {0} gallons", inputLiter);
        }
        static void menyCelciusToFahrenheit()

        {
            ConverterService converter = new ConverterService();

            float celcius = 0;
            Console.WriteLine("Skriv antal grader Celcius du vill konvertera i grader Fahrenheit");
            while (!float.TryParse(Console.ReadLine(), out celcius))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }
            float Fahrenheit = converter.ConvertCelciusToFahrenheit(celcius);
            Console.WriteLine("Från Celsius blir det {0} Fahrenheit.", Fahrenheit);
        }

        static void menyFahrenheitToCelcius()
        {
            ConverterService converter = new ConverterService();

            float fahrenheit = 0;
            Console.WriteLine("Skriv antal grader fahrenheit du vill konvertera i grader Celcius");
            while (!float.TryParse(Console.ReadLine(), out fahrenheit))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }

            float celcius = converter.ConvertFahrenheitToCelcius(fahrenheit);
            Console.WriteLine("Från Fahrenheit blir det {0} Celsius.", celcius);
        }
        static void menyHoursToMinutes()
        {
            ConverterService converter = new ConverterService();

            float hours;
            Console.WriteLine("Skrin in antal timmar du vill konvertera till minuter");
            while (!float.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }
            float inputMinutes = converter.ConvertFromHoursToMinutes(hours);
            Console.WriteLine("det har gått {0} minuter.", inputMinutes);
        }
        static void menyMinutesToHours()
        {
            float minutes;
            ConverterService converter = new ConverterService();

            Console.WriteLine("Skriv in hur många minuter som ska konverteras till timmar");
            while (!float.TryParse(Console.ReadLine(), out minutes)) ;

            float inputHours = converter.ConvertFromMinutesToHours(minutes);

            Console.WriteLine("det har gått {0} timmar", inputHours);
        }
        static void menyDiameterFromArea()
        {
            ConverterService converter = new ConverterService();

            float area;
            Console.WriteLine("Skrin in diameter du vill ränka till area");
            while (!float.TryParse(Console.ReadLine(), out area))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }
            float newDiameter = converter.CalculateDiameterFromArea(area);
            Console.WriteLine("Diameter av den benämda arean är {0}  ", newDiameter, area);
        }
        static void menyRadiusFromArea()
        {
            ConverterService converter = new ConverterService();

            float radius;
            Console.WriteLine("Skriv in arean du vill konvertera till radius");
            while (!float.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }
            float newRadius = converter.CalculateRadiusFromArea(radius);
            Console.WriteLine("Radien är {0}", newRadius);
        }
        static bool mainMenyEl()
        {
            int menyEl;

            Console.WriteLine("\nTryck 1 för att konvertera resistans och ampere till Volt. ");
            Console.WriteLine("Tryck 2 för att konvertera resistans och Volt till ampere. ");
            Console.WriteLine("Tryck 3 för att konvertera Volt och ampere till resistans. ");
            Console.WriteLine("Tryck 4 för att gå tillbaka ");

            Console.WriteLine("Tryck 5 för att avsluta.");
            while (!int.TryParse(Console.ReadLine(), out menyEl))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }

            switch (menyEl)

            {


                case 1:
                    {
                        menyVolt();
                        return true;
                    }


                case 2:
                    {
                        menyAmpere();
                        return true;
                    }

                case 3:
                    {
                        menyResistans();
                        return true;
                    }
                case 4:
                    {
                        huvudMeny();
                        return true;
                    }
                case 5:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }
            }
        }

        static bool mainMenyHastighet()
        {
            int menySan;
            Console.WriteLine("Skriv in siffran för den funktionen som du vill använda");
            Console.WriteLine("1. Medelhastighet");
            Console.WriteLine("2. distans");
            Console.WriteLine("3. tid det tar att färda distans i sekunder");
            Console.WriteLine("4. gå tillbaka");
            Console.WriteLine("5. för att avsluta");

            while (!int.TryParse(Console.ReadLine(), out menySan))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            switch (menySan)
            {
                case 1:
                    {
                        menySpeed();
                        return true;
                    }
                case 2:
                    {
                        menyTraveledDistance();
                        return true;
                    }
                case 3:
                    {
                        menyTravelTime();
                        return true;
                    }
                case 4:
                    {
                        huvudMeny();
                        return true;
                    }
                case 5:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }
            }
        }

        static bool mainMenyLiquid()
        {
            int menyLiquid;

            Console.WriteLine("\nTryck 1 för att konvertera Gallon till Liter. ");
            Console.WriteLine("Tryck 2 för att konvertera Liter till Gallon. ");
            Console.WriteLine("Tryck 3 för att återvända till menyn.");
            Console.WriteLine("Tryck 4 för att avsluta.");
            while (!int.TryParse(Console.ReadLine(), out menyLiquid))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            switch (menyLiquid)
            {
                case 1:
                    {
                        menyGallonToLiter();
                        return true;
                    }

                case 2:
                    {
                        menyLiterToGallon();
                        return true;
                    }

                case 3:
                    {
                        huvudMeny();
                        return true;
                    }
                case 5:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }

            }


        }
        public static bool mainMenyTemp()
        {
            ConverterService converter = new ConverterService();
            int menyTemp;
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1: Celcius till Fahrenheit");
            Console.WriteLine("2: Fahrenheit till Celcius");
            Console.WriteLine("3: Återgå till huvudmeny");
            Console.WriteLine("4: stäng ner");

            while (!int.TryParse(Console.ReadLine(), out menyTemp))
            {
                Console.WriteLine("Värdet kan inte hanteras, försök igen");
            }
            switch (menyTemp)

            {
                case 1:
                    {
                        menyCelciusToFahrenheit();
                        return true;
                    }

                case 2:
                    {
                        menyFahrenheitToCelcius();
                        return true;
                    }
                case 3:
                    {
                        huvudMeny();
                        return true;
                    }
                case 4:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }
            }
        }
        static bool mainMenyTid()
        {
            int menySan;
            Console.WriteLine("Skriv in siffran för den funktionen som du vill använda");
            Console.WriteLine("1. Konvertera minuter till Timmar.");
            Console.WriteLine("2. Konvertera Timmar till minuter.");
            Console.WriteLine("3. för att återvända till huvudmenyn.");
            Console.WriteLine("4. avsluta programet");

            while (!int.TryParse(Console.ReadLine(), out menySan))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            switch (menySan)
            {
                case 1:
                    {
                        menyMinutesToHours();
                        return true;
                    }
                case 2:
                    {
                        menyHoursToMinutes();
                        return true;
                    }
                case 3:
                    {
                        huvudMeny();
                        return true;
                    }
                case 4:
                    {
                        return false;
                    }

                default:
                    {
                        return true;
                    }
            }
        }
        static bool mainMenyArea()
        {
            int menyArea;

            Console.WriteLine("\nTryck 1 för att konvertera area till Diameter. ");
            Console.WriteLine("Tryck 2 för att konvertera area till Radie. ");
            Console.WriteLine("Tryck 3 för att återvända till menyn.");
            Console.WriteLine("Tryck 4 för att avsluta.");
            while (!int.TryParse(Console.ReadLine(), out menyArea))
            {
                Console.WriteLine("Värdet kan inte hanteras försök igen");
            }
            switch (menyArea)
            {


                case 1:
                {
                    menyDiameterFromArea();
                    return true;
                }
                case 2:
                {
                    menyRadiusFromArea();
                    return true;
                }
                case 3:
                {
                    huvudMeny();
                    return true;
                }
                case 4:
                {
                    return false;
                }
                default:
                {
                    return true;
                }
            }
        }
    }
}

