using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using Verse.AI;

namespace SearchAndDestroy.Harmony
{
    [HarmonyPatch(typeof(Pawn_JobTracker), "DetermineNextJob")]
    static class Pawn_JobTracker_DetermineNextJob
    {
        static void Postfix(Pawn_JobTracker __instance, ref ThinkResult __result)
        {
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();

            if (pawn.Drafted)
            {
                Log.Message("started new job for pawn: " +  pawn.Name);
            }

        }
    }
}
