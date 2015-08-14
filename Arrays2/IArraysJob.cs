﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    interface IArraysJob
    {
        /// <summary>
        /// 	 Дан двумерный массив с разной длиной строк. Определите,
        /// 	 есть ли в массиве ещё одна строка с такой же длиной, 
        /// 	 как первая строка, и если есть, то поменяйте местами 
        /// 	 все элементы первой строки со всеми элементами найденной строки.
        /// </summary>
        /// <param name="inputArray">входной массив</param>
        /// <returns>возвращается статус: был ли факт обмена строк</returns>
        bool JaggedArrayExchange(int[][] inputArray);

        /// <summary>
        /// 	Дан прямоугольный массив целых чисел размером 5 на 10.
        /// 	Заполните его значениями 0 и 1 в случайном порядке и выведите на экран.
        /// 	Дальше обработайте массив таким образом:
        /// 	для каждого элемента если в элементе 1 
        /// 	и сумма всех окружающих его элементов больше 3 или меньше 2,
        /// 	то новое значение элемента 0. Если в элементе 0 
        /// 	и сумма всех окружающих его элементов равна 3, то новое значение элемента 1.
        /// </summary>
        /// <param name="inputArray">исходный массив. Должен остаться неизменённым</param>
        /// <returns>возвращается новый массив с новыми значениями</returns>
        int[][] LifeCalculations(int[][] inputArray);

        /// <summary>
        /// Найти, сколько во входящем массиве пар одинаковых соседних элементов.
        /// Например: массив 0, 0, 1, 2, 2, 3 - одинаковых соседних пар 2 шт
        /// </summary>
        /// <param name="inputArray">входной массив. должен остаться неизменённым.</param>
        /// <returns>количество пар одинаковых соседних элементов</returns>
        int CalculateEqualPairs(int[] inputArray);
    }
}
