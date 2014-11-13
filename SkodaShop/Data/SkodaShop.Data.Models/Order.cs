namespace SkodaShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        private ICollection<Part> parts;

        public Order ()
        {
            this.parts = new HashSet<Part>();
        }

        [Key]
        public int Id { get; set; }

        public int PartId { get; set; }

        public virtual ICollection<Part> Parts
        {
            get
            {
                return this.parts;
            }
            set
            {
                this.parts = value;
            }
        }
    }
}