//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Network.DAL.EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.MembersOfGroup = new HashSet<MembersOfGroup>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<int> Number { get; set; }
        public System.Guid HeadId { get; set; }
        public string Specialization { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersOfGroup> MembersOfGroup { get; set; }
        public virtual User_sPersonalData User_sPersonalData { get; set; }
    }
}
