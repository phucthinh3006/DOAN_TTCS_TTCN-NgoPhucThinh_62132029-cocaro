using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Game
{
    public partial class FormName : Form
    {
        int _mod;
        string nameP1;
        string nameP2;
        
        
        // FormPlayGame formPlayGame;
        public int Mod { get => _mod; set => _mod = value; }
        public string NameP1 { get => nameP1; set => nameP1 = value; }
        public string NameP2 { get => nameP2; set => nameP2 = value; }
        //   public FormMenu FormMenu { get => _formMenu; }
        
        public FormName( int mod)
        {
            InitializeComponent();
            _mod = mod;
          
            
            loadForm();
            displayNof();
           
        }

        void displayNof()
        {
            if (!isValidName(tbPlayer1.Text) || !isValidName(tbPlayer2.Text))
            {
                lbNof.Visible = true;
                btnStartGame.Enabled = false;
            }
            else
            {
                btnStartGame.Enabled = true;
                lbNof.Visible = false;
            }
        }

        public void loadForm()
        {
            FormMenu _formMenu = new FormMenu();
            if (Mod == 1)
            {
                tbPlayer1.Text = "tên";
                tbPlayer1.Enabled = false;
            }
            else
            {
                nameP1 = _formMenu.NameP1;
                tbPlayer1.Text = nameP1;
            }
            nameP2 = _formMenu.NameP2;
            tbPlayer2.Text = nameP2;
        }





        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            FormMenu _formMenu = new FormMenu();
            if (Mod == 2)
                _formMenu.NameP1 = nameP1 = tbPlayer1.Text;
            else
                nameP1 = tbPlayer1.Text;
            _formMenu.NameP2 = nameP2 = tbPlayer2.Text;

            FormPlayGame formPlayGameNew = new FormPlayGame(Mod, _formMenu, this);
            
            formPlayGameNew.Show();
            formPlayGameNew.Enabled = true;
            _formMenu.Hide();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void FormName_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu _formMenu = new FormMenu();
            if (Mod == 2)
                _formMenu.NameP1 = nameP1 = tbPlayer1.Text;
            _formMenu.NameP2 = nameP2 = tbPlayer2.Text;
            _formMenu.Enabled = true;
            
        }

        private void BtnStartGame_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Khaki;
        }

        private void BtnStartGame_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.BurlyWood;
            Thread.Sleep(50);
        }
        bool isValidName(string name)
        {
            if (name.Length > 10 || name.Length < 2)
                return false;
            char[] arrayChar = name.ToCharArray();
            foreach (char item in arrayChar)
            {
                if (((item < 'a' || item > 'z') && (item < 'A' || item > 'Z')) && item != ' ' && (item < '0' || item > '9'))
                    return false;
            }
            return true;
        }

        private void TbPlayer1_TextChanged(object sender, EventArgs e)
        {
            displayNof();
        }

        private void TbPlayer2_TextChanged(object sender, EventArgs e)
        {
            displayNof();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             MyConst._NumColumn = 9;
             MyConst._NumRow = 9;
            MyConst._ChessBoard_SizeHeight = 64;
            MyConst._ChessBoard_SizeWitdth = 64;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MyConst._NumColumn = 19;
            MyConst._NumRow = 19;
            MyConst._ChessBoard_SizeHeight = 32;
            MyConst._ChessBoard_SizeWitdth = 32;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MyConst._NumColumn = 21;
            MyConst._NumRow = 21;
            MyConst._ChessBoard_SizeHeight = 34;
            MyConst._ChessBoard_SizeWitdth = 34;
            
        }
    }
}
