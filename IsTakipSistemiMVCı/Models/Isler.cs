//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipSistemiMVCı.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Isler
    {
        public int isId { get; set; }
        public string isBaslik { get; set; }
        public string isAciklama { get; set; }
        public Nullable<int> isPersonelId { get; set; }
        public Nullable<System.DateTime> iletilenTarih { get; set; }
        public Nullable<System.DateTime> yapılanTarih { get; set; }
        public Nullable<int> isDurumId { get; set; }
        public string isYorum { get; set; }
        public Nullable<bool> isOkunma { get; set; }
    
        public virtual Durumlar Durumlar { get; set; }
        public virtual Personeller Personeller { get; set; }
    }
}
