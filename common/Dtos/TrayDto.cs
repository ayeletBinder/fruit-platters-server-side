using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class TrayDto
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public int Size { get; set; }
            [Required]
            public int Price { get; set; }

            //public string? Color { get; set; } //שדה זה לא חובה אם לא משלימים ברירת מחדל חום
            //public TrayDto()
            //{

            //}
            //public TrayDto(int size, int price, string color)
            //{
            //    this.Size = size;
            //    this.Price = price;
            //    this.Color = color;
            //}
        }
    }

