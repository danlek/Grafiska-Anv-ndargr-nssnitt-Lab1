using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class dataNShit
    {
        private String first;
        private String second;
        private String third;
        private logicNShit logic;

        public dataNShit(logicNShit L)
        {
            first = "a";
            second = "b";
            third = "c";
            logic = L;
        }
        public void setDataNShit(String data, int whichOne)
        { 
            switch(whichOne)
            {
                case 1:
                    first = data;
                    break;
                case 2:
                    second = data;
                    break;
                case 3:
                    third = data;
                    break;
            }  
        }
        public Boolean connectTheDots()
        {
            Boolean connected = false;
            if (first == second && second == third)
            {
                connected = true;
            }
            return connected;
        }
        
        public void purge()
        {
            first = "a";
            second = "b";
            third = "c";
        }
    }
}
