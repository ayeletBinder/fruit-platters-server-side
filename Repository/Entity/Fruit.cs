using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Fruit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Color { get; set; }
        //public bool IsAdditionalCharge { get; set; }  //תוספת תשלום
        [Required]
        public int SomeAdditional { get; set; }  // כמה תוספת? מי שלא בתוספת תשלום יהיה שווה לאפס
        public Boolean IsExists { get; set; }
        public ICollection<Tray> Trays { get; set;}

        //public Fruit(string name, string color, bool isAdditionalCharge, int someAdditional, bool isExists)
        //{
        //    Name = Name;
        //    Color = color;
        //    IsAdditionalCharge = isAdditionalCharge;
        //    SomeAdditional = someAdditional;
        //    IsExists = isExists;
        //}
        //public Fruit()
        //{

        //}
    }
}
