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
        private Boolean gg = false;
        
        public dataNShit()
        {
            first = "a";
            second = "b";
            third = "c";
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
            connectTheDots();
            
        }
        public void connectTheDots()
        {
            if(first == second && second == third && third == first)
            {
                gg = true;
            }
            
        }
        public void purge()
        {
            first = "a";
            second = "b";
            third = "c";
            gg = false;
        }
        public Boolean andTheresTheGG()
        {
            return gg;
        }

    }
}
