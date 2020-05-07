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
    public partial class TreinDisplay : Form, ITreinDisplay
    {
        public TreinDisplay(ITreinReis reis)
        {
            InitializeComponent();
            reis.AddObserver(this);
            
        }

        public void Update(TreinStation station)
        {
            labelName.Text = String.Format("Naam volgend station: " + station.Naam);
            labelSpoor.Text = String.Format("Spoor volgend station: " + station.AankomstSpoor);
            labelAankomst.Text = String.Format("Aankomst tijd: " + station.AankomstTijd.ToString());
        }
    }
}
