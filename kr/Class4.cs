using System;
using System.Collections.Generic;
using System.Text;

namespace kr
{
    class ShowCorrectWeightRatio
    {
        private int _number;
        public int GetWeight
        {
            set
            {
                _number = value;
            }
        }
        private int _numbertwo;
        public int GetGrowth
        {
            set
            {
                _numbertwo = value;
            }
            
        }
        public string ShowWeight
        {
            get
            {
                double index = (double)_numbertwo / (((double)_number * (double)_number) /10000) ;
                if (index < 18.5)
                {
                    return "Дефицит массы тела";
                }
                else if ((index >= 18.5) && (index < 25))
                {
                    return "Норма" ;
                }
                else
                {
                    return "Избыточная масса тела" ;
                }
            }
        }

    }
}
