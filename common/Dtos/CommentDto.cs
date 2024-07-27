using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class CommentDto
    {
            [Key]
            public int Id { get; set; }
            public int OrderId { get; set; }
            public string? Image { get; set; } //מחרוזת של הניתוב לתמונה
            public string? Response { get; set; } //מחרוזת של הניתוב לתמונה
            public int? Rating { get; set; } //דירוג

            //public CommentDto()
            //{

            //}
            //public CommentDto(int orderId, string image, string response, int rating)
            //{
            //    OrderId = orderId;
            //    Image = image;
            //    Response = response;
            //    Rating = rating;
            //}
    }
}
