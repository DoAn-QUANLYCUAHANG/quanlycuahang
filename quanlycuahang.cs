using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace QUANLYCUAHANG
{
    class Program
    {
        static void Main(string[] args)
        {
            string select = input();
            List<Items> data = new List<Items>();
            if (select[0] == 1)
            {
                Items items = new Items();
                output(select, items);
            }
            
        }
        public static string input()
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("Please select the function");
            bool check = true;
            int selectFuntion = 0;
            string select = "";
            while (check)
            {   
                Console.WriteLine("1. Function of Items");
                Console.WriteLine("2. Function of Type of Items");
                selectFuntion = Convert.ToInt32(Console.ReadLine());
                if (selectFuntion == 1 || selectFuntion == 2)
                {
                    check = false;
                }
                else Console.WriteLine("Please select again");
            }
            select = string.Concat(select, selectFuntion.ToString());
            if (selectFuntion == 1)
            {
                check = true;
                int selectItems = 0;
                while (check)
                {
                    Console.WriteLine("Please select: ");
                    Console.WriteLine("1. Add the item");
                    Console.WriteLine("2. Remove the item");
                    Console.WriteLine("3. Edit the item");
                    Console.WriteLine("4. Search the item");
                    selectItems = Convert.ToInt32(Console.ReadLine());
                    if (selectItems < 4 && selectItems > 0)
                    {
                        check = false;
                    }
                    else Console.WriteLine("Please select again");
                }
                select = string.Concat(select, selectItems.ToString());
            }
            else if (selectFuntion == 2)
            {
                check = true;
                int selectTypeOfItems = 0;
                while (check)
                {
                    Console.WriteLine("Please select: ");
                    Console.WriteLine("1. Add the type of item");
                    Console.WriteLine("2. Remove the type of item");
                    Console.WriteLine("3. Edit the type of item");
                    Console.WriteLine("4. Search the type of item");
                    selectTypeOfItems = Convert.ToInt32(Console.ReadLine());
                    if (selectTypeOfItems < 4 && selectTypeOfItems > 0)
                    {
                        check = false;
                    }
                    else Console.WriteLine("Please select again");
                }
                select = string.Concat(select, selectTypeOfItems.ToString());
            }
            return select;
        }

        public static void output(string select, Items items)
        {
            Console.WriteLine("{0}",select);
            if (select[0] == '1')
            {
                switch (select[1])
                {
                    case '1':
                        addItems(items);
                        break;
                    case '2':
                        removeItems(items);
                        break;
                    case '3':
                        editItems(items);
                        break;
                    case '4':
                        searchItems(items);
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void addItems(Items items)
        {
            Console.WriteLine("Input the itemCode");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            items.itemCode = temp1;
            Console.WriteLine("Input the nameItems");
            string temp2 = Console.ReadLine();
            items.nameItem = temp2;
            Console.WriteLine("Input the dataexpiryDate");
            DateTime temp3 = Convert.ToDateTime(Console.ReadLine());
            items.dataexpiryDate = temp3;
            Console.WriteLine("Input the companyProduct");
            temp2 = Console.ReadLine();
            items.nameItem = temp2;
            Console.WriteLine("Input the typeOfProduct");
            temp1 = Convert.ToInt32(Console.ReadLine());
            items.itemCode = temp1;
            Console.WriteLine("Input the codeTypeOfItems and nameTypeOfItems");
            temp1 = Convert.ToInt32(Console.ReadLine());
            temp2 = Console.ReadLine();
            items.typeOfProduct.Add(temp1,temp2);
        }
        public static void removeItems(Items items)
        {

        }
        public static void editItems(Items items)
        {

        }
        public static void searchItems(Items items)
        {

        }
    }
    class Items
    {
        public int itemCode;
        public string nameItem;
        public DateTime dataexpiryDate;
        public string companyProduct;
        public int yearOfProduction;
        public Dictionary<int, string> typeOfProduct = new Dictionary<int, string>();
    }
    
}
