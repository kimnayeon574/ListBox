using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TextCheck();
        }

        private void TextCheck()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
            else
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
        }

        private void txtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                TextCheck();
                e.Handled = true; // 소리를 안나게 하는 코드
            }
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbView.SelectedItem;
        }
    }
}
