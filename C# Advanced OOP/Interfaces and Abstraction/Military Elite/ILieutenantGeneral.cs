﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        List<Private> PrivatesUnderCommand { get; set; }
    }
}
