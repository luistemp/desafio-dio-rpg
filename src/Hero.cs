namespace desafio_dio_rpg.src.Entities
{
    public class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}