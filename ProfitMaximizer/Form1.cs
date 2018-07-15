using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PXBetMaster;

namespace ProfitMaximizer
{
    public partial class Form1 : Form
    {
        private List<BaseGamblingMachine> machineList;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.lblProfitTarget.DataBindings.Add("Text", this.profitTarget, "Value");

            machineList = new List<BaseGamblingMachine> { new RouletteMachine(), new DiceRollMachine() };
            this.lstMachines.DataSource = machineList;
        }

        private void SimulateRoulette(float targetPercentage)
        {
            var roulette = new RouletteMachine();
            // const int GENERATIONS = 10;
            


            var whiteColourRatio = roulette.WhiteSlots / (roulette.RedSlots + roulette.BlackSlots);



        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            
        }
    }
}
