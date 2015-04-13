namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        private const int minAttack = 1;
        private const int maxAttack = 10;

        public AddAttackWhenSkip(int attack)
        {
            this.AttackToAdd = attack;
        }

        public int AttackToAdd
        {
            get { return this.attackToAdd; }
            set
            {
                if (value < minAttack || value > maxAttack)
                {
                    throw new ArgumentOutOfRangeException("rounds", String.Format("The attack should be greater than or equal to {0} and less than or equal to {1}", minAttack, maxAttack));
                }
                this.attackToAdd = value;
            }
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }
            
            skipCreature.PermanentAttack += this.AttackToAdd;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.AttackToAdd);
        }
    }
}
