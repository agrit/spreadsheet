using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SS;
using SpreadsheetUtilities;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {

            Spreadsheet j = new Spreadsheet();
            try
            {
                Formula f = new Formula("al+2");
            }
            catch (Exception)
            {
                
                Console.WriteLine("invalid formula");
            }
            

            //Console.WriteLine(j.Normalize("aa122"));
            //j.SetContentsOfCell("a1", "= 2 +     2+");

            //j.SetContentsOfCell("a1", "2");
            //j.SetContentsOfCell("z1", "7");
            j.SetContentsOfCell("a1", "=z1+2");
            //Console.WriteLine("These are the contents of z1: " + j.GetCellContents("z1"));
            Console.WriteLine("This is the value of a1: " + j.GetCellValue("a1"));
            j.SetContentsOfCell("z1", "7");
            //string temp = string.Empty;
            //foreach (var item in j.when)
            //{
            //    temp += item;
            //}

            //Console.WriteLine(temp);
            j.SetContentsOfCell("b1", "=a1+2");
            //string temp1 = string.Empty;
            //foreach (var item in j.when)
            //{
            //    temp += item;
            //}

            //Console.WriteLine(temp);
            j.SetContentsOfCell("c1", "=a1+2");
            //string temp2 = string.Empty;
            //foreach (var item in j.when)
            //{
            //    temp += item;
            //}

            //Console.WriteLine(temp);
            Console.WriteLine("these are the contents of a1: " + j.GetCellContents("a1"));
            Console.WriteLine("This is the value of B1: " + j.GetCellValue("b1"));
            Console.WriteLine(j.Changed);
            j.Save("spreadsheetcoolness.ss");
            Console.WriteLine(j.GetSavedVersion("spreadsheetcoolness.ss"));

            Spreadsheet k = new Spreadsheet("spreadsheetcoolness.ss", s => true, s => s, "default");
            foreach (var item in k.GetNamesOfAllNonemptyCells())
            {
                Console.WriteLine(item);
            }
            //Formula f1 = new Formula("Q1*2");
            //Formula f2 = new Formula("A1*2");
            ////Formula f3 = new Formula("A1*2");
            //j.SetCellContents("A1", f1);
            //j.SetCellContents("B1", f2);
            //j.SetCellContents("Z1", "");
            //string non = string.Empty;
            //foreach (var item in j.GetNamesOfAllNonemptyCells())
            //{
            //    non += item;
            //}
            //Console.WriteLine(non);

            //string temp = string.Empty;
            //foreach (var item in j.graph.GetDependents("A1"))
            //{
            //    temp += item;
            //}

            //Console.WriteLine("These are the dependents of A1: " + temp);

            //string cool = string.Empty;
            //foreach (var item in j.SetCellContents("A1", "hello") )
            //{
            //    cool += item;
            //}

            //Console.WriteLine("Should contain A1 & B1: " + cool);
            ////j.SetCellContents("A1", "hello");

            //temp = string.Empty;
            //foreach (var item in j.graph.GetDependents("A1"))
            //{
            //    temp += item;
            //}

            //Console.WriteLine("These are the dependents of A1: " + temp);


            //Formula f1 = new Formula("Z1*2");
            //Formula f2 = new Formula("A1*2");
            ////Formula f3 = new Formula("A1*2");


            //j.SetCellContents("A1", f1);
            //j.SetCellContents("B1", f2);
            //j.SetCellContents("Z1", "");
            ////j.SetCellContents("C1", f3);

            ////prints the direct dependents of A1
            //foreach (var item in j.graph.GetDependents("A1"))
            //{
            //    Console.WriteLine("Direct dependents of A1: " + item);
            //}
            //Console.WriteLine("");
            ////prints the direct dependents of Z1
            //foreach (var item in j.graph.GetDependents("Z1"))
            //{
            //    Console.WriteLine("Direct dependents of Z1: " + item);
            //}
            //Console.WriteLine("");
            ////prints off what setcellcontents returns
            //foreach (var item in j.SetCellContents("A1", "Hello"))
            //{
            //    Console.WriteLine(item + " this is what setcellcontents of A1 to hello equals");
            //}
            //Console.WriteLine("");
            //Console.WriteLine(j.GetCellContents("A1") + " this is the cell contents of A1");
            //Console.WriteLine("");
            ////prints the direct dependents of Z1
            //foreach (var item in j.graph.GetDependents("Z1"))
            //{
            //    Console.WriteLine("Direct dependents of Z1: " + item);
            //}
            //Console.WriteLine("");
            ////prints the direct dependents of A1
            //foreach (var item in j.graph.GetDependents("A1"))
            //{
            //    Console.WriteLine("Direct dependents of A1: " + item);
            //}
            //Console.WriteLine(j.graph.GetDependents("A1").ToString());
            // Console.WriteLine(j.GetCellContents("A1"));
            Console.Read();

        }
    }
}
