using HeroesVsMonster.Models.Maps;
using HeroesVsMonster.Models.Properties.Statistics;

namespace HeroesVsMonster.Models.Characters
{
    public abstract class Character
    {
        public event Action<Character>? DieEvent;
        private int _currentHp;
        private int _currentMp;
        protected Stats Stats { get; }
        public Character(string sprite)
        {
            Stats = new Stats();
            Sprite = sprite;
        }
        public int CurrentHp { get { return _currentHp; } private set { _currentHp = value < 0 ? 0 : value > GetStatValue(StatType.Hp) ? GetStatValue(StatType.Hp) : value; } }
        public int CurrentMp { get { return _currentMp; } private set { _currentMp = value < 0 ? 0 : value > GetStatValue(StatType.Mp) ? GetStatValue(StatType.Mp) : value; } }
        public Position Position { get; set; }
        public string Sprite { get; set; }
        public int Hp => GetStatValue(StatType.Hp);
        public int Mp => GetStatValue(StatType.Mp);
        public int Strenght => GetStatValue(StatType.Strenght);
        public int Inteligence => GetStatValue(StatType.Inteligence);
        public int Defence => GetStatValue(StatType.Defence);
        public int Resistance => GetStatValue(StatType.Resistance);
        public int Speed => GetStatValue(StatType.Speed);
        public bool IsAlive => CurrentHp > 0;
        public virtual void Attack(Character target)
        {
            if (!target.IsAlive)
                target.DieEvent?.Invoke(this);
        }
        public void TakeDamage(int amount)
        {
            if (amount < 0)
                return;
            CurrentHp -= amount;
        }
        public void UseMp(int amount)
        {
            if (amount < 0)
                return;
            CurrentMp -= amount;
        }
        public void RegenHp(int amount)
        {
            if (amount < 0)
                return;
            CurrentHp += amount;
        }
        public void RegenMp(int amount)
        {
            if (amount < 0)
                return;
            CurrentMp += amount;
        }
        public void FullRegen()
        {
            CurrentHp = GetStatValue(StatType.Hp);
            CurrentMp = GetStatValue(StatType.Mp);
        }
        public virtual int GetStatValue(StatType stat)
        {
            return Stats[stat];
        }
        public override string ToString()
        {
            return $"Hp : {CurrentHp}\n" +
                   $"Mp : {CurrentMp}\n" +
                   $"Str : {Strenght}\n" +
                   $"Int : {Inteligence}\n" +
                   $"Def : {Defence}\n" +
                   $"Res : {Resistance}\n" +
                   $"Vit : {Speed}";
        }
    }
}
