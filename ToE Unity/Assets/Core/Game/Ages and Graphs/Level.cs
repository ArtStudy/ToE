using Assets.Core.Levels;
using Assets.Core.Levels.Questions;
using Assets.Core.Volutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Core.Game.Ages_and_Graphs
{
    class Level : ILevel
    {
        public int IDLevel { get; }
        public string NameLavel { get; }

        public Money Price { get; }
        public Money Remuneration { get; }

        public IEntranceTest EntranceTest { get; }
        public IPassageLevel PassageLevel { get; }
        public IBossFight BossFight { get; }

        public IQuestion[] QuestionsLevel { get; }
        public StateLevel StateLevel { get; }
    }
}
