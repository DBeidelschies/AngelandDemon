using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Engine1;

namespace BattleForHeaven
{
    public partial class BattleForHeaven : Form
    {
        private Player player;

        public BattleForHeaven()
        {
            InitializeComponent();

            Location location = new Location(1, "Heaven", "This is where you and the other angels live.");


            player = new Player(10, 10, 10, 0, 1);

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
