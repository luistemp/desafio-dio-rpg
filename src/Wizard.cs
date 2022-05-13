namespace desafio_dio_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {

        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bônus de " + bonus;
            }
            else
            {
                return this.Name + " Lançou magia com força fraca com bônus de " + bonus;
            }
        }
    }
}