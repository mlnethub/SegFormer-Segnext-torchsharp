﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorchSharp;

namespace SegNext
{
    public static class Config
    {

        public static float BN_MOM { get; set; }
        public static DeviceType DeviceType { get; set; }
        public static Norm_typeEnum Norm_TypeEnum { get; set; }
        public static int Ham_channels { get; set; }
    }
}
