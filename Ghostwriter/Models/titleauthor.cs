//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel;

namespace Ghostwriter.Models
{
    using System;
    using System.Collections.Generic;

    public partial class titleauthor
    {
        [DisplayName("Author ID")]
        public string au_id { get; set; }
        [DisplayName("Title ID")]
        public string title_id { get; set; }
        [DisplayName("Order")]
        public Nullable<byte> au_ord { get; set; }
        [DisplayName("Royalty")]
        public Nullable<int> royaltyper { get; set; }

        [DisplayName("Author")]
        public virtual author author { get; set; }
        [DisplayName("Title")]
        public virtual title title { get; set; }
    }
}