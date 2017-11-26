using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class CartItem
    {
        //Since we have other properties with the id keyword 
        //    then we use the [Key] attribute
        [Key]
        //Groups instances of same ProductID
        //A key is necessary for every table, so no other?
        //Option: each Product has a serial and Quantity is calculated separately
        //by the instances of the same ProductID in a cart
        public string ItemId { get; set; }

        //Cart tied to which guid user or registered user
        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        //a CartItem is a product
        public virtual Product Product { get; set; }

    }
}