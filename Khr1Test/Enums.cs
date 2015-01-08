using System;
using System.Collections.Generic;
using System.Text;

namespace Khr1Test
{
    public enum BoardId : byte
    {
        Zero = 0,
        One = 1
    }

    public enum UpperTorso : byte
    {
        Head            = 6,
        LeftForearm     = 3,
        LeftBicep       = 2,
        LeftShoulder    = 1,
        RightForearm    = 9,
        RightBicep      = 8,
        RightShoulder   = 7
    }

    public enum LowerTorso : byte
    {
        LeftHip         = 3,
        LeftUpperThigh  = 4,
        LeftLowerThigh  = 5,
        LeftShin        = 6,
        LeftFoot        = 7,
        RightHip        = 9,
        RightUpperThigh = 10,
        RightLowerThigh = 11,
        RightShin       = 12,
        RightFoot       = 13
    }
                
}
