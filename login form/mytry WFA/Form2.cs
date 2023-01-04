using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytry_WFA
{
    public partial class frm_about : Form
    {
        public string name { get; set; }
        public frm_about(string username)
        {
            InitializeComponent();
            this.name = username;
        }

        

        private void frm_about_Load(object sender, EventArgs e)
        {
            lbl_name.Text = $" welcome to our app {  name }   ";
            
        }
    }
}
