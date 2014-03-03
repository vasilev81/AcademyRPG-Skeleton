

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private const int currentQuantity = 2;
        public Rock(int hitPoints, Point position) : base(position, 0)
        {
            this.HitPoints = hitPoints;
            
        }
        public int Quantity
        {
            get
            {
                return this.HitPoints / currentQuantity;
            }
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }
    }
}
