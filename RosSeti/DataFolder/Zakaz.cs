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
    
    public partial class Zakaz
    {
        public int IdZakaz { get; set; }
        public int IdCable { get; set; }
        public string Address { get; set; }
        public int IdInfa { get; set; }
    
        public virtual Cabel Cabel { get; set; }
        public virtual Infa Infa { get; set; }
    }
}
