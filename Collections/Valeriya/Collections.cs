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
            List<IOutData> sensorsAverage = new List<IOutData>();
            List<int> codesOfSensors = new List<int>();
            List<int> sumsFromSensors = new List<int>();
            List<int> countOfValuesFromEachSensor = new List<int>();
            int indexOfSensor = 0;
            int count = inputData.Count;
            for (int i = 0; i < count - 1; i++)
            {
                if (inputData[i].IsValid == true)
                {
                    if (inputData[i].Code == inputData[i + 1].Code)
                    {
                        codesOfSensors[indexOfSensor] = inputData[i].Code;
                        sumsFromSensors[indexOfSensor] += inputData[i].Value;
                        countOfValuesFromEachSensor[indexOfSensor]++;
                    }
                    else
                    {
                        sumsFromSensors[indexOfSensor] += inputData[i].Value;
                        countOfValuesFromEachSensor[indexOfSensor]++;
                        indexOfSensor++;
                    }
                }
            }
            if (inputData[count - 2].Code == inputData[count - 1].Code && inputData[count - 1].IsValid)
            {
                codesOfSensors[indexOfSensor] = inputData[count - 1].Code;
                sumsFromSensors[indexOfSensor] += inputData[count - 1].Value;
                countOfValuesFromEachSensor[indexOfSensor]++;
            }
            else
            {
                sumsFromSensors[indexOfSensor] += inputData[count - 1].Value;
                countOfValuesFromEachSensor[indexOfSensor]++;
            }

            return sensorsAverage;
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
