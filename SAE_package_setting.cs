using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class SAE_package_setting : Form
    {
        public SAE_package_setting()
        {
            InitializeComponent();

            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);

            drag_box.Value = decimal.Parse(config.AppSettings.Settings["PackageDrag"].Value);
            air_box.Value = decimal.Parse(config.AppSettings.Settings["PackageAir"].Value);
            weight_box.Value = decimal.Parse(config.AppSettings.Settings["PackageWeigth"].Value);
            area_box.Value = decimal.Parse(config.AppSettings.Settings["PackageArea"].Value);
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);

            config.AppSettings.Settings["PackageDrag"].Value = drag_box.Value.ToString();
            config.AppSettings.Settings["PackageAir"].Value = air_box.Value.ToString();
            config.AppSettings.Settings["PackageWeigth"].Value = weight_box .Value.ToString();
            config.AppSettings.Settings["PackageArea"].Value = area_box.Value.ToString();

            config.Save();
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
