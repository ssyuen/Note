﻿using System;

namespace Utilities.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class        |
                           System.AttributeTargets.Struct       |
                           System.AttributeTargets.Method       |
                           System.AttributeTargets.Interface    |
                           System.AttributeTargets.Enum)]
    internal class Beta : Attribute{}
}
