namespace HeroesVsMonster.Models.Properties.Inventory
{
    public class Items
    {
        private Dictionary<Item, int> _items;

        public Items()
        {
            _items = new Dictionary<Item, int>();
        }

        public int this[Item item]
        {
            get => _items.ContainsKey(item) ? _items[item] : 0;
            set
            {
                if (!_items.ContainsKey(item))
                    _items.Add(item, 0);

                _items[item] = value < 0 ? 0 : value;
            }
        }

        public void Append(Item item, int amount)
        {
            if (!_items.ContainsKey(item))
                _items.Add(item, 0);

            this[item] += amount;
        }

        public void Withdraw(Item item, int amount)
        {
            if (!_items.ContainsKey(item))
                return;

            this[item] -= amount;
        }
    }
}
