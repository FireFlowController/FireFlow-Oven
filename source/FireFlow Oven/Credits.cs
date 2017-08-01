using System;
using System.Windows.Forms;

namespace FireFlow_Oven {
    public partial class Credits : Form {
        public Credits() {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e) {
            textBox1.Text = "Tselepis Stefanos";
        }

        private void btn_Close_Click(object sender, EventArgs e) => this.Close();
    }
}
