//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTable()
        {
            this.ApplicationTable = new HashSet<ApplicationTable>();
        }
    
        public int id_user { get; set; }
        public string surname_user { get; set; }
        public string name_user { get; set; }
        public string patronymic_user { get; set; }
        public string email_user { get; set; }
        public string password_user { get; set; }
        public Nullable<int> id_role { get; set; }
        public string phone_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationTable> ApplicationTable { get; set; }
        public virtual RoleTable RoleTable { get; set; }
    }
}
