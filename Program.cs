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

            Console.WriteLine("\x2AStart game\x2A\n________\nstart:s\n|______|\nquit:q\n|______|");
       

        
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
                      sim = false;
               
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

               Console.ReadKey();
               Console.ReadLine();
                //anthony is now on the repository




            }
        }
    }
}

