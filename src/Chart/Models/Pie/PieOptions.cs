﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class PieOptions
    {
        /// <summary>
        /// The percentage of the chart that is cut out of the middle.
        /// </summary>
        public int? CutoutPercantage { get; set; }

        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        public double? Rotation { get; set; }

        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        public double? Circumference { get; set; }
    }
}