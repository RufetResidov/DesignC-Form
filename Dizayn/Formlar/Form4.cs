using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizayn.Formlar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            button1.ForeColor = ThemeColor.SecondaryColor;
            button2.ForeColor = ThemeColor.SecondaryColor;
            button3.ForeColor = ThemeColor.SecondaryColor;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
