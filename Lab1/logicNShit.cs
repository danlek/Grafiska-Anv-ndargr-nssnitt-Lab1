using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class logicNShit
    {
        //dataz arrayn ska innehålla dem 8 olika strategier för vinst
        //i spelet. 
        //0 = row1
        //1 = row2
        //2 = row3
        //3 = col1
        //4 = col2
        //5 = col3
        //6 = diag1
        //7 = diag2
        private dataNShit[] dataz;
        private int turn = 1;
        private Form1 F1;
        private int counter = 0;
        public logicNShit(Form1 F)
        {
            F1 = F;
            dataz = new dataNShit[8];
            for (int i = 0; i < dataz.Length; i++)
            {
                   dataz[i] = new dataNShit(this);
            }
        }
        public String gameLogic(int vilkenKnapp, String knappTexten)
        {
            String answer = " ";
            if (knappTexten == " ")
            {
                if (turn == 1)
                {
                    answer = "O";
                    switch (vilkenKnapp)
                    {
                        case 0:
                            dataz[0].setDataNShit("O", 1);
                            
                            dataz[3].setDataNShit("O", 1);
                            
                            dataz[6].setDataNShit("O", 1);
                            
                            break;
                        case 1:
                            dataz[0].setDataNShit("O", 2);
                            
                            dataz[4].setDataNShit("O", 1);
                            
                            break;
                        case 2:
                            dataz[0].setDataNShit("O", 3);
                            
                            dataz[5].setDataNShit("O", 1);
                            
                            dataz[7].setDataNShit("O", 1);
                            
                            break;
                        case 3:
                            dataz[1].setDataNShit("O", 1);
                            
                            dataz[3].setDataNShit("O", 2);
                            
                            break;
                        case 4:
                            dataz[1].setDataNShit("O", 2);
                            
                            dataz[4].setDataNShit("O", 2);
                            
                            dataz[6].setDataNShit("O", 2);
                            
                            dataz[7].setDataNShit("O", 2);
                            
                            break;
                        case 5:
                            dataz[1].setDataNShit("O", 3);
                            
                            dataz[5].setDataNShit("O", 2);
                            
                            break;
                        case 6:
                            dataz[2].setDataNShit("O", 1);
                            
                            dataz[3].setDataNShit("O", 3);
                            
                            dataz[7].setDataNShit("O", 3);
                            
                            break;
                        case 7:
                            dataz[2].setDataNShit("O", 2);
                            
                            dataz[4].setDataNShit("O", 3);
                            
                            break;
                        case 8:
                            dataz[2].setDataNShit("O", 3);
                            
                            dataz[5].setDataNShit("O", 3);
                            
                            dataz[6].setDataNShit("O", 3);
                            
                            break;
                    }

                }
                else
                {
                    answer = "X";
                    switch (vilkenKnapp)
                    {
                        case 0:
                            dataz[0].setDataNShit("X", 1);
                            
                            dataz[3].setDataNShit("X", 1);
                            
                            dataz[6].setDataNShit("X", 1);
                            
                            break;
                        case 1:
                            dataz[0].setDataNShit("X", 2);
                            
                            dataz[4].setDataNShit("X", 1);
                            
                            break;
                        case 2:
                            dataz[0].setDataNShit("X", 3);
                            
                            dataz[5].setDataNShit("X", 1);
                            
                            dataz[7].setDataNShit("X", 1);
                            
                            break;
                        case 3:
                            dataz[1].setDataNShit("X", 1);
                            
                            dataz[3].setDataNShit("X", 2);
                            
                            break;
                        case 4:
                            dataz[1].setDataNShit("X", 2);
                            
                            dataz[4].setDataNShit("X", 2);
                            
                            dataz[6].setDataNShit("X", 2);
                            
                            dataz[7].setDataNShit("X", 2);
                            
                            break;
                        case 5:
                            dataz[1].setDataNShit("X", 3);
                            
                            dataz[5].setDataNShit("X", 2);
                            
                            break;
                        case 6:
                            dataz[2].setDataNShit("X", 1);
                            
                            dataz[3].setDataNShit("X", 3);
                            
                            dataz[7].setDataNShit("X", 3);
                            
                            break;
                        case 7:
                            dataz[2].setDataNShit("X", 2);
                            
                            dataz[4].setDataNShit("X", 3);
                            
                            break;
                        case 8:
                            dataz[2].setDataNShit("X", 3);
                            
                            dataz[5].setDataNShit("X", 3);
                            
                            dataz[6].setDataNShit("X", 3);
                            
                            break;
                    }

                }
                counter++;
                isDraw();
                turn = turn * (-1);
            }
            else 
            {
                answer = " ";
            }
            return answer;
        }
        public void Reset()
        {
            for (int j = 0; j < dataz.Length; j++)
            {
                dataz[j].purge();
            }
            turn = 1;
        }
        
        public void GG()
        {
            if (turn == 1)
            {
                F1.inactivateButtons();
                F1.changeText("Game Over\nO vinner!");
            }
            else 
            {
                F1.inactivateButtons();
                F1.changeText("Game Over\nX vinner!");
            }
        }
        public void isDraw()
        { 
            //Kollar så det är inte oavgjort
            if (counter == 9)
            {
                F1.inactivateButtons();
                F1.changeText("Game Over\nOavgjort!");
            }

        }
       
    }
}
