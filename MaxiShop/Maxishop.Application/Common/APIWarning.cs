﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Common
{
    public class APIWarning
    {
        public string Description {  get; set; }=string.Empty;
        public APIWarning(string description) 
        {
        Description = description;
        }
    }
}
