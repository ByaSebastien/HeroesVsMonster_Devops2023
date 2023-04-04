using HeroesVsMonster.Models.Properties.Statistics;

namespace HeroesVsMonster.Models.Properties.Stuff
{
    public class Equipments
    {
        private Dictionary<EquipmentType, Equipment?> _equipments;

        public Equipments()
        {
            _equipments = new Dictionary<EquipmentType, Equipment?>();
        }

        public Equipment? this[EquipmentType type]
        {
            get => _equipments.ContainsKey(type) ? _equipments[type] : null;
            set
            {
                if (!_equipments.ContainsKey(type))
                    _equipments.Add(type, null);
                else
                    _equipments[type] = value;
            }
        }

        public int GetStatValue(StatType stat)
        {
            return _equipments.Sum(e => e.Value is null ? 0 : e.Value.Stats[stat]);
        }
    }
}
