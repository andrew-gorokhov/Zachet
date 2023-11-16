using System.Xml.Linq;

namespace Zachet
{
    internal class Program
    {
        public class tovar
        {
            public string Name { get; set; }
            public double Counts { get; set; }
            public string Typez { get; set; }

        }
        /*
        public class Napitok : tovar 
        {
            public Napitok(double counts) : base()  
            {
               
                Counts = counts;
                Typez = "Напитки";

            }
        }
        public class Fruit : tovar
        {
            public Fruit(double counts) : base()
            {

                Counts = counts;
                Typez = "Фрукты";

            }
        }

        public class Ovoch : tovar
        {
            public Ovoch(double counts) : base()
            {

                Counts = counts;
                Typez = "Овощи";

            }
        }
        public class Meet : tovar
        {
            public Meet(double counts) : base()
            {

                Counts = counts;
                Typez = "Мясо";

            }
        }
        public class Desert : tovar
        {
            public Desert(double counts) : base()
            {
              
                Counts = counts;
                Typez = "Десерты";

            }
        }
        */

        static void Main(string[] args)
        {
            double summ = 0;
            Console.WriteLine("Билет №12 Задание №2");
            /* tovar[] Magaz = new tovar[20];
             Magaz[0] = new Napitok(25.6);
             Magaz[1] = new Napitok(250.6);
             Magaz[2] = new Napitok(225.6);
             Magaz[3] = new Napitok(254.6);
             Magaz[4] = new Napitok(285.6);
             Magaz[5] = new Fruit(105);
             Magaz[6] = new Fruit(125);
             Magaz[7] = new Fruit(135);
             Magaz[8] = new Fruit(165);
             Magaz[9] = new Fruit(175);
             Magaz[10] = new Fruit(156.99);
             Magaz[11] = new Ovoch(15.99);
             Magaz[12] = new Ovoch(26.35);
             Magaz[13] = new Ovoch(56.89);
             Magaz[14] = new Ovoch(99.99);
             Magaz[15] = new Meet(569.99);
             Magaz[16] = new Meet(199.69);
             Magaz[17] = new Desert(250.68);
             Magaz[18] = new Desert(569.56);
             Magaz[19] = new Desert(98.56);*/

            tovar[] Magaz =
            {
                new tovar{Name = "Орео", Typez = "Десерт", Counts = 250.36},
                new tovar{Name = "Вафли", Typez = "Десерт", Counts = 240.56},
                new tovar { Name = "Торт", Typez = "Десерт", Counts = 245.96 },
                new tovar { Name = "Сырок", Typez = "Десерт", Counts = 20.5 },
                new tovar { Name = "Батончик", Typez = "Десерт", Counts = 29.99 },
                new tovar { Name = "Тортелло", Typez = "Десерт", Counts = 199.99},
                new tovar{Name = "Квас", Typez = "Напиток", Counts = 99.99},
                new tovar { Name = "Лимонад", Typez = "Напиток", Counts = 69.99 },
                new tovar { Name = "Тархун", Typez = "Напиток", Counts = 129.99 },
                new tovar { Name = "Чай", Typez = "Напиток", Counts = 169.99 },
                new tovar { Name = "Крюшон", Typez = "Напиток", Counts = 139.99 },
                new tovar { Name = "Вода газированная", Typez = "Напиток", Counts = 49.99 },
                new tovar { Name = "Говядина", Typez = "Мясо", Counts = 499.69 },
                new tovar { Name = "Свинина", Typez = "Мясо", Counts = 399.69 },
                new tovar { Name = "Курица", Typez = "Мясо", Counts = 199.69 },
                new tovar { Name = "Щука", Typez = "Рыба", Counts = 899.69 },
                new tovar { Name = "Картошка", Typez = "Овощ", Counts = 29.50 },
                new tovar { Name = "Томат", Typez = "Овощ", Counts = 129.70 },
                new tovar { Name = "Мандарин", Typez = "Фрукт", Counts = 229.50 },
                new tovar { Name = "Яблоко", Typez = "Фрукт", Counts = 99.50 }

            };





            foreach (tovar number in Magaz)
            {
                if (number != null)
                {
                    summ += number.Counts;
                }
                
            }
            Console.WriteLine(summ);
            List <string> typeees = new List<string> { };
            int value = 0;
            
            double sred = summ / Magaz.Length;
            foreach (tovar number in Magaz)
            {
                
                if (number.Counts < sred)
                {
                    if (number != null)
                    {
                        typeees.Add(number.Typez);
                        
                    }
                    
                }
            }
            

            Console.WriteLine("Количество видов товаров с ценой меньше среднего " +  typeees.Count);

            HashSet<string> typeez = new HashSet<string>(typeees);
            

            Console.WriteLine("Количество видов товаров с ценой меньше среднего без повторов " + typeez.Count);







        }
    }
}