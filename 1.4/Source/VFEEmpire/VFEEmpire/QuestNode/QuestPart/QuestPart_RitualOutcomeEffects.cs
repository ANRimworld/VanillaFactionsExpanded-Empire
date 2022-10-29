﻿using System;
using System.Linq;
using System.Collections.Generic;
using RimWorld;
using Verse;
using UnityEngine;
using RimWorld.Planet;
using RimWorld.QuestGen;

namespace VFEEmpire
{
    //TODO
    //Using this to add additional rewards/outcome effects based on the ritual outcome but effects that I dont want to apply until after they left
    
    public class QuestPart_RitualOutcomeEffects : QuestPart_AddQuest
    {
        public override Slate GetSlate()
        {
            Slate slate = new();
            slate.Set("rewardGiver", leadNoble);
            slate.Set("marketValueRange", MarketValueRange, false);
            slate.Set("outcome", outcomeIndex);
            return slate;
        }
        public override QuestScriptDef QuestDef => InternalDefOf.VFEE_DelayedGrandBallOutcome;
        public override bool CanAdd => outcomeIndex != -2;
        private FloatRange MarketValueRange
        {
            get
            {
                FloatRange floatRange = new();
                if (outcomeIndex > 0)
                {
                    floatRange.min = initMarkValue;
                    floatRange.max = initMarkValue * outcomeIndex * 1.5f;
                }
                else
                {
                    floatRange.min = 0;
                    floatRange.max = initMarkValue/2;
                }
                return floatRange;
            }
        }
        public override void Notify_QuestSignalReceived(Signal signal)
        {
            
            if (signal.tag == inSignal)
            {
                if (!signal.args.TryGetArg<int>("OUTCOME", out var outcome) )
                {
                    return;
                }
                outcomeIndex = outcome;
            }
            base.Notify_QuestSignalReceived(signal);
        }
        public override void Notify_PreCleanup()
        {
            base.Notify_PreCleanup();

        }
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref initMarkValue, "initMarkValue");
            Scribe_Values.Look(ref outcomeIndex, "outcomeIndex");
            Scribe_Defs.Look(ref outcomeDef, "outcomeDef");
            Scribe_References.Look(ref leadNoble, "leadNoble");
        }
        //Ritual outcome themselves are not exposable so storing index

        public float initMarkValue;
        public Pawn leadNoble;
        public RitualOutcomeEffectDef outcomeDef;
        public int outcomeIndex;

    }
}