﻿using RimWorld;
using Verse;

namespace VFEEmpire;

[DefOf]
public static class VFEE_DefOf
{
    public static JoyKindDef VFEE_Research;
    public static RoomRoleDef VFEE_Ballroom;
    public static RoomRoleDef VFEE_Gallery;
    public static InteractionDef VFEE_RoyalGossip;
    public static ThingDef VFEE_Turret_StrikerTurret;
    public static RoyaltyTabDef VFEE_GreatHierarchy;
    public static ThingDef VFEI_ArmoredShuttle;
    public static ThingDef VFEE_OrbitalSlicer;
    public static ThingDef VFEE_DropPodIncoming_Building;
    public static TransportShipDef VFEE_Ship_ArmoredShuttle;
    public static PawnKindDef Empire_Fighter_StellicGuardRanged;
    public static PawnKindDef Empire_Fighter_StellicGuardMelee;
    public static PawnKindDef Empire_Fighter_Janissary;
    public static PawnKindDef Empire_Fighter_Cataphract;
    public static PawnKindDef Empire_Royal_Duke;
    public static PawnKindDef Empire_Royal_Baron;
    public static PawnKindDef VFEE_Deserter;
    public static FactionDef VFEE_Deserters;
    public static RoyalTitleDef Duke;
    public static RoyalTitleDef Baron;

    static VFEE_DefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(VFEE_DefOf));
    }
}