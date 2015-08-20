using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Valeriya
{
    class Collections : ICollections
    {
        public LinkedList<int> CreateOrderedList(IReadOnlyList<int> input)
        {
            throw new NotImplementedException();
        }

        public List<IOutData> ProcessData(IReadOnlyList<IInData> inputData)
        {
            throw new NotImplementedException();
        }

        public int SortPotatoes(List<IPotatoe> potatoeBag, out List<IPotatoe> goodPotatoes, out List<IPotatoe> badPotatoes)
        {
            goodPotatoes = new List<IPotatoe>();
            badPotatoes = new List<IPotatoe>();
            int i = 0;
            while (potatoeBag.Count != 0)
            {
                if (potatoeBag[i].IsBad)
                {
                    badPotatoes.Add(potatoeBag[i]);
                    potatoeBag.Remove(potatoeBag[i]);
                }
                else
                {
                    goodPotatoes.Add(potatoeBag[i]);
                    potatoeBag.Remove(potatoeBag[i]);
                }
            }

            return goodPotatoes.Count;
        }
    }
}
