using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_AmmonCarson
{
    class DeskQuote
    {

        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }

        public decimal finalQuote { get; set; }
        public decimal drawersCost { get; set; }
        public decimal deskBaseCost { get; set; }
        public decimal shippingCost { get; set; }
        public decimal surfaceCost { get; set; }
        public decimal surfaceArea { get; set; }

        public Desk Desk { get; set; }

        public enum ShippingDays
        {
            Three_Day_Rush,
            Five_Day_Rush,
            Seven_Day_Rush,
            Standard_Free
        }

        public ShippingDays ShippingRush { get; set; }

        //***GET QUOTE***
        public decimal getQuote()
        {
            drawersCost = Desk.NumDrawers * 50;
            deskBaseCost = 200;
            surfaceArea = Desk.Depth * Desk.Width;

            //Get ShippingCost
            switch (ShippingRush)
            {
                case ShippingDays.Three_Day_Rush:
                    shippingCost = 60;
                    break;
                case ShippingDays.Five_Day_Rush:
                    shippingCost = 40;
                    break;
                case ShippingDays.Seven_Day_Rush:
                    shippingCost = 30;
                    break;
                case ShippingDays.Standard_Free:
                    shippingCost = 0;
                    break;
                default:
                    shippingCost = 0;
                    break;
            }

            //Check for additional shipping cost based on Surface Area
            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                shippingCost += 10;
            }
            if (surfaceArea > 2000)
            {
                shippingCost += 20;
            }

            //get Surface Material
            switch (this.Desk.Material)
            {
                case Desk.SurfaceMaterial.Oak:
                    surfaceCost = 200;
                    break;
                case Desk.SurfaceMaterial.Laminate:
                    surfaceCost = 100;
                    break;
                case Desk.SurfaceMaterial.Pine:
                    surfaceCost = 50;
                    break;
                case Desk.SurfaceMaterial.Rosewood:
                    surfaceCost = 300;
                    break;
                case Desk.SurfaceMaterial.Veneer:
                    surfaceCost = 125;
                    break;
                default:
                    surfaceCost = 0;
                    break;
            }

            if (surfaceArea > 1000)
            {
                surfaceCost += surfaceArea;
            }
            else
            {
                surfaceCost += 0;
            }

            finalQuote = drawersCost + deskBaseCost + shippingCost + surfaceCost;
            return finalQuote;
        }
    }
}