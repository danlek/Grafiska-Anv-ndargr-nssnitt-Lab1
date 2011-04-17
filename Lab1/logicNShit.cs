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
        private Form1 F1;
        private int counter = 0;
        public logicNShit(Form1 F)
        {
            F1 = F;
            dataz = new dataNShit[8];
            for (int i = 0; i < dataz.Length; i++)
            {
                   dataz[i] = new dataNShit();
            }
        }
        public String gameLogic(int vilkenKnapp, String knappTexten)
        {
            String texten = knappTexten;
            
            if (knappTexten == " ")
            {
                if (counter % 2 == 0)
                {
                    texten = "O";
                }
                else
                {
                    texten = "X";
                }
                switch (vilkenKnapp)
                {
                    case 0:
                        dataz[0].setDataNShit(texten, 1);

                        dataz[3].setDataNShit(texten, 1);

                        dataz[6].setDataNShit(texten, 1);

                        isDraw("036");

                        break;
                    case 1:
                        dataz[0].setDataNShit(texten, 2);

                        dataz[4].setDataNShit(texten, 1);

                        isDraw("04");

                        break;
                    case 2:
                        dataz[0].setDataNShit(texten, 3);

                        dataz[5].setDataNShit(texten, 1);

                        dataz[7].setDataNShit(texten, 1);

                        isDraw("057");

                        break;
                    case 3:
                        dataz[1].setDataNShit(texten, 1);

                        dataz[3].setDataNShit(texten, 2);

                        isDraw("13");

                        break;
                    case 4:
                        dataz[1].setDataNShit(texten, 2);

                        dataz[4].setDataNShit(texten, 2);

                        dataz[6].setDataNShit(texten, 2);

                        dataz[7].setDataNShit(texten, 2);

                        isDraw("1467");

                        break;
                    case 5:
                        dataz[1].setDataNShit(texten, 3);

                        dataz[5].setDataNShit(texten, 2);

                        isDraw("15");

                        break;
                    case 6:
                        dataz[2].setDataNShit(texten, 1);

                        dataz[3].setDataNShit(texten, 3);

                        dataz[7].setDataNShit(texten, 3);

                        isDraw("237");

                        break;
                    case 7:
                        dataz[2].setDataNShit(texten, 2);

                        dataz[4].setDataNShit(texten, 3);

                        isDraw("24");

                        break;
                    case 8:
                        dataz[2].setDataNShit(texten, 3);

                        dataz[5].setDataNShit(texten, 3);

                        dataz[6].setDataNShit(texten, 3);

                        isDraw("256");

                        break;
                }
                counter++;
            }
            else 
            {

            }
            return texten;
        }
        public void Reset()
        {
            for (int j = 0; j < dataz.Length; j++)
            {
                dataz[j].purge();
            }
            counter = 0;
        }
        
        public void GG()
        {
            if (counter%2 == 0)
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
        public void isDraw(String vilkaIndex)
        { 
            Boolean connected = false;
            for (int i = 0; i < vilkaIndex.Length; i++)
            {
                int a = int.Parse(Convert.ToString(vilkaIndex[i]));
                connected = dataz[a].connectTheDots();
                if (connected == true)
                {
                    GG();
                    break;
                }
            }
            Boolean isFull = F1.isFull();
            if (counter == 8 && connected == false)
            {
                Draw();
            }
        }
        public void Draw()
        {
            F1.inactivateButtons();
            F1.changeText("Game Over\nOavgjort!");
        }
       
    }
}
