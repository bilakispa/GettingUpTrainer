using System;

namespace GettingUpTrainer
{
    struct PointerOffsets
    {
        //public const Int32 ACTOR_BASE = 0x2E9B1C;
        public const Int32 CHARACTER_BASE = 0x004D2B30;
        public const Int32 ACTORS_SPAWNED = 0x290; //int
        public const Int32 ACTORS = 0x294;
        public const Int32 ACTOR_BASE = 0x0;
        public const Int32 ACTOR_STATS = 0x8; //Pointing to Stats
        public const Int32 ACTOR_CURRENT_HEALTH = 0x150; //float
        public const Int32 ACTOR_MAX_HEALTH = 0x154; //float
        public const Int32 ACTOR_POSITION_X = 0x1B0; //float
        public const Int32 ACTOR_POSITION_Y = 0x1B4; //float
        public const Int32 ACTOR_POSITION_Z = 0x1B8; //float
    }

    struct Actor
    {
        public Int32 pActor;
        public Int32 pStats;

        public float CurrentHealth;
        public float MaxHealth;
        public float PositionX;
        public float PositionY;
        public float PositionZ;
    }
}
