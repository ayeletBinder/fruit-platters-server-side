using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client client { get; set; }

        public int TrayId { get; set; }
        [ForeignKey("TrayId")]
        public Tray tray { get; set; }
        public string? Response { get; set; } //מחרוזת של הניתוב לתמונה
        public int? Rating { get; set; } //דירוג

        //public Comment()
        //{

        //}
        //public Comment( int ClientId, int TrayId, string image, string response, int rating, Client client, Tray tray)
        //{
        //    this.ClientId = ClientId;
        //    this.TrayId = TrayId;
        //    Image = image;
        //    Response = response;
        //    Rating = rating;
        //    this.client = client;
        //    this.tray = tray;
        //}
    }
}
