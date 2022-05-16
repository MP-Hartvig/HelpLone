using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    public class Witch : ICharacter, IShield, ITeleport
    {
        public void Fight() { }
        public void Heal() { }
        public void Die() { }

        public void RaiseShield() { }
        public void ShieldGlare() { }

        public void Teleport() { }
    }
}
