using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class drawBoard
    {
        string drawboardChar = " ";
        char width = '|';
        string height = "-+";
        

        static void Main(string[] args)
        {
            drawBoard db = new drawBoard();
            db.draw_board(6, 3);
            
        }

        private void draw_board(int x, int y)
        {
            //Column
            for (int j = 0; j < y *2; j++)
            {
                Console.Write("\n");
       
                //Row
                for (int i = 0; i < x; i++)
                {    
                       if (j%2 == 0)
                        {
                       Console.Write(drawboardChar + width);
                        }

                        if (j%2 == 1)
                        {
                            Console.Write(height);
                        }                    
                }

            }  
            Console.ReadLine();
        }
    }
}
