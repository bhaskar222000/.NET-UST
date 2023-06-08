using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparatorEx
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Name} {Score}";
        }
    }
   
}


