using System;

namespace Utilities.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct |
                           System.AttributeTargets.Method)]
    internal class Beta : Attribute{}
}
