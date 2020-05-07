using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1
{
    public partial class ControlPanel : Form
    {
        private ITreinController controller;
        private ITreinReis reis;
        public ControlPanel()
        {
            InitializeComponent();
            reis = new TreinReis();
            controller = new TreinController(reis);
            
        }

        private void btnVolgendStation_Click(object sender, EventArgs e)
        {
            controller.VolgendStation();
            btn_turn.Show();
        }


        private void ControlPanel_Load(object sender, EventArgs e)
        {
            TreinDisplay display1 = new TreinDisplay(reis);
            display1.Show();
        }

        private void btn_turn_Click(object sender, EventArgs e)
        {
            reis.TurnAround();
        }
    }
}
