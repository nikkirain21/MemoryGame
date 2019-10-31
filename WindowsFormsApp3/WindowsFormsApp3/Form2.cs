using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GameWindow : Form

    {
        


        //Variables
        //int score = 0; //Our Scores
        Random location = new Random(); //Selects a random value from X and Y list and assign a new location to each card
        List<Point> points = new List<Point>(); //List to hold cards points
        bool again = false; //Play again or no
        PictureBox PendingImage1; //Store first flipped card into this variable
        PictureBox PendingImage2;//----- Second -------------------------------
        public GameWindow(string cards)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scorecounter.Text = "0";
            label1.Text = "5";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer2.Start();
            timer1.Start();

            //babaguhin ko sana pics nito kaso parang hindi educational kapag yung pic about computer e, add ko na din sa file un if gusto mo un ung pics
            //gumawa din kase me deck of cards na computer related kaso mukhang di bagay?? so i stuck with fruits
            card1.Image = Properties.Resources.Card1;
            dupcard1.Image = Properties.Resources.Card1;
            card2.Image = Properties.Resources.Card2;
            dupcard2.Image = Properties.Resources.Card2;
            card3.Image = Properties.Resources.Card3;
            dupcard3.Image = Properties.Resources.Card3;
            card4.Image = Properties.Resources.Card4;
            dupcard4.Image = Properties.Resources.Card4;
            card5.Image = Properties.Resources.Card5;
            dupcard5.Image = Properties.Resources.Card5;
            card6.Image = Properties.Resources.Card6;
            dupcard6.Image = Properties.Resources.Card6;
            card7.Image = Properties.Resources.Card7;
            dupcard7.Image = Properties.Resources.Card7;
            card8.Image = Properties.Resources.Card8;
            dupcard8.Image = Properties.Resources.Card8;
            card9.Image = Properties.Resources.Card9;
            dupcard9.Image = Properties.Resources.Card9;
            card10.Image = Properties.Resources.Card10;
            dupcard10.Image = Properties.Resources.Card10;
            card11.Image = Properties.Resources.Card11;
            dupcard11.Image = Properties.Resources.Card11;
            card12.Image = Properties.Resources.Card12;
            dupcard12.Image = Properties.Resources.Card12;
        }



        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer - 1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                          
            }
           
        }
        //Change Card Value
        #region Cards

        private void Card1_Click_1(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = card1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dupcard1.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();

                }
            }
        }

        private void Dupcard1_Click_1(object sender, EventArgs e)
        {
            dupcard1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dupcard1.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    //timer3.Start();
                }
            }
        }

        private void Card2_Click_1(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card2.Enabled = false;
                    dupcard2.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard2_Click(object sender, EventArgs e)
        {
            dupcard2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card2.Enabled = false;
                    dupcard2.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card3_Click_1(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card3.Enabled = false;
                    dupcard3.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard3_Click(object sender, EventArgs e)
        {
            dupcard3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card3.Enabled = false;
                    dupcard3.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card4.Enabled = false;
                    dupcard4.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard4_Click(object sender, EventArgs e)
        {
            dupcard4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card4.Enabled = false;
                    dupcard4.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card5_Click_1(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dupcard5.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard5_Click(object sender, EventArgs e)
        {
            dupcard5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dupcard5.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card6_Click_1(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dupcard6.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard6_Click(object sender, EventArgs e)
        {
            dupcard6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dupcard6.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }

        }

        private void Card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dupcard7.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard7_Click_1(object sender, EventArgs e)
        {
            dupcard7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dupcard7.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dupcard8.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard8_Click_1(object sender, EventArgs e)
        {
            dupcard8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dupcard8.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            card9.Image = Properties.Resources.Card9;
            if (PendingImage1 == null)
            {
                PendingImage1 = card9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card9.Enabled = false;
                    dupcard9.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard9_Click_1(object sender, EventArgs e)
        {
            dupcard9.Image = Properties.Resources.Card9;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card9.Enabled = false;
                    dupcard9.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            card10.Image = Properties.Resources.Card10;
            if (PendingImage1 == null)
            {
                PendingImage1 = card10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card10.Enabled = false;
                    dupcard10.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard10_Click(object sender, EventArgs e)
        {
            dupcard10.Image = Properties.Resources.Card10;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card10.Enabled = false;
                    dupcard10.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            card11.Image = Properties.Resources.Card11;
            if (PendingImage1 == null)
            {
                PendingImage1 = card11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card11.Enabled = false;
                    dupcard11.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }

        }

        private void Dupcard11_Click_1(object sender, EventArgs e)
        {
            dupcard11.Image = Properties.Resources.Card11;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card11.Enabled = false;
                    dupcard11.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            card12.Image = Properties.Resources.Card12;
            if (PendingImage1 == null)
            {
                PendingImage1 = card12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card12.Enabled = false;
                    dupcard12.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Dupcard12_Click_1(object sender, EventArgs e)
        {
            dupcard12.Image = Properties.Resources.Card12;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card12.Enabled = false;
                    dupcard12.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
            
        }
        #endregion
        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }
    }
   

}



