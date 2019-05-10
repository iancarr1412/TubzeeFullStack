using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TubzeeFullStack
{
    public partial class Town
    {
        public Town()
        {
            Supplier = new HashSet<Supplier>();
        }

        [Display(Name = "Town Id")]
        public int TownId { get; set; }
        public int? CountyId { get; set; }
        [Display(Name = "Country")]
        public int? CountryId { get; set; }
        [Display(Name = "Town")]
        public string TownName { get; set; }
        [Display(Name = "Description")]
        public string TownDescripton { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
