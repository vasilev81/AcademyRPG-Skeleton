
namespace AcademyRPG
{ 
    public class House : StaticObject
    {
        private const int initialHitPoints = 500;

        public House(Point position, int owner) : base(position, owner)
        {
            this.HitPoints = initialHitPoints;
        }
        
    }
}
