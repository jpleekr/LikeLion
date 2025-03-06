using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    abstract class Character
    {
        public string strName { get; set; }
        public int iAttack { get; set; }
		public int iHP { get; set; }

        public abstract void SetDamage(int aAttack);

        public abstract void Render();

	}
}
