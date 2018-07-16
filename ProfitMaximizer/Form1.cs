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
        private RouletteMachine roulette = new RouletteMachine();
        private DiceRollMachine diceRoll = new DiceRollMachine();

        public Form1()
        {
            InitializeComponent();
            SetupDataBindings();
            SetFormatForResultsView();
        }

        private void SetupDataBindings()
        {
            this.pnlDice.DataBindings.Add("Enabled", this.radDiceRoll, "Checked");
            this.pnlRoulette.DataBindings.Add("Enabled", this.radRoulette, "Checked");

            this.diceCount.DataBindings.Add("Value", this.diceRoll.DiceRoller, "NumberOfDice");
            this.diceFaceCount.DataBindings.Add("Value", this.diceRoll.DiceRoller, "DiceFaces");

            this.whiteCount.DataBindings.Add("Value", this.roulette.Roller, "WhiteSlots");
            this.blackCount.DataBindings.Add("Value", this.roulette.Roller, "BlackSlots");
            this.redCount.DataBindings.Add("Value", this.roulette.Roller, "RedSlots");
        }
        private void SetFormatForResultsView()
        {
            this.resultsView.ColumnCount = 2;
            this.resultsView.Columns[0].HeaderText = "Machine";
            this.resultsView.Columns[1].HeaderText = "Profit";
        }
        private bool UseRouletteMachine()
        {
            return this.radRoulette.Checked;
        }
        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            const int iterations = 10000;
            SimulationResult simResult = new SimulationResult();
            if (UseRouletteMachine())
            {
                simResult.Machine = roulette;
                simResult.Result = roulette.RunSimulation(iterations, RouletteWager.TestFixture);
            }
            else
            {
                simResult.Machine = diceRoll;
                simResult.Result = diceRoll.RunSimulation(iterations, Wager.TestFixture);
            }
            var profit = 1.0 - (simResult.Result.Returns / simResult.Result.InitialStake);
            this.resultsView.Rows.Add(new string[] { simResult.Machine.ToString(), profit.ToString("P2") });
            
        }
    }
}
