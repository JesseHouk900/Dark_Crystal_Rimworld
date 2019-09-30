using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace DarkCrystal_Gelfling
{
    public class Projectile_Bola: Bullet
    {
        #region Properties
        public ThingDef_Bola Def
        {
            get
            {
                return this.def as ThingDef_Bola;
            }
        }
        #endregion Properties


        #region Overrides
        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);

            // Always check for null, things may not exist
            // Along with checking if thing exists and that it hit something,
            // also makes sure hitThing hits an instance of a hitPawn
            if (Def != null && hitThing != null && hitThing is Pawn hitPawn)
            {
                // get a random value between 0 and 1
                var rand = Rand.Value;
                // if the Hediff fails...
                if (rand <= Def.AddHediffChance)
                {
                    Messages.Message("JJH_Bola_SuccessMessage".
                        Translate(this.launcher.Label, hitPawn.Label),
                        MessageTypeDefOf.NeutralEvent);

                    var anesthesiaOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Def.HediffToAdd);

                    var randomSeverity = Rand.Range(0.15f, 0.30f);

                    if (anesthesiaOnPawn != null)
                    {
                        anesthesiaOnPawn.Severity += randomSeverity;

                    }
                    else
                    {
                        // mote maker handles all small visual effects
                        MoteMaker.ThrowText(hitThing.PositionHeld.ToVector3(),
                     hitThing.MapHeld, "JJH_Bola_FailureMote".Translate(Def.AddHediffChance), 12f);

                    }
                }
            }
            #endregion Overrides
        }
    }
}
