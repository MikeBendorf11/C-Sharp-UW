<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="WingtipToys.AddToCart" %>

<%--This temp page is launched from the AddToCart links on the product pages
    This page gets just redirected to ShoppingCart.aspx using the code behind
    Why is it necessary?
    Could we have just added the code behind from AddToCart directly into 
    ShoppingCart.aspx directly?
    Or what advantages does it represent apart from it throwing an exception
    saying "you can't have a shopping card without a productID"
    Couldn't we have just shown directly and empty card at ShoppingCart.aspx instead?
     --%>
