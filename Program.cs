﻿using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(new int[] { 2, 3, 4, 5 });
           // a.Add(5);
           // a.Add(10);
           // a.StartAdd(1);
           // a.Insert(7, 1);
           //// Console.WriteLine(a[0]);
           //// Console.WriteLine(a[1]);
           //// Console.WriteLine(a[2]);
           //// Console.WriteLine(a[3]);
           ////// Console.WriteLine(a.index(4));
           //// Console.WriteLine(a.length);
           //// //a.StartRemove();
           //// Console.WriteLine(a.length);
           //// Console.WriteLine(a[0]);
           //// Console.WriteLine(a[1]);
           //// Console.WriteLine(a[2]);
           //// Console.WriteLine(a[3]);
           //// Console.WriteLine(a.returnMassive()[2]);
           //// a.Reverse();
           // for (int i = 0; i <a.length; i++)
           // {
           //     Console.WriteLine("------");
           //     Console.WriteLine(a[i]);
           // }
           // //Console.WriteLine("========");
           // //Console.WriteLine(a[0]);
           // //a[0] = 15;
           // //Console.WriteLine(a[0]);
           // //Console.WriteLine(a.MinItem());
           // //Console.WriteLine(a.MaxItem());

           // a.SortUp();
           // for (int i = 0; i < a.length; i++)
           // {
           //     Console.WriteLine("------");
           //     Console.WriteLine(a[i]);
           // }
           // a.SortDown();
           // a.RemoveItem(7);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("------");
            //    Console.WriteLine(a[i]);
            //}
            //Console.WriteLine(a.Length);
            IDataStructure ooo = new LinkedList(5);
            ooo.AddToStart(10);
            
            for (int i = 0; i < ooo.ReturnMassive().Length; i++)
            {
                Console.WriteLine(ooo.ReturnMassive()[i]);
            }
            
        }
    }
}
