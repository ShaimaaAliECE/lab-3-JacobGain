using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            board.UpdateTotalScore(Score);
            Console.WriteLine("Total score is updated to: " + board.TotalScore);
        }

    }
}
