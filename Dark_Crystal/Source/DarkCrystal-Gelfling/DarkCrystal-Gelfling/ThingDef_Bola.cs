using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace DarkCrystal_Gelfling
{
    public class ThingDef_Bola: ThingDef
    {
        public float AddHediffChance = 0.05f;

        public HediffDef HediffToAdd;


        #region Overrides
        public override void ResolveReferences()
        {
            HediffToAdd = HediffDefOf.Anesthetic;
        }

        #endregion Overrides
    }
}
