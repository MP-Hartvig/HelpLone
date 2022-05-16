using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    public class Barbarian : ICharacter, IMeleeSpell
    {
        public void Fight() { }
        public void Heal() { }
        public void Die() { }

        public void Bash() { }
        public void Cleave() { }
        public void Slash() { }
    }
}
