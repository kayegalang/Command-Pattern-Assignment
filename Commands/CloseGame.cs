// CloseGame.cs
// This script defines the CloseGame command, which allows the player to exit the game.
// Author: Kaye Galang
// Date: 9/23/24

using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class CloseGame : Command
{
    public override void Execute(GameObject actor)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

