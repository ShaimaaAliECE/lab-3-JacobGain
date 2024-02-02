using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {

        public Tool(string description) : base(description) { }

        public abstract void DoAction();

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
        }

    }
}
