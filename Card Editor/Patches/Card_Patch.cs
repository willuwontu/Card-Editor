using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.Utils;
using UnityEngine;

namespace CardEditor.Patches
{
    [HarmonyPatch(typeof(Card))]
    class Card_Patch
    {
        [HarmonyPrefix]
        [HarmonyDebug]
        [HarmonyPatch(MethodType.Constructor)]
        static void CardBuilt(string category, bool enabled, ref CardInfo cardInfo)
        {
            UnityEngine.Debug.Log("[Card Editor] " + cardInfo.cardName + " built");
        }

        //[HarmonyPostfix]
        //[HarmonyPatch("SomeMethod")]
        //static void MyMethodName()
        //{

        //}
    }
}
