using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Movie
{
    public partial class ConnectionError : Form
    {
        private Exception ex;
        public ConnectionError(Exception ex)
        {
            InitializeComponent();
            this.ex = ex;
        }

        private void ConnectionError_Load(object sender, EventArgs e)
        {
            label1.Text = ex.Message;
        }
    }
}
