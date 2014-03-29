using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MiningInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var URL = textBoxUrl.Text;
            //var URL = "http://trc.coin-pool.org/index.php?page=api&action=public";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URL);
                // Now parse with JSON.Net
                dynamic results = JValue.Parse(json);

                var poolName = results.pool_name;
                var hashrate = results.hashrate;
                var workers = results.workers;
                var lastBlock = results.last_block;
                var sharesThisRound = results.shares_this_round;
                var networkHashrate = results.network_hashrate;
                lblPoolName.Text = poolName;
                lblHashrate.Text = hashrate;
                lblWorkers.Text = workers;
                lblLastBlock.Text = lastBlock;
                lblNetworkHashrate.Text = networkHashrate;
                lblSharesThisRound.Text = sharesThisRound;
            }
        }

    }
}
