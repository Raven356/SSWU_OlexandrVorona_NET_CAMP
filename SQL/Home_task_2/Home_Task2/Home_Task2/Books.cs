//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_Task2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime YearOfCreation { get; set; }
        public int Amount { get; set; }
        public int PublisherId { get; set; }
        public int GenreId { get; set; }
    
        public virtual Publisher Publisher { get; set; }
        public virtual Genre Genre { get; set; }
    }
}