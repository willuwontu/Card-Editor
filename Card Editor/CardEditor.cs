using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnboundLib;
using UnboundLib.GameModes;
using UnboundLib.Networking;
using UnboundLib.Utils;
using UnboundLib.Utils.UI;

namespace CardEditor
{
    [BepInPlugin(ModId, ModName, Version)] // Register the mod for loading, values are contained in the class for the editor below.
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)] // Toggle cards menu location.
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)] // Utilities for handling cards and cardbars. Used for handling stats.
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)] // We want changes to rarity and categories to actually matter.
    [BepInProcess("Rounds.exe")] // Associate the mod with Rounds.
    public class CardEditor : BaseUnityPlugin // Basic class needed to interact with the game.
    {
        private const string ModId = "com.willuwontu.rounds.cardeditor"; // Unique identifier for BepIn so we don't load twice.
        private const string ModName = "Card Editor"; // Mod Name
        public const string Version = "0.0.1"; // What version are we on (major.minor.build.revision)?


    }
}
