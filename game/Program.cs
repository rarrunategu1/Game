using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class drawBoard
    {
        //string drawboardChar = " ";
        char width = '|';
        char height = '-';
        

        static void Main(string[] args)
        {
            drawBoard db = new drawBoard();
            db.draw_board(6, 3);
            
        }

        private void draw_board(int x, int y)
        {
            //Column
            for (int j = 0; j < y; j++)
            {
               
                string widthPrint = new String(width ,x);
                string rowPrint = new String(height, x);
                
                Console.WriteLine(widthPrint);
                Console.WriteLine(rowPrint);
                
                //Row
                for (int i = 0; i < x; i++)
                {    
                       // string widthPrint = new String(width ,x);
                       // string rowPrint = new string('-', y);
                       // Console.WriteLine(widthPrint);
                       // Console.WriteLine(rowPrint);
                        //Console.ReadLine();
                        
                    
                }
                //Console.ReadLine();

            }  
            Console.ReadLine();
        }


    }
}
