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
    
    class Card_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Card))]
        [HarmonyPatch(MethodType.Constructor)]
        [HarmonyPatch(new Type[] {typeof(String), typeof(String), typeof(CardInfo)})]
        static void CardBuild(Card __instance)
        {
            UnityEngine.Debug.Log("[Card Editor] " + __instance.cardInfo.cardName + " built");
        }

        //[HarmonyPostfix]
        //[HarmonyPatch("SomeMethod")]
        //static void MyMethodName()
        //{

        //}
    }
}
