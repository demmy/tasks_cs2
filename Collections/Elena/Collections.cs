using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Elena
{
    class Collections:ICollections
    {
       
        public int SortPotatoes(List<IPotatoe> potatoeBag, out List<IPotatoe> goodPotatoes, out List<IPotatoe> badPotatoes)
        {
            int goodCount=0;
             badPotatoes = new List<IPotatoe>();
             goodPotatoes = new List<IPotatoe>();
            for (int i=0; i<potatoeBag.Count; i++)
            {
                if (potatoeBag[i].IsBad)
                {
                    badPotatoes.Add(potatoeBag[i]);
                    
                }

                else
                {
                    goodPotatoes.Add(potatoeBag[i]);
                  
                    goodCount++;
                }
            }
            potatoeBag.Clear();
            return goodCount;
         }

    }
}
