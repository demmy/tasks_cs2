﻿using System;
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
            List<IInData> onlyValidFromInputData = new List<IInData>();
            List<int> codesOfSensors = new List<int>();
            List<double> sumsFromSensors = new List<double>();
            List<int> countOfValuesFromEachSensor = new List<int>();

            for (int i = 0; i < inputData.Count; i++)
            {
                if (inputData[i].IsValid == true)
                {
                    onlyValidFromInputData.Add(inputData[i]);
                }
            }

            int count = onlyValidFromInputData.Count;

            for (int i = 0; i < count - 1; i++)
            {
                    if (onlyValidFromInputData[i].Code == onlyValidFromInputData[i + 1].Code)
                    {
                        codesOfSensors.Add (onlyValidFromInputData[i].Code);
                        sumsFromSensors.Add(onlyValidFromInputData[i].Value);
                        countOfValuesFromEachSensor.Add(1);
                    }
                    else
                    {
                        if (codesOfSensors.Contains(onlyValidFromInputData[i].Code))
                        {
                            sumsFromSensors[codesOfSensors.IndexOf(onlyValidFromInputData[i].Code)] += onlyValidFromInputData[i].Value;
                            countOfValuesFromEachSensor[codesOfSensors.IndexOf(onlyValidFromInputData[i].Code)] += 1;
                        }
                        else
                        {
                            codesOfSensors.Add(onlyValidFromInputData[i].Code);
                            sumsFromSensors.Add(onlyValidFromInputData[i].Value);
                            countOfValuesFromEachSensor.Add(1);
                        }
                    }
            }
            if (onlyValidFromInputData[count - 2].Code == onlyValidFromInputData[count - 1].Code)
            {
                sumsFromSensors[codesOfSensors.IndexOf(onlyValidFromInputData[count - 1].Code)] += onlyValidFromInputData[count - 1].Value;
                countOfValuesFromEachSensor[codesOfSensors.IndexOf(onlyValidFromInputData[count - 1].Code)] += 1;
            }
            else
            {
                if (codesOfSensors.Contains(onlyValidFromInputData[count - 1].Code))
                {
                    sumsFromSensors[codesOfSensors.IndexOf(onlyValidFromInputData[count - 1].Code)] += onlyValidFromInputData[count - 1].Value;
                    countOfValuesFromEachSensor[codesOfSensors.IndexOf(onlyValidFromInputData[count - 1].Code)]++;
                }
                else
                {
                    codesOfSensors.Add(onlyValidFromInputData[count - 1].Code);
                    sumsFromSensors.Add(onlyValidFromInputData[count - 1].Value);
                    countOfValuesFromEachSensor.Add(1);
                }
            }

            for (int i = 0; i < sumsFromSensors.Count; i++)
            {
                sensorsAverage.Add(new OutData(codesOfSensors[i], sumsFromSensors[i] / countOfValuesFromEachSensor[i])); 
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
