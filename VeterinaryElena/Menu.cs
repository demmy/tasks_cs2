using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    class Menu
    {
        public struct ItemAction
        {
            public  int?  Code;
            public string text;
            public Action MyAction;
        }

        private ItemAction[] items;

        public Menu(ItemAction[] items)
        {
            this.items = new ItemAction[items.Length];
            items.CopyTo(this.items, 0);
        }

        public void Show()
        {
            Action currentAction = null;
            do
            {
                PrintMenu();
                currentAction=items[GetCorrectUserInput()-1].MyAction;
                if(currentAction!=null)
                {
                    currentAction();
                }
            }
            while(currentAction!=null);
            }

        private void PrintMenu()
        {
            bool areCodesAvailable = Array.TrueForAll(this.items, (item) => { return item.Code.HasValue; });
            for (int index = 0; index < items.Length; index++)
            {
                Console.WriteLine("[{0}] {1}", areCodesAvailable?items[index].Code:index+1, items[index].text);
            }
        }

            private int GetCorrectUserInput()
            {
 	            string input;
                int number;
                do
                {
                    Console.WriteLine("Enter your code");
                    input=Console.ReadLine();
                }
                while(!(int.TryParse(input, out number)&&ValidateInput(number, items.Length)));
                return number;
            }

            private bool ValidateInput(int choice, int maxValue)
            {
                bool result = false;
                bool areCodesAvailable = Array.TrueForAll(this.items, (item) => { return item.Code.HasValue; });
                if (areCodesAvailable)
                {
                    result = Array.FindIndex(this.items, (item) => { return choice == item.Code.Value; }) > -1;

                }
                else
                {
                    result = choice > 0 && choice <= maxValue;
                }
                return result;
            }
        }
    }

