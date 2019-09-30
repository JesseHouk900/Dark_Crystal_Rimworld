/*
 *      Gelfling Bola
 * Created by Jesse Houk 
 * User: jessejhacker
 * Date: 09/09/2019
 * Time: 11:32 PM
 * 
 */
/*
 *      Gelfling
 * Created by Jesse Houk 
 * User: jessejhacker
 * Date: 09/06/2019
 * Time: 8:38 PM
 * 
 */
using System;
using RimWorld;
using Verse;

namespace DarkCrystal_Gelfling
{
    /// <summary>
    /// 
    /// </summary>
    public class ThingDef_Bola : ThingDef
    {
        // Default value that the xml overwrites
        public float AddHediffChance = 0.05f;
        public HediffDef HediffToAdd;

        // Resolve issue of using DefOf when initializing instance
        public override void ResolveReferences()
        {
            HediffToAdd = HediffDefOf.Anesthetic;
        }
    }
}
