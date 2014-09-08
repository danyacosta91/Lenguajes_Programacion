using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regex
{
    public partial class Form1 : Form
    {
        #region Variables
        Regex _cString = new Regex(@"(\""[a-zA-Z0-9,!#$%&/()=?¡\+*-/_.<>\s]*\""$)|(\""[a-zA-Z0-9,!#$%&/()=?¡\+*-/_.<>\s]*\\""[a-zA-Z0-9,!#$%&/()=?¡\+*-/_.<>\s]*\""$)");
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_cString.IsMatch(txt_c.Text))
                MessageBox.Show("Es válida!");
            else
                MessageBox.Show("No es válida!");
        }
    }
}
