using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Tray
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public int Price { get; set; }
        public string? Image { get; set; } //מחרוזת של הניתוב לתמונה
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public ICollection<Fruit> Fruits { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int NumHeart { get; set; }
        public string? Color { get; set; } //שדה זה לא חובה אם לא משלימים ברירת מחדל חום
        //public Tray()
        //{

        //}
        //public Tray(int size, int price, string color, ICollection<Fruit> Fruits,int numheart, ICollection<Comment> Comments)
        //{
        //    this.Size = size;
        //    this.Price = price;
        //    this.Color = color;
        //    this.Fruits = new List<Fruit>();
        //    this.NumHeart = numheart;
        //    this.Comments = new List<Comment>();
        //}
    }
}
