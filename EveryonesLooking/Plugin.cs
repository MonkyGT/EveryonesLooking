using System.ComponentModel;
using BepInEx;
using HarmonyLib;

namespace EveryonesLooking
{
    // I added the description thing so it is compatible with luna's haunted tweaks (FIX FOR THAT ON MY GITHUB)
    [Description("HauntedModMenu")]
    [BepInPlugin("monky.everyoneslooking", "Everyones Looking", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

        void Start()
        {
            Harmony.CreateAndPatchAll(GetType().Assembly, "monky.everyoneslooking");
        }
        
        void OnDisable()
        {
            Patch.VRRigPatch.enabled=false;
        }

        void OnEnable()
        {
            Patch.VRRigPatch.enabled=true;
        }
    }
}
