using System;

namespace GettingUpTrainer
{
    struct GameOffsets
    {
        public const Int32 ACTORS_SPAWNED = 0x2E9B18; //int
        public const Int32 ACTOR_BASE = 0x2E9B1C;
        //Stats
        public const Int32 ACTOR_STATS = 0x8; //Pointing to Stats
        public const Int32 ACTOR_CURRENT_HEALTH = 0x150; //float
        public const Int32 ACTOR_MAX_HEALTH = 0x154; //float
        public const Int32 ACTOR_POSITION_X = 0x1B0; //float
        public const Int32 ACTOR_POSITION_Y = 0x1B4; //float
        public const Int32 ACTOR_POSITION_Z = 0x1B8; //float
    }
}
