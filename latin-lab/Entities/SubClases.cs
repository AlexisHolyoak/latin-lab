//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace latin_lab.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubClases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubClases()
        {
            this.Servicios = new HashSet<Servicios>();
        }
    
        public int idSubClase { get; set; }
        public Nullable<int> idClase { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }
    
        public virtual Clases Clases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicios> Servicios { get; set; }
    }
}
