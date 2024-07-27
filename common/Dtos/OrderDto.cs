using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class OrderDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Payment { get; set; }
        public string AddressToSend { get; set; }
        [Required]
        public int PriceSum { get; set; }
        public bool IsCompleted { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime ExecutionDate { get; set; }///תאריך בו בוצע ההזמנה
        //public OrderDto()
        //{

        //}
        //public OrderDto(int clientId, int Payment, string address, int PriceSum, bool IsCompleted, DateTime OrderDate, DateTime ExecutionDate)
        //{
        //    this.Payment = Payment;
        //    this.AddressToSend = address;
        //    this.PriceSum = PriceSum;
        //    this.IsCompleted = IsCompleted;
        //    this.OrderDate = OrderDate;
        //    this.ExecutionDate = ExecutionDate;
        //}
    }
}