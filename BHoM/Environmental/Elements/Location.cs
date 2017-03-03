﻿using BHG = BHoM.Geometry;
using BHB = BHoM.Base;
using BHE = BHoM.Environmental.Elements;
using System;
using System.Reflection;
using BHoM.Structural.Loads;
using System.Collections.Generic;
using System.ComponentModel;

namespace BHoM.Environmental.Elements
{
    /// <summary>
    /// Location objects.
    /// </summary>
    public class Location : BHB.BHoMObject
    {
        /////////////////
        ////Properties///
        /////////////////

        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Elevetion { get; set; }
        public double AngleFromTrueNorth { get; set; }
        public string Adress { get; set; }

    }

}