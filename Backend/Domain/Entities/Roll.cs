using Domain.Common;
//using System.Reflection.Metadata;

namespace Domain.Entities
{
    public class Roll: Entity
    {
        public string RollDescription { get; set; }
        public Roll(string rollDescription)
        {
            this.RollDescription = rollDescription;
        }
    }
}
