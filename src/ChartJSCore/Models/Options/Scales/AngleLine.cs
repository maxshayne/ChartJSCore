﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class AngleLine
    {
        /// <summary>
        /// If true, angle lines are shown.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Color of angled lines.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Width of angled lines.
        /// </summary>
        public int? LineWidth { get; set; }
    }
}
