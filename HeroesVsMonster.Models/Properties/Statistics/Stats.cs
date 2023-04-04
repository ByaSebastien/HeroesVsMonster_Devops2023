using HeroesVsMonster.Utils;

namespace HeroesVsMonster.Models.Properties.Statistics
{
    public class Stats
    {
        private Dictionary<StatType, int> _stats;

        public Stats()
        {
            _stats = new Dictionary<StatType, int>();
        }
        public Stats(DiceType dice, int nbThrows = 3, int nbToKeep = 3) : this()
        {
            Generate(dice, nbThrows, nbToKeep);
            ApplyModifier();
        }

        public int this[StatType stat]
        {
            get => _stats.ContainsKey(stat) ? _stats[stat] : 0;
            private set
            {
                if (!_stats.ContainsKey(stat))
                    _stats.Add(stat, 0);

                _stats[stat] = value < 0 ? 0 : value;
            }
        }

        public void Generate(DiceType dice = DiceType.D6, int nbThrows = 3, int nbToKeep = 3)
        {
            foreach (StatType stat in Enum.GetValues<StatType>())
            {
                if (stat == StatType.Hp || stat == StatType.Mp) continue;
                this[stat] = Dice.Throws(dice, nbThrows, nbToKeep);
            }
            this[StatType.Hp] = this[StatType.Strenght] + this[StatType.Defence];
            this[StatType.Mp] = this[StatType.Inteligence] + this[StatType.Resistance];
        }
        public void Append(StatType stat, int amount)
        {
            if (!_stats.ContainsKey(stat))
                _stats.Add(stat, 0);

            this[stat] += amount;
        }

        public void Withdraw(StatType stat, int amount)
        {
            if (!_stats.ContainsKey(stat))
                return;

            this[stat] -= amount;
        }

        public void ApplyModifier()
        {
            foreach (KeyValuePair<StatType, int> kvp in _stats)
            {
                Modifier(kvp.Key);
            }
        }

        public void Modifier(StatType stat)
        {
            int QttStat = this[stat];
            if (QttStat > 15) this[stat] += 3;
            else if (QttStat > 10) this[stat] += 2;
            else if (QttStat > 5) this[stat] += 1;
        }
    }
}
