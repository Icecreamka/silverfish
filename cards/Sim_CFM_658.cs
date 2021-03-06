using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_658 : SimTemplate //* Backroom Bouncer
	{
		// Whenever a friendly minion dies, gain +1 Attack.

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            if (m.own == diedMinion.own)
            {
                int diedMinions = m.own ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
                if (diedMinions != 0)
                {
                    p.minionGetBuffed(m, diedMinions, 0);
                }
            }
        }
    }
}