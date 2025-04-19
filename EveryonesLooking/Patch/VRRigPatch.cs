using HarmonyLib;
using UnityEngine;

namespace EveryonesLooking.Patch
{
    [HarmonyPatch(typeof(VRRig), "LateUpdate")]
    public class VRRigPatch
    {
        public static bool enabled;

        public static void Postfix(VRRig __instance)
        {
            if (__instance.isLocal) return;
            
            if (enabled)
            {
                __instance.head.rigTarget.LookAt(GorillaTagger.Instance.headCollider.transform);
            }
        }
    }
}   
