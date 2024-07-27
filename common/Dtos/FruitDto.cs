using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class FruitDto
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Color { get; set; }
        [Required]
        public bool IsAdditionalCharge { get; set; }  //תוספת תשלום
        [Required]
        public int SomeAdditional { get; set; }  //כמה תוספת?

        //public FruitDto(string name, string color, bool isAdditionalCharge, int someAdditional)
        //{
        //    Name = Name;
        //    Color = color;
        //    IsAdditionalCharge = isAdditionalCharge;
        //    SomeAdditional = someAdditional;
        //}
        //public FruitDto()
        //{

        //}
    }
}
