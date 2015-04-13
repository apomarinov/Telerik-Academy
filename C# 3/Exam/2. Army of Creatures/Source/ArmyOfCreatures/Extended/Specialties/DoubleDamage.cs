namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    class DoubleDamage : Specialty
    {
        private int rounds;

        private const int minRounds = 0;
        private const int maxRounds = 10;

        public DoubleDamage(int rounds)
        {
            if (rounds <= minRounds || rounds > maxRounds)
            {
                throw new ArgumentOutOfRangeException("rounds", String.Format("The number of rounds should be greater than {0} and less than or equal to {1}", minRounds, maxRounds));
            }

            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            this.rounds--;
            if (this.rounds >= 0)
            {
                return currentDamage * 2m;
            }
            else
            {
                return currentDamage;
            }
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
