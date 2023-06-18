using System;
using System.Collections.Generic;

namespace Project
{
    public class DieRoller
    {
        private int DieSelected;
       
        private int NumberRolled;
        private bool rollingDie;
        static void Main()
        {
            var DieRollerClass = new DieRoller();
            DieRollerClass.rollingDie = true;
            DieRollerClass.RollDie();
            
        }

        public void RollDie()
        {
            while(rollingDie == true)
            {
                Console.WriteLine("\npick a die 2-100\n");

                string DieSelectedString;
                DieSelectedString = Console.ReadLine() + "";

                DieSelected  = Convert.ToInt32(DieSelectedString);
                if(DieSelected < 2) DieSelected = 2;
                if(DieSelected > 100) DieSelected = 100;
            
                Random randint = new Random();
                NumberRolled = randint.Next(1,DieSelected+1);

                if(NumberRolled < 11) Console.WriteLine("\nYou rolled a " + NumberRolled + "!\n\n");
                else Console.WriteLine("\nYou rolled an " + NumberRolled + "!\n\n");

                Console.WriteLine("Press 1 to exit \npress 2 to reroll\n");

                string exitString; 
                exitString = Console.ReadLine() + "";
                if(exitString != "2") rollingDie = false;
                else rollingDie = true;

                if(rollingDie == false)
                {
                    return;
                }   
            }
        }
    }
}
