using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Tag
    {
        public Tag()
        {
            this.Recipes = new HashSet<RecipeTag>();
        }
        
        public int TagId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RecipeTag> Recipes { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}