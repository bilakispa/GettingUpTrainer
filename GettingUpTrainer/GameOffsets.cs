using System;

namespace GettingUpTrainer
{
    struct Modules
    {
        public const string MEGU = "GettingUp";
        public const string GCORE_DLL = "GCore.dll";
        public const string RHAPSODY_NAME = "G_rhapsody.sgl";
    }

    struct Offsets
    {
        public enum Main : int
        {
            INSTANCE_MANAGER = 0x004D2B30,
        }

        public enum InstanceManager : int
        {
            CHARACTERS_SPAWNED = 0x290, // int
            CHARACTER_MANAGER_ARRAY = 0x294
        }

        public enum CharacterManager : int
        {
            CHARACTER = 0x8
        }

        public enum Character : int
        {
            HEALTH_CURRENT = 0x150,
            HEALTH_MAX = 0x154,
            // ...
            TRANSFORM_RIGHT_X = 0x180,
            TRANSFORM_RIGHT_Y = 0x184,
            TRANSFORM_RIGHT_Z = 0x188,
            TRANSFORM_RIGHT_W = 0x18C,
            TRANSFORM_UP_X = 0x190,
            TRANSFORM_UP_Y = 0x194,
            TRANSFORM_UP_Z = 0x198,
            TRANSFORM_UP_W = 0x19C,
            TRANSFORM_FORWARD_X = 0x1A0,
            TRANSFORM_FORWARD_Y = 0x1A4,
            TRANSFORM_FORWARD_Z = 0x1A8,
            TRANSFORM_FORWARD_W = 0x1AC,
            TRANSFORM_POSITION_X = 0x1B0,
            TRANSFORM_POSITION_Y = 0x1B4,
            TRANSFORM_POSITION_Z = 0x1B8,
            TRANSFORM_POSITION_W = 0x1BC,
            // ...
            MODEL_NAME = 0x360, // char[64]
            // ...
            ALLOW_CHARACTER_OVERLAP = 0x764, // bool
            // ...
            // IGNORED_BY_CAMERA = 0x7D0, // char* (true == '\0')
            // ...
            ALLOW_HEAD_TRACKING = 0x858, // bool
            // ...
            ALLOW_RUMBLE = 0x9BD, // bool
            // ...
            // INVENTORY = 0xA50, // TCharacterInventory **
            // ...
            // TAI_POINTER = 0xA6C
            // ...
            // TODO: Search for: isPowerSliding
            // ...
            POWER_CURRENT = 0xAB0,
            POWER_MAX = 0xAB4,
            // ...
            REP_CURRENT = 0xEC8,
            REP_MAX = 0xECC
        }
    }
}
