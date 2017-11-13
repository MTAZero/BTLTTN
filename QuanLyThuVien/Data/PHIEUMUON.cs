namespace QuanLyThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUMUONS")]
    public partial class PHIEUMUON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUMUON()
        {
            CHITIETMUONS = new HashSet<CHITIETMUON>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUON { get; set; }

        public int? DOCGIAID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONS { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }
    }
}
