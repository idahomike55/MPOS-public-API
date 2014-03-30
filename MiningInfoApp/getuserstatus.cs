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
    public partial class getuserstatus : Form
    {
        public getuserstatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var address = textboxAddress.Text;
            var apikey = textboxApikey.Text;
            var userid = textboxUserId.Text;
            var URL = address + "/index.php?page=api&action=getuserstatus&api_key=" + apikey + "&id=" + userid;
            //var URL = "http://trc.coin-pool.org/index.php?page=api&action=public";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URL);
                // Now parse with JSON.Net
                dynamic results = JValue.Parse(json);

                var version = results.getuserstatus.version;
                var runtime = results.getuserstatus.runtime;
                var username = results.getuserstatus.data.username;
                var validShares = results.getuserstatus.data.shares.valid;
                var invalidShares = results.getuserstatus.data.shares.invalid;
                var donatePercent = results.getuserstatus.data.shares.donate_percent;
                var anonymous = results.getuserstatus.data.shares.is_anonymous;
                var hashrate = results.getuserstatus.data.hashrate;
                var sharerate = results.getuserstatus.data.sharerate;
                lblVersion.Text = version;
                lblRuntime.Text = runtime;
                lblUsername.Text = username;
                lblValidShares.Text = validShares;
                lblInvalidShares.Text = invalidShares ;
                lblDonatePercent.Text = donatePercent ;
                lblAnonymous.Text = anonymous;
                lblHashrate.Text = hashrate;
                lblSharerate.Text = sharerate;
            }
        }
    }
}
