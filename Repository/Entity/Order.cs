using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        [Required]
        //public int Payment { get; set; }
        public string AddressToSend { get; set; }
        public ICollection<Tray> Treis { get; set; }
        [Required]
        //public int PriceSum { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ExecutionDate { get; set; }///תאריך בו בוצע ההזמנה
        //public Order()
        //{

        //}
        //public Order(int clientId, int Payment, string address, List<Tray> Treis, int PriceSum, bool IsCompleted, DateTime OrderDate, DateTime ExecutionDate, Client client)
        //{
        //    this.ClientId = clientId;
        //    this.Payment = Payment;
        //    this.AddressToSend = address;
        //    this.Treis = new List<Tray>();
        //    this.PriceSum = PriceSum;
        //    this.IsCompleted = IsCompleted;
        //    this.OrderDate = OrderDate;
        //    this.ExecutionDate = ExecutionDate;
        //    Client = client;
        //}
    }
}
