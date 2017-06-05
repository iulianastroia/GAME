
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{

    public partial class Aeroplanes_game : Form
    {
        int last_SCORE;

        GameLogci.Logic gamelogic;

        public Aeroplanes_game()
        {
            InitializeComponent();
            gamelogic = new GameLogci.Logic();
            gamelogic.initGameLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this game, you have to guess the positions chosen by the computer. If the guess is a correct one, an X will appear in the clicked box. Otherwise, a 0 will mark a wrong answer.", "How to play this game");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aeroplanes_game frm = new Aeroplanes_game();
            frm.Show();

            MessageBox.Show(last_SCORE.ToString(),"Latest score:");
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int i = Int32.Parse(b.Tag.ToString());
            b.Text = gamelogic.DoMyLogic(i);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (A1.Text == "X" || A2.Text == "X" || A3.Text == "X" || A4.Text == "X" || A5.Text == "X")
            {
                points += 10;
            }

            if (B1.Text == "X" || B2.Text == "X" || B3.Text == "X" || B4.Text == "X" || B5.Text == "X")
            {
                points += 10; 
            }

            if (C1.Text == "X" || C2.Text == "X" || C3.Text == "X" || C4.Text == "X" || C5.Text == "X")
            {
                points += 10; 
            }

            if (D1.Text == "X" || D2.Text == "X" || D3.Text == "X" || D4.Text == "X" || D5.Text == "X")
            {
                points += 10;  
            }

            if (E1.Text == "X" || E2.Text == "X" || E3.Text == "X" || E4.Text == "X" || E5.Text == "X")
            {
                points += 10; 
            }

            if (points != 50)
            {
                MessageBox.Show("Don't be too curious, you'll find out soon enough");
            }

            if ((E1.Text == "X" || E2.Text == "X" || E3.Text == "X" || E4.Text == "X" || E5.Text == "X") && (D1.Text == "X" || D2.Text == "X" || D3.Text == "X" || D4.Text == "X" || D5.Text == "X") && (C1.Text == "X" || C2.Text == "X" || C3.Text == "X" || C4.Text == "X" || C5.Text == "X") && (B1.Text == "X" || B2.Text == "X" || B3.Text == "X" || B4.Text == "X" || B5.Text == "X") && (A1.Text == "X" || A2.Text == "X" || A3.Text == "X" || A4.Text == "X" || A5.Text == "X"))
            {
                MessageBox.Show("And your score is...");
                MessageBox.Show(points.ToString());
            }

            last_SCORE = points;
        }
    } 
}
