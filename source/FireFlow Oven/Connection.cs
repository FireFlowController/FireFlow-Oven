using System;
using System.Windows.Forms;

namespace FireFlow_Oven {
    public partial class Connection : Form {
        public Oven MainForm;

        public Connection() {
            InitializeComponent();
            Update_Com_Ports_List();
        }

        private void Button_Connect_Click(object sender, EventArgs e) {
            if (ConnectionsListBox.SelectedIndex != -1) {
                string str = ConnectionsListBox.Items[ConnectionsListBox.SelectedIndex].ToString();
                try {
                    MainForm.Attempt_Connect_To_Port(str);
                    if (MainForm.Com_Port_Connected) {
                        MessageBox.Show("You are now connected!\nThis window will close.");
                        this.Close();
                    }
                } catch {
                    MainForm.Connection_Close();
                    MessageBox.Show("Connection Failed", "Responce Time Out Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
                MessageBox.Show("Please Select a port to connect to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Button_Refresh_Connection_Click(object sender, EventArgs e) {
             Update_Com_Ports_List();
        }

        private void Update_Com_Ports_List() {
            ConnectionsListBox.Items.Clear();
            foreach (string str in comLib.GetPortNames())
                ConnectionsListBox.Items.Add(str);
        }

    }
}
