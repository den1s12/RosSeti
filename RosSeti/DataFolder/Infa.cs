//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RosSeti.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Infa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Infa()
        {
            this.Zakaz = new HashSet<Zakaz>();
        }
    
        public int IdInfa { get; set; }
        public string NomerDogovora { get; set; }
        public string EmailPokup { get; set; }
        public string PhonePokup { get; set; }
        public string Zhite { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}