using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLogci
{
    public class Logic
    {

        int[] rowRandom = new int[5];
        
        public void initGameLogic()
        {
            Random random = new Random();  //setare nr random
            rowRandom[0]= random.Next(0, 4);//setare nr random pt fiecare rand in parte
            rowRandom[1] = random.Next(5, 9);
            rowRandom[2] = random.Next(10, 14);
            rowRandom[3] = random.Next(15, 19);
            rowRandom[4] = random.Next(20, 24);
        }


        public string DoMyLogic(int buttonId)
        {

            var buttonRow = buttonId/5;   //retine nr randului de pe care e apasat butonul
            if (rowRandom[buttonRow] == buttonId)
            {
               return "X";
            }
            else
            {
                return "0";
            }
        }


        
    }
}
