﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hal.Client
{
    public class StyleRef
    {
        [JsonProperty("href")]
        public string href { get; set; }
    }
}