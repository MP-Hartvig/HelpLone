using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    public class Wizard : ICharacter, IMagicSpell, ITeleport
    {
        public void Fight() { }
        public void Heal() { }
        public void Die() { }

        public void ThrowFrostNova() { }
        public void MagicMissile() { }

        public void Teleport() { }
    }
}
