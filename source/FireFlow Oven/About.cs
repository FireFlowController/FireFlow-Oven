using System;
using System.Windows.Forms;

namespace FireFlow_Oven {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_License_Click(object sender, EventArgs e) {
            License form = new License();
            form.ShowDialog();
        }

        private void btn_Credit_Click(object sender, EventArgs e) {
            Credits form = new Credits();
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/FireFlowController/FireFlow-Oven");
        }
    }
}
