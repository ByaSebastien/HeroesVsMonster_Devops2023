namespace HeroesVsMonster.Models.Properties.Inventory
{
    public abstract class Item
    {
        private string _name;
        private string _description;

        public Item(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }
    }
}
