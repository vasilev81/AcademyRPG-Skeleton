

namespace AcademyRPG
{
    using System;
    public class Ninja : Character, IFighter, IGatherer, IEnvunerable
    {
        private const int ninjaHitPoints = 1;
        private const int ninjaInitialAttackPoints = 0;
        private const int currentQuantityMultiplier = 2;

        private int attackPoints;
        private int deffensePoints;
        public Ninja(string name,Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = ninjaHitPoints;
            this.AttackPoints = ninjaInitialAttackPoints;
            this.DefensePoints = deffensePoints;
            if(this.Owner == 0)
            {
                throw new ArgumentException("Ninja should have an owner");
            }
            if(this.Position == null)
            {
                throw new ArgumentNullException("Ninja shoul have position");
            }
            if(this.Name == string.Empty)
            {
                throw new ArgumentException("Ninja should have a name");
            }
        }
        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.deffensePoints;
            }
            private set
            {
                this.deffensePoints = value;
            }
        }

        public int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets)
        {
            int highestHitPoints = 0;
            int positionWithHighestHitPoints = -1;
            for (int i = 0; i < availableTargets.Count; i++)
			{
			 if(availableTargets[i].HitPoints > highestHitPoints && availableTargets[i].IsDestroyed == false 
                 && availableTargets[i].Owner != this.Owner 
                    && availableTargets[i].Owner != 0)
             {
                 highestHitPoints = availableTargets[i].HitPoints;
                 positionWithHighestHitPoints = i;
             }
			}
            return positionWithHighestHitPoints;
        }

        public bool TryGather(IResource resource)
        {
            if(resource.Type == ResourceType.Stone || resource.Type == ResourceType.Lumber)
            {
                if (resource.Type == ResourceType.Stone)
                {
                    this.AttackPoints += resource.Quantity * currentQuantityMultiplier;
                }
                else
                {
                    this.AttackPoints += resource.Quantity;
                }
                return true;
            }
            else { return false; }
        }
    }
}
