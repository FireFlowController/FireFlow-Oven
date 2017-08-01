using System;
using System.Windows.Forms;

namespace FireFlow_Oven {
    public partial class License : Form {
        public License() {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e) {
            richTextBox1.Text = "FireFlow Oven is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version." +
                "\n\nFireFlow Oven is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the GNU General Public License for more details." +
                "\n\nYou should have received a copy of the GNU General Public License along with FireFlow Oven.If not, see: http://www.gnu.org/licenses/";
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) => System.Diagnostics.Process.Start(e.LinkText);
        private void btn_Close_Click(object sender, EventArgs e) => this.Close();
        public void SetTitle(string Title) => this.Text = Title;
        public void SetText(string Text) => richTextBox1.Rtf = Text;

    }
}
