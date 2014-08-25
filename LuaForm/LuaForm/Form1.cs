using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using luanet;
using LuaInterface;
using Lua511;
using LuaForm;

namespace LuaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Lua lua = new Lua();
            String _ejecutar = txt_text.Text;
            lua.DoString(_ejecutar);
        }
    }
}
