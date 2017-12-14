using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class OrderDetail
    {
        //why don't we have attributes here
        //no user validation necessary?
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string Username { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

    }
}