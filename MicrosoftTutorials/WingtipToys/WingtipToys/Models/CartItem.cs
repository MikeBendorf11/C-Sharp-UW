using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class CartItem
    {
        //Since we have other properties with the id keyword 
        //    then we use the [Key] attribute
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        //does this mean that a CartItem obj can have a list 
        //of specific products?? and the virtual means the list
        //of product will be defined overriden by another method
        public virtual Product Product { get; set; }

    }
}