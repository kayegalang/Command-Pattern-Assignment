// Command.cs
// This abstract class defines the Command base for the Command Pattern
// Author: Kaye Galang
// Date: 9/23/24

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public abstract class Command
    {
        public abstract void Execute(GameObject actor);
    }
}

