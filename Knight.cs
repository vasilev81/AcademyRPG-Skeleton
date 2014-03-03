

namespace AcademyRPG
{
    using System.Collections.Generic;
    public class Knight :Character, IFighter, INameable
    {
        private const int initioalAttackPoints = 100;
        private const int initialDefensePoints = 100;
        private const int initialHitPoints = 100;

        private int attackPoints;
        private int defensePoints;
        
        public Knight(string name, Point position, int owner) : base(name,position,owner)
        {
            this.AttackPoints = initioalAttackPoints;
            this.DefensePoints = initialDefensePoints;
            this.HitPoints = initialHitPoints;
           
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
                return this.defensePoints;
            }
            private set
            {
                this.defensePoints = value;
            }
        }
       

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            
            int index = -1;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].IsDestroyed != true && availableTargets[i].Owner != 0 
                    && availableTargets[i].Owner != this.Owner)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        
    }
}
