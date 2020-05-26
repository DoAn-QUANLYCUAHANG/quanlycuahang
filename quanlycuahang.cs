using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace QUANLYCUAHANG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string select = input();
            List<Items> data = new List<Items>();
            while (check)
            {
                if (select[0] == 1)
                {
                    Items items = new Items();
                    data = resovle(select);
                    show(data);
                }
                Console.WriteLine("Do you continues? <Y\t/\tN>");
                string cha = Console.ReadLine();
                if (cha != "Y" || cha != "N") Console.WriteLine("Y\t/\tN");
                else if (cha == "Y") check = false;
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
                    Console.WriteLine("5. Show the item");
                    selectItems = Convert.ToInt32(Console.ReadLine());
                    if (selectItems < 5 && selectItems > 0)
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

        public static List<Items> resovle(string select)
        {
            List<Items> result = new List<Items>();
                switch (select[1])
                {
                    case '1':
                        List<Items> add = addItems();
                        return add;
                    case '2':
                        List<Items> remove =  removeItems();
                        return remove;
                    case '3':
                        List<Items> edit = editItems();
                    return edit;
                } 
            return result;
        }

        public static Items creatItems()
        {
            Items item = new Items();
            Console.WriteLine("Input the itemCode");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            item.itemCode = temp1;
            Console.WriteLine("Input the nameItems");
            string temp2 = Console.ReadLine();
            item.nameItem = temp2;
            Console.WriteLine("Input the dataexpiryDate");
            DateTime temp3 = Convert.ToDateTime(Console.ReadLine());
            item.dataexpiryDate = temp3;
            Console.WriteLine("Input the companyProduct");
            temp2 = Console.ReadLine();
            item.nameItem = temp2;
            Console.WriteLine("Input the typeOfProduct");
            temp1 = Convert.ToInt32(Console.ReadLine());
            item.itemCode = temp1;
            Console.WriteLine("Input the codeTypeOfItems and nameTypeOfItems");
            temp1 = Convert.ToInt32(Console.ReadLine());
            temp2 = Console.ReadLine();
            item.typeOfProduct.Add(temp1, temp2);
            return item;
        }
        public static List<Items> addItems()
        {
            List<Items> result = new List<Items>();
            Items items = new Items();
            items = creatItems();
            result.Add(items);
            return result;
        }
        public static List<Items> removeItems()
        {
            List<Items> result = new List<Items>();
            Items items = new Items();
            items = creatItems();
            result.Remove(items);
            return result;
        }
        public static List<Items> editItems()
        {
            List<Items> result = new List<Items>();
            Items items = new Items();
            Console.WriteLine("Input the infortiom to edit");
            result =  removeItems();
            Console.WriteLine("Update the infortiom to edit");
            result = addItems();
            return result;

        }
        public static void searchItems(Items items)
        {

        }
        public static void show (List<Items> items)
        {
            Console.WriteLine("I T E M S");
            Console.WriteLine("Code\t Name\t Dataexpiry\t Company\t Year Of Products\t TypeOfProduct");
            foreach(Items temp in items)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}",temp.itemCode,temp.nameItem,temp.dataexpiryDate,temp.companyProduct,temp.yearOfProduction,temp.typeOfProduct);
            }
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
