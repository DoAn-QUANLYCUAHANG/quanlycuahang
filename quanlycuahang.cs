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
                if (select[0] == '1')
                { 
                    resovle(select, ref data);
                }
                else if (select[0] == '2') 
                {
                    Console.WriteLine("i am coding");
                    // Tin code in here;
                    // select[1] = 1, 2, 3, 4, 5, view in the input function.
                }
                Console.WriteLine("Do you continues? <Y\t/\tN>");
                string cha = Console.ReadLine();
                if (cha == "N") check = false;
                else
                {
                    select = input();
                }
            }
            Console.ReadLine();
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
                    if (selectItems < 6 && selectItems > 0)
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

        public static void resovle(string select, ref List<Items> ListItems)
        {
            
                switch (select[1])
                {
                case '1':
                    Console.WriteLine("A\tD\tD\t");
                    Items add = creatItems();
                    ListItems.Add(add);
                    break;
                case '2':
                    Console.WriteLine("R\tE\tM\tO\tV\tE");
                    Items items = new Items();
                    Console.WriteLine("Input the codeItem to remove list item");
                    items.itemCode = Convert.ToInt32(Console.ReadLine());
                    Items index = ListItems.Find(x => x.itemCode == items.itemCode);
                    ListItems.RemoveAt(ListItems.IndexOf(index));
                    break;
                case '3':
                    Console.WriteLine("E\tD\tI\tT");
                    Items items2 = new Items();
                    Console.WriteLine("Input the codeItem to edit list item");
                    items2.itemCode = Convert.ToInt32(Console.ReadLine());
                    Items index2 = ListItems.Find(x => x.itemCode == items2.itemCode);
                    ListItems.RemoveAt(ListItems.IndexOf(index2));
                    Console.WriteLine("Input the new infomation");
                    Items temp = creatItems();
                    ListItems.Add(temp);
                    break;
                case '4':
                    searchItems(ListItems);
                    break;
                case '5':
                    Console.WriteLine("S\tH\tO\tW");
                    show(ListItems);
                    break;
                } 
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
            string temp4 = Console.ReadLine();
            item.companyProduct = temp4;
            Console.WriteLine("Input the Year Of Product");
            temp1 = Convert.ToInt32(Console.ReadLine());
            item.yearOfProduction = temp1;
            Console.WriteLine("Input the typeOfProduct");
            temp2 = Console.ReadLine();
            item.typeOfProduct = temp2;
            return item;
        }
        public static void searchItems(List<Items> listItems)
        {
            Console.WriteLine("Choose the ItemCode or nameItems or...");
            Console.WriteLine("1.Code");
            Console.WriteLine("2.Name");
            Console.WriteLine("3.Company");
            Console.WriteLine("4.YearOfProducts");
            Console.WriteLine("5.TypeOfProducts");
            int choose = Convert.ToInt32(Console.ReadLine());
            Items temp = new Items();
            if (choose < 6 && choose > 0)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("input the code");
                        temp.itemCode = Convert.ToInt32(Console.ReadLine());
                        List<Items> codeSearch = new List<Items>();
                        foreach (Items it in listItems)
                        {
                            if (it.itemCode == temp.itemCode) codeSearch.Add(it);
                        }
                        show(codeSearch);
                        break;
                    case 2:
                        Console.WriteLine("input the Name");
                        temp.nameItem = Console.ReadLine();
                        List<Items> nameSearch = new List<Items>();
                        foreach (Items it in listItems)
                        {
                            if (it.nameItem == temp.nameItem) nameSearch.Add(it);
                        }
                        show(nameSearch);
                        break;
                    case 3:
                        Console.WriteLine("input the Company");
                        temp.companyProduct = Console.ReadLine();
                        List<Items> CompanySearch = new List<Items>();
                        foreach (Items it in listItems)
                        {
                            if (it.companyProduct == temp.companyProduct) CompanySearch.Add(it);
                        }
                        show(CompanySearch);
                        break;
                    case 4:
                        Console.WriteLine("input the YearOfProducts");
                        temp.yearOfProduction = Convert.ToInt32(Console.ReadLine());
                        List<Items> yearSearch = new List<Items>();
                        foreach (Items it in listItems)
                        {
                            if (it.yearOfProduction == temp.yearOfProduction) yearSearch.Add(it);
                        }
                        show(yearSearch);
                        break;
                    case 5:
                        Console.WriteLine("input the TypeOfProducts");
                        temp.typeOfProduct = Console.ReadLine();
                        List<Items> typeSearch = new List<Items>();
                        foreach (Items it in listItems)
                        {
                            if (it.typeOfProduct == temp.typeOfProduct) typeSearch.Add(it);
                        }
                        show(typeSearch);
                        break;
                }
            }
            else searchItems(listItems);
        }
        public static void show (List<Items> items)
        {
            Console.WriteLine("I T E M S");
            Console.WriteLine("Code\t Name\t\t Dataexpiry\t\t Company\t Year Of Products\t TypeOfProduct");
            foreach(Items temp in items)
            {
                Console.WriteLine("{0}\t {1}\t\t {2}\t\t {3}\t {4}\t {5}",temp.itemCode, temp.nameItem, temp.dataexpiryDate,temp.companyProduct,temp.yearOfProduction,temp.typeOfProduct);
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
        public string typeOfProduct;
    }
    
}
