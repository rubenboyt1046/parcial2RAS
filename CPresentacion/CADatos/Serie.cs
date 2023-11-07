namespace CADatos
{
    using System;
    using System.Collections.Generic;

    public partial class Serie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serie()
        {
            this.Serie = new HashSet<Serie>();
        }

        public int id { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string director { get; set; }
        public int duracion { get; set; }
        public System.DateTime fechaestreno { get; set; }
        public short estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serie> Serie{ get; set; }
    }
}