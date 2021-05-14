using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Train
    {
        private List<Wagon> listWagons;

        public Train()
        {
            
        }
        
        public void AddWagon()
        {

            listWagons.Add(new Wagon());
            
        }
    }
}
