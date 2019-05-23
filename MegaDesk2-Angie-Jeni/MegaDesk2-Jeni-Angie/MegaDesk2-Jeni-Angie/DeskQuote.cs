using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MegaDesk2_Jeni_Angie
{
    public class DeskQuote
    {
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 120.00M;

        //int[,] rushDays =k new int[3, 3];
        static string[] rushOrderPrices = File.ReadAllLines(@"rushOrderPrices.txt");
        int[,] rushDays = getPrices(rushOrderPrices);

        public DateTime todaysDate { get; set; }
        public String CustomerName { get; set; }
        public string rushOrder { get; set; }
        public decimal price { get; set; }
        public Desk getDesk { get; set; }

        public decimal GetQuote()
        {
            var surfaceArea = getDesk.width * getDesk.depth;
            var totalCost = 200;
            totalCost += getDesk.numOfDrawers * 50;

            if (surfaceArea > 100)
            {
                totalCost += (int)surfaceArea;
            }

            //Switch for Surface Material
            switch (getDesk.DesktopMaterial)
            {
                case Desk.Desktop.Oak:
                    totalCost += 200;
                    break;

                case Desk.Desktop.Laminate:
                    totalCost += 100;
                    break;

                case Desk.Desktop.Pine:
                    totalCost += 50;
                    break;

                case Desk.Desktop.Rosewood:
                    totalCost += 300;
                    break;

                case Desk.Desktop.Veneer:
                    totalCost += 125;
                    break;
            }


            //Switch for Shipping Time
            switch (rushOrder)
            {
                case "3 Days":
                    if (surfaceArea < 1000)
                    {
                        totalCost += rushDays[0, 0];
                    }

                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += rushDays[1, 0];
                    }

                    else
                    {
                        totalCost += rushDays[2, 0];
                    }

                    break;

                case "5 Days":
                    if (surfaceArea < 1000)
                    {
                        totalCost += rushDays[0, 1];
                    }

                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += rushDays[1, 1];
                    }

                    else
                    {
                        totalCost += rushDays[2, 1];
                    }

                    break;

                case "7 Days":
                    if (surfaceArea < 1000)
                    {
                        totalCost += rushDays[0, 2];
                    }

                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        totalCost += rushDays[1, 2];
                    }

                    else
                    {
                        totalCost += rushDays[2, 2];
                    }

                    break;

                default:
                    totalCost += 0;
                    break;
            }

            return totalCost;
        }

        public static int[,] getPrices(string[] rushOrderPrices)
        {
            try
            {
                int[] rushDay = Array.ConvertAll(rushOrderPrices, int.Parse);
                int[,] rushDays = new int[3, 3];
                int current = 0;

                for (int j = 0; j < 3; j++)
                {

                    for (int i = 0; i < 3; i++)
                    {

                        rushDays[i, j] = rushDay[current];
                        current++;
                    }
                }
                return rushDays;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                return null;
            }

        }
    }


}