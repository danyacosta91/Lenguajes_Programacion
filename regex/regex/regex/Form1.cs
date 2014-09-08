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
        Regex _parentesis = new Regex(@"[a-z0-9\n\s]*\([a-z0-9\n\s]*\)[a-z0-9\n\s]*$");
        Regex _email = new Regex(@"^[a-z0-9_.]+@[a-z0-9-]+\.[a-z]{2,4}$");
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

        private void btn_parentesis_Click(object sender, EventArgs e)
        {
            if (_parentesis.IsMatch(txt_parentesis.Text))
                MessageBox.Show("Es válida!");
            else
                MessageBox.Show("No es válida!");
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            if (_email.IsMatch(txt_email.Text))
                MessageBox.Show("Es válida!");
            else
                MessageBox.Show("No es válida!");
        }
    }
}
