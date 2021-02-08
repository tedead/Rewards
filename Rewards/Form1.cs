using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Rewards {
    public partial class Form1 : Form {

        int ordersPicked = 0;

        public Form1() {

            InitializeComponent();

            //int[,,,,,,,,,] rewards = new int[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnPick_Click(object sender, EventArgs e) {

            Random r = new Random(Guid.NewGuid().GetHashCode());

            string one = Path.Combine(Environment.CurrentDirectory, @"sounds\", "One coin.wav");
            string two = Path.Combine(Environment.CurrentDirectory, @"sounds\", "Two coins.wav");
            string five = Path.Combine(Environment.CurrentDirectory, @"sounds\", "Five coins.wav");
            string ten = Path.Combine(Environment.CurrentDirectory, @"sounds\", "Ten coins.wav");

            int reward = r.Next(1, 11);

            switch (reward) {

                case 1:

                    lstPickRewards.Items.Add("You have been rewarded one coin.");

                    calculateCoinsEarned(1);

                    SoundPlayer simpleSoundOne = new SoundPlayer(one);
                    simpleSoundOne.Play();

                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:

                    lstPickRewards.Items.Add("You have been rewarded two coins.");

                    calculateCoinsEarned(2);

                    SoundPlayer simpleSoundTwo = new SoundPlayer(two);
                    simpleSoundTwo.Play();

                    break;

                case 9:

                    lstPickRewards.Items.Add("You have been rewarded five coins!");

                    calculateCoinsEarned(5);

                    SoundPlayer simpleSoundFive = new SoundPlayer(five);
                    simpleSoundFive.Play();

                    break;

                case 10:

                    lstPickRewards.Items.Add("You have been rewarded ten coins!");

                    calculateCoinsEarned(10);

                    SoundPlayer simpleSoundTen = new SoundPlayer(ten);
                    simpleSoundTen.Play();

                    break;

            }

            ordersPicked += 1;

            lblPickCount.Text = "Orders Picked: " + ordersPicked;

            lstPickRewards.SelectedIndex = lstPickRewards.Items.Count - 1;

        }

        private void btnClear_Click(object sender, EventArgs e) {

            ordersPicked = 0;

            lstPickRewards.Items.Clear();

            txtCoinCount.Text = Convert.ToString(0);

            lblPickCount.Text = "Orders Picked: " + 0;

        }

        private void calculateCoinsEarned(int reward) {

            int totalCoins = Int32.Parse(txtCoinCount.Text);

            totalCoins += reward;

            txtCoinCount.Text = Convert.ToString(totalCoins);

        }

        private int determineBonus() {

            Random r = new Random(Guid.NewGuid().GetHashCode());

            int bonus = r.Next(1, 1001);

            if (bonus <= 800)
            {
                return 0;
            }

            return 1;
        }
    }
}
