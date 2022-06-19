namespace ZadaniaWarunki
{
    class Programm
    {
        static void Main(string[] args)
        {
           
            //1
            int value1;
            int value2;

            Console.WriteLine("1. Sprawdź czy równe");
            Int32.TryParse(Console.ReadLine(), out value1);
            Int32.TryParse(Console.ReadLine(), out value2);

            if (value1 == value2)
            {
                Console.WriteLine($"{value1} i {value2} są równe");
            }
            else
            {
                Console.WriteLine($"{value1} i {value2} nie są równe");
            }

            //2   
            int value3;

            Console.WriteLine("2. Sprawdź czy parzyste");
            Int32.TryParse(Console.ReadLine(), out value3);

            if (value3 % 2 == 0)
            {
                Console.WriteLine($"{value3} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{value3} jest liczbą nieparzystą");
            }

            //3
            int value4;

            Console.WriteLine("3. Sprawdź czy ujemna");
            Int32.TryParse(Console.ReadLine(), out value4);

            if(value4 < 0)
            {
                Console.WriteLine($"{value4} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine($"{value4} jest liczbą dodatnią");
            }

            //4 
            uint year;
            
            Console.WriteLine("4. Sprawdź czy rok przestępny");
            UInt32.TryParse(Console.ReadLine(), out year);

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }

            //5
            uint age;

            Console.WriteLine("5. Sprawdź kim możesz zostać");
            UInt32.TryParse(Console.ReadLine(), out age);

            if(age < 21)
            {
                Console.WriteLine("Jesteś zbyt młody");
            }
            else if(age >= 21 && age < 31)
            {
                Console.WriteLine("Możesz zostać posłem lub premierem");
            }
            else if (age < 35)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            else if ( age >= 35 )
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            
            //6
            double height;

            Console.WriteLine("6. Sprawdź kategorię wzrostu");
            Double.TryParse(Console.ReadLine(), out height);
            

            if(height <= 20)
            {
                Console.WriteLine("Jesteś owadem");
            }
            else if (height <= 99)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if ( height <= 159)
            {
                Console.WriteLine("Jesteś knypkiem");
            }
            else if (height <= 189)
            {
                Console.WriteLine("Jesteś normalnego wzrostu");
            }
            else if(height <= 220)
            {
                Console.WriteLine("Jesteś koszykarzem");
            }
            else if (height <= 260)
            {
                Console.WriteLine("Jesteś ogrem");
            }
            else if (height > 260)
            {
                Console.WriteLine("Jesteś wielkoludem");
            }
            
            //7
            Console.WriteLine("7. Sprawdź która największa");
            int value5;
            int value6;
            int value7;

            Int32.TryParse(Console.ReadLine(), out value5);
            Int32.TryParse(Console.ReadLine(), out value6);
            Int32.TryParse(Console.ReadLine(), out value7);

            if(value5 > value6 && value5 > value7)
            {
                Console.WriteLine($"Liczba {value5} jest największa z podanych");
            }
            else if (value6 > value5 && value6 > value7)
            {
                Console.WriteLine($"Liczba {value6} jest największa z podanych");
            }
            else
            {
                Console.WriteLine($"Liczba {value7} jest największa z podanych");
            }
            
            //8
            uint mathExam;
            uint physicsExam;
            uint chemistryExam;
            bool classified;

            Console.WriteLine("8. Kwalifikacja na studia");
            Console.WriteLine("Matematyka:");
            UInt32.TryParse(Console.ReadLine(), out mathExam);
            Console.WriteLine("Fizyka:");
            UInt32.TryParse(Console.ReadLine(), out physicsExam);
            Console.WriteLine("Chemia:");
            UInt32.TryParse(Console.ReadLine(), out chemistryExam);

            if(mathExam > 70 && physicsExam > 55 && chemistryExam > 45 && (mathExam + physicsExam + chemistryExam > 180))
            {
                classified = true;
            }
            else if ((mathExam + physicsExam > 150) || (mathExam + chemistryExam > 150))
            {
                classified = true;
            }
            else
            {
                classified = false;
            }

            if(classified)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
            
            //9
            double temperature;

            Console.WriteLine("9. Odczyt temperatury");
            Double.TryParse(Console.ReadLine(), out temperature);

            if(temperature < 0)
            {
                Console.WriteLine("Cholernie piździ!");
            }
            else if (temperature < 10)
            {
                Console.WriteLine("Zimno!");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("Chłodno!");
            }
            else if (temperature < 30)
            {
                Console.WriteLine("W sam raz!");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco!");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę!");
            }
            
            //10
            uint side1;
            uint side2;
            uint side3;

            Console.WriteLine("10. Sprawdź czy trójkąt");
            UInt32.TryParse(Console.ReadLine(), out side1);
            UInt32.TryParse(Console.ReadLine(), out side2);
            UInt32.TryParse(Console.ReadLine(), out side3);

            if((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side2 > side3))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
            
            //11
            uint mark;
            Console.WriteLine("11. Zmień na ocene słowną");
            UInt32.TryParse(Console.ReadLine(), out mark);

            switch(mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Błędna ocena");
                    break;
            }
           
            //12
            uint day;
            Console.WriteLine("12. Zmień liczbę na dzień tygodnia");
            UInt32.TryParse(Console.ReadLine(), out day);
            switch(day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedzielka");
                    break;
                default :
                    Console.WriteLine("Błędna liczba dania tygodnia");
                    break;
            }
          
            //13
            int value8;
            int value9;
            double result = 0;

            Console.WriteLine("13. Kalkulator");
            Console.WriteLine("Podaj pierwszą liczbę:");
            Int32.TryParse(Console.ReadLine(), out value8);
            Console.WriteLine("Podaj drugą liczbę:");
            Int32.TryParse(Console.ReadLine(), out value9);
            Console.WriteLine("Podaj numer operacji do wykonania:\r\n1.Dodawanie\r\n2.Odejmowanie\r\n3.Mnożenie\r\n4.Dzielenie");

           
            switch(Console.ReadLine())
            {
                case "1":
                    result = value8 + value9;
                    break;
                case "2":
                    result = value8 - value9;
                    break;
                case "3":
                    result = value8 * value9;
                    break;
                case "4":
                    if(value9 != 0)
                    {
                        result = (double)value8 / value9;
                    }
                    else
                    {
                        Console.WriteLine("Pamiętaj cholero nie dziel przez zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Podano błędną wartość operacji");
                    break;
            }
            Console.WriteLine($"Twój wynik to: {result}");

        }
    }
}
