using System;


namespace datingsimverz1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            /*
             main menu to start game

            intro sequence saying hello giving you your bio


             
             
             
             */




            bool sim = true;
            Char firstanswr;
            Console.WriteLine("Dating simulator build: 0.5\t\n");
            Console.WriteLine("Start game\nstart:s\nquit:q");
        
        
            firstanswr = Console.ReadKey().KeyChar;
            //if (firstanswr == 's' || firstanswr == 'S')
            //{
            //     sim=true;
            //}
            //else 
            if (firstanswr == 'q' || firstanswr == 'Q')
            {
                sim = false;

            }
            else if (firstanswr != 's' && firstanswr != 'S')
            {
                Console.WriteLine("\nthats not an authorized  answer");
                Console.ReadKey();
            }
            if (sim)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n_______|C-Team dating simulator|_______");
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("   ___________________________________");
                       Console.ReadLine();


                    // break;


                } while (sim);

                _ = Console.ReadKey();
                _ = Console.ReadLine();
                //anthony is now on the repository




            }
        }
    }
}

