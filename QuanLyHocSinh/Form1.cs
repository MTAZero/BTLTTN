using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadDgv();
        }

        private void LoadDgv()
        {
            var a = new List<dynamic>
            {
                new
                {
                    STT = 1,
                    HoTen = "Bùi Xuân Thủy"
                },
                new
                {
                    STT = 2,
                    HoTen = "Phạm Thị Q"
                },
                
                new
                {
                    STT = 3,
                    HoTen = "Đỗ Tiến Đạt"
                },
                new
                {
                    STT = 4,
                    HoTen = "Trần Tuấn Phong"
                }
            };

            dgva.DataSource = a;
        }

        private void dgva_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtHoVaTen.Text = dgva.SelectedRows[0].Cells["HoTen"].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
