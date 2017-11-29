				11/25/2017 12:13:05 PM

**Assignment 08 - Child Forms, Menus**

This assignment has just started. It is better to keep controls inside of other containers then it becomes easier and more organized to handle group events.
____				

				11/25/2017 12:13:05 PM

**Database Connections** 

I'm still wrapping things around in my head regarding how all this pages connect together.

We know that Site.Master has the main `hmtl/ASP` layout. It contains an `asp:ContentPlaceHolder` that most of the other .aspx files will use to display variable information.

Now, I'm trying to understand how both the `ShoppingCart.aspx` and the codeBehind interact with both `ShoppingActions.cs`(under the logic folder) and `CartItem.cs` model(which interacts with the new portion of the db called `ShoppingCartItems` under `ProductContext.cs`)
____

				11/23/2017 10:45:37 AM 

**Branching out and Exercise 6 WPF** 

I started a new branch `cmdwpf` and included a few corrections to my version of the Vending machine. The most important change is to
be able to remove an object from a list by matching a property(instead of the object itself). This was possible by using `LINQ` and the type `IEnumerable<T>`.

Apart from that, I integrated the console library developed for the class. I also created the base GUI for the vending machine but I still have to implement the event handlers.


