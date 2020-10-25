using System;
using System.Collections.Generic;
using System.Linq;
namespace project01
{
    class Program
    {
        static void Main(string[] args)
        {   
            int year = 365;
            int month = 30;
            int week = 7;
            Console.WriteLine("Please input your total earnings per day one by one\nWhen your finished type done");
            List<int> total = new List<int>();
            bool done = false;

            while (done == false)
            {
            string input = (Console.ReadLine());
            if (input.CompareTo("done") == 0)
            {
                done = true;
            }
            else
            {
                done = false;
                
                total.Add(Convert.ToInt32(input));

            }
            }
            Console.WriteLine("What would you like to see\n1. Yearly revenue total\n2. Monthly revenue total\n3. Weekly revenue total");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 == 1)
            {
                int amount = total.Count / year;
                if (amount == 0)
                {
                    amount++;
                }
                int yearrevenue = 0;
                bool yearestimate = false;
                Dictionary<string, List<int>> years = new Dictionary<string, List<int>>();
                for (int i = 0; i < amount ; i++)
                {                   
                    years.Add("year" + i, new List<int>());
                    string key = years.Keys.ElementAt(i);
                    if (total.Count >= year)
                    {
                    years[key] = total.Take(year).ToList();
                    total = total.Skip(year).ToList();
                    yearrevenue += years[key].Sum();
                    yearrevenue = yearrevenue / years.Count;
                    yearrevenue /= years.Count;
                    }
                    else if (total.Count < year)
                    {
                    yearestimate = true;
                    years[key] = total.Take(total.Count).ToList();
                    yearrevenue += years[key].Sum();
                    yearrevenue /= years[key].Count;
                    yearrevenue *= year;
                    }               
                }

                if (yearestimate == false)
                {
                Console.WriteLine("Your yearly average is: " + yearrevenue);
                }
                else if (yearestimate == true)
                {
                Console.WriteLine("Not enough data, estimated yearly average is: " + yearrevenue);
                }

            }
            else if (input2 == 2)
            {
                int amount = total.Count / month;
                if (amount == 0)
                {
                    amount++;
                }
                int monthrevenue = 0;
                bool monthestimate = false;
                Dictionary<string, List<int>> months = new Dictionary<string, List<int>>();
                for (int i = 0; i < amount ; i++)
                {
                    months.Add("month" + i, new List<int>());
                    string key = months.Keys.ElementAt(i);
                    if (total.Count >= month)
                    {
                    months[key] = total.Take(month).ToList();
                    total = total.Skip(month).ToList();
                    monthrevenue += months[key].Sum();
                    monthrevenue /= months.Count;
                    }
                    else if (total.Count < month)
                    {
                    monthestimate = true;
                    months[key] = total.Take(total.Count).ToList();
                    monthrevenue += months[key].Sum();
                    monthrevenue /= months[key].Count;
                    monthrevenue *= month;
                    }

                if (monthestimate == false)
                {
                Console.WriteLine("Your monthly average is: " + monthrevenue);
                }
                else if (monthestimate == true)
                {
                Console.WriteLine("Not enough data, estimated monthly average is: " + monthrevenue);
                }

                }
                
            }
            else if (input2 == 3)
            {   
                int amount = total.Count / week;
                if (amount == 0)
                {
                    amount++;
                }
                int weekrevenue = 0;
                bool weekestimate = false;
                Dictionary<string, List<int>> weeks = new Dictionary<string, List<int>>();
                for (int i = 0; i < amount ; i++)
                {   
                    weeks.Add("week" + i, new List<int>());
                    string key = weeks.Keys.ElementAt(i);
                    if (total.Count >= week)
                    {
                    weeks[key] = total.Take(week).ToList();
                    total = total.Skip(week).ToList();
                    weekrevenue += weeks[key].Sum();
                    weekrevenue /= weeks.Count;
                    }
                    else if (total.Count < week)
                    {
                    weekestimate = true;
                    weeks[key] = total.Take(total.Count).ToList();
                    weekrevenue += weeks[key].Sum();
                    weekrevenue /= weeks[key].Count;
                    weekrevenue *= week;
                    }

                }
                if (weekestimate == false)
                {
                Console.WriteLine("Your weekly average is: " + weekrevenue);
                }
                else if (weekestimate == true)
                {
                Console.WriteLine("Not enough data, estimated weekly average is: " + weekrevenue);
                }
            }
            else
            {
                Console.WriteLine("Please input a number from 1-3");
            }
            

            Console.ReadKey();
        }
    }
}
