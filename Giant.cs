
namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int initialAttaxkPoints = 150;
        private const int initialDeffensePoints = 80;
        private const int initioalHitPoints = 200;

        private int attackPoints;
        private int defensePoints;
        private bool hasStone;
        public Giant(string name, Point position, int owner = 0) : base(name, position, owner)
        {
            this.AttackPoints = initialAttaxkPoints;
            this.DefensePoints = initialDeffensePoints;
            this.HitPoints = initioalHitPoints;
            this.hasStone = false;
            
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


        public int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets)
        {
            int index = -1;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if(availableTargets[i].IsDestroyed != true && availableTargets[i].Owner != 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        public bool TryGather(IResource resource)
        {
            if(resource.Type == ResourceType.Stone)
            {
                if(hasStone == false)
                {
                    this.AttackPoints += 100;
                    this.hasStone = true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
