using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine1;

namespace BattleForHeaven
{
    public partial class BattleForHeaven : Form
    {
        private Player player;
        public BattleForHeaven()
        {
            InitializeComponent();
            player = new Player();
            player.CurrentHP = 10;
            player.MaxHP = 10;
            player.Energy = 10;
            player.Experience = 0;
            player.Level = 1;
            lblHitPoints.Text = player.CurrentHP.ToString();
            lblEnergy.Text = player.Energy.ToString();
            lblExperience.Text = player.Experience.ToString();
            lblLevel.Text = player.Level.ToString();
        }

        private void BattleForHeaven_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
