namespace QuanLyThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAUSACHS")]
    public partial class DAUSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAUSACH()
        {
            CHITIETMUONS = new HashSet<CHITIETMUON>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public string TACGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONS { get; set; }
    }
}
