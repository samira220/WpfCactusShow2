//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfCactusShow2.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cactus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cactus()
        {
            this.Show_cactus = new HashSet<Show_cactus>();
        }
    
        public int Id_cactus { get; set; }
        public Nullable<int> Id_kind { get; set; }
        public string Origin { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Kind Kind { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Show_cactus> Show_cactus { get; set; }
    }
}