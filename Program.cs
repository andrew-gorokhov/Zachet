using System.Xml.Linq;

namespace Zachet
{
    internal class Program
    {
        public class tovar
        {
            
            public double Counts { get; set; }
            public string Typez { get; set; }

        }
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


        static void Main(string[] args)
        {
            double summ = 0;
            Console.WriteLine("Билет №12 Задание №2");
            tovar[] Magaz = new tovar[20];
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
            Magaz[19] = new Desert(98.56);
            
            



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