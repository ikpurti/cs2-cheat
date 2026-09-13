namespace Cs2Cheat.Core.Memory;

/// <summary>Structure offsets for Counter-Strike 2 — update after each game patch.</summary>
public static class Offsets
{
    /// <summary>Module-level addresses (relative to module base).</summary>
    public static class Client
    {
        public const nint LocalPlayer        = 0x1632347;
        public const nint EntityList         = 0x192508F;
        public const nint ViewMatrix         = 0x192E2BC;
        public const nint GameRules          = 0x1903EA7;
        public const nint GlobalVars         = 0x17F09C8;
        public const nint InputSystem        = 0x1A71BA4;
    }

    /// <summary>Entity / pawn struct field offsets.</summary>
    public static class Entity
    {
        public const nint Health             = 0x347;
        public const nint TeamNum            = 0x3C3;
        public const nint Origin             = 0x108F;
        public const nint EyeAngles          = 0x15F2;
        public const nint SceneNode          = 0x3BC;
        public const nint ModelState         = 0x1A2;
        public const nint ShotsFired         = 0x26A7;
        public const nint AimPunch           = 0x1588;
        public const nint IsScoped           = 0x24C8;
        public const nint CrosshairId        = 0x188F;
        public const nint Flags              = 0x1A4;
        public const nint Velocity           = 0x1597;
        public const nint FlashDuration      = 0x15A1;
        public const nint SpottedMask        = 0x18EE;
        public const nint BoneMatrix         = 0xF02;
    }

    /// <summary>Bone indices for skeleton rendering and aim targeting.</summary>
    public static class Bones
    {
        public const int Head               = 6;
        public const int Neck               = 5;
        public const int SpineUpper         = 4;
        public const int SpineMid           = 3;
        public const int Pelvis             = 0;
        public const int LeftShoulder       = 8;
        public const int LeftElbow          = 9;
        public const int LeftHand           = 13;
        public const int RightShoulder      = 30;
        public const int RightElbow         = 31;
        public const int RightHand          = 35;
        public const int LeftKnee           = 22;
        public const int LeftFoot           = 24;
        public const int RightKnee          = 44;
        public const int RightFoot          = 46;
    }
}
