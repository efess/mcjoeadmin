﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McJoeAdmin.Cortex
{
    public enum ModuleState
    {
        Loaded,
        Unloaded,
        LoadError,
        UnloadError,
        NoTypesToLoad
    }
}
