using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GorgKaimon
{
    public partial class Console : Form
    {
        Size_ size__;
        public string command_ { get; set; }
        public Console()
        {
            InitializeComponent();
            HandleCreated += Created;
            ClientSizeChanged += ChangeSize;
            size__ = new Size_(this.Height, this.Width);
            command_ = "";
            //Timer time_ = new Timer();

        }

        private void ChangeSize(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            size__.W_H = (sender as Console).Height;
            size__.W_W = (sender as Console).Width;
            
            size__.Refresh();
            Refresh();
            //listBox1.Controls[0].Show();
            //tb.Refresh();
        }             
        

        private void Created(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            size__.Controls_.Add(listBox1 as Control);
            size__.Controls_procent.Add(new int[] { 0, 0, 100, 100 });
            //
            TextBox tb = new TextBox();
            tb.TabIndex = 2;
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.ToolTipTitle = "Консоль";
            tt.SetToolTip(tb, "Введите команду консоли..");
            tb.BackColor = Color.DarkGray;
            tb.ForeColor = Color.WhiteSmoke;            
            //tb.MouseMove += Tb_MouseMove;
            tb.KeyDown += Tb_KeyDown;
            listBox1.Controls.Add(tb);
            //
            size__.Controls_.Add(tb);
            //listBox1.Items.Add(tb);
            size__.Controls_procent.Add(new int[] { 0, 0, 100, 100 });
            //listBox1.SelectedIndex = 0;
            tb.Refresh();
            size__.Refresh();
            Refresh();
        }

        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("Test");
            if(e.KeyCode == Keys.Enter)
            {
                TextBox tb_command = sender as TextBox;
                string[] str;
                if ((str = tb_command.Text.Trim().Split('-').ToArray()).Length > 1)
                {
                    command_ = tb_command.Text;
                }
            }
        }

        private void Tb_MouseMove(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("Test");
        }
    }
}
