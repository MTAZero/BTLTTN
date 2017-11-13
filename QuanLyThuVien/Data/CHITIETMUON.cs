namespace QuanLyThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETMUONS")]
    public partial class CHITIETMUON
    {
        public int ID { get; set; }

        public int? PHIEUMUONID { get; set; }

        public int? DAUSACHID { get; set; }

        public int? TRANGTHAI { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }

        public virtual PHIEUMUON PHIEUMUON { get; set; }
    }
}
