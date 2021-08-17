using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EI_Transformer_Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private double[] swgTable = {0, 142, 120, 100, 84, 70, 58, 48, 40, 32, 26, 22, 18, 14, 10, 8, 6, 4, 3.6, 2.6, 2, 1.6, 1.2, 1, 0.8, 0.6, 0.5, 0.42, 0.34, 0.24, 0.2, 0.18, 0.14, 0.12, 0.1, 0.08};

        private void Form1_Load(object sender, EventArgs e) {
            CheckForIllegalCrossThreadCalls = false;
            WidthEnable.Checked = true;
            HeightEnable.Checked = true;
            Power.Enabled = false;
        }

        private void WidthEnable_CheckedChanged(object sender, EventArgs e) {
            if (PowerEnable.Checked && HeightEnable.Checked && WidthEnable.Checked) {
                MessageBox.Show("Already two perams are selected.");
                WidthEnable.Checked = false;
                CWidth.Enabled = false;
            }
            else CWidth.Enabled = true;
            if (!WidthEnable.Checked) CWidth.Enabled = false;
        }

        private void PowerEnable_CheckedChanged(object sender, EventArgs e) {
            if (PowerEnable.Checked && HeightEnable.Checked && WidthEnable.Checked) {
                MessageBox.Show("Already two perams are selected.");
                PowerEnable.Checked = false;
                Power.Enabled = false;
            }
            else Power.Enabled = true;
            if(!PowerEnable.Checked) Power.Enabled = false;
        }

        private void HeightEnable_CheckedChanged(object sender, EventArgs e) {
            if (PowerEnable.Checked && HeightEnable.Checked && WidthEnable.Checked) {
                MessageBox.Show("Already two perams are selected.");
                HeightEnable.Checked = false;
                CHeight.Enabled = false;
            }
            else CHeight.Enabled = true;
            if(!HeightEnable.Checked) CHeight.Enabled = false;
        }

        private void Width_TextChanged(object sender, EventArgs e) {
            bool vaild = float.TryParse(CWidth.Text, out float width);
            if (vaild == false) return;
            
            if (CHeight.Enabled == false) {
                vaild = float.TryParse(Power.Text, out float power);
                if (vaild == false) return;
                CHeight.Text = (Math.Sqrt(power) / (5.58 * width)).ToString("0.00");
            }

            else if (Power.Enabled == false) {
                vaild = float.TryParse(CHeight.Text, out float height);
                if (vaild == false) return;
                var p = Math.Pow(width * height * 5.58, 2);
                Power.Text = p.ToString("0.00");
            }
            var fha = float.Parse(CHeight.Text) * width * int.Parse(Frequency.Text) * int.Parse(FluxLines.Text);
            TurnVolt.Text = (22522522.5225 / fha).ToString("0.00");
        }

        private void Power_TextChanged(object sender, EventArgs e) {
            bool vaild = float.TryParse(Power.Text, out float power);
            if (vaild == false) return;
            
            if (CHeight.Enabled == false) {
                vaild = float.TryParse(CWidth.Text, out float width);
                if (vaild == false) return;
                CHeight.Text = (Math.Sqrt(power) / (5.58 * width)).ToString("0.00");
            }

            else if (CWidth.Enabled == false) {
                vaild = float.TryParse(CHeight.Text, out float height);
                if (vaild == false) return;
                CWidth.Text = (Math.Sqrt(power) / (5.58 * height)).ToString("0.00");
            }
            var fha = float.Parse(CHeight.Text) * float.Parse(CWidth.Text) * int.Parse(Frequency.Text) * int.Parse(FluxLines.Text);
            TurnVolt.Text = (22522522.5225 / fha).ToString("0.00");
        }

        private void Height_TextChanged(object sender, EventArgs e) {
            bool vaild = float.TryParse(CHeight.Text, out float height);
            if (vaild == false) return;
           
            if (CWidth.Enabled == false) {
                vaild = float.TryParse(Power.Text, out float power);
                if (vaild == false) return;
                CWidth.Text = (Math.Sqrt(power) / (5.58 * height)).ToString("0.00");
            }

            else if(Power.Enabled == false) {
                vaild = float.TryParse(CWidth.Text, out float width);
                if (vaild == false) return;
                var p = Math.Pow(width * height * 5.58, 2);
                Power.Text = p.ToString("0.00");
            }
            var fha = float.Parse(CHeight.Text) * float.Parse(CWidth.Text) * int.Parse(Frequency.Text) * int.Parse(FluxLines.Text);
            TurnVolt.Text = (22522522.5225 / fha).ToString("0.00");
        }

        private void Frequency_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(Frequency.Text, out int freq)) {
                Frequency.Text = freq.ToString();
                var fha = float.Parse(CHeight.Text) * float.Parse(CWidth.Text) * int.Parse(Frequency.Text) * int.Parse(FluxLines.Text);
                TurnVolt.Text = (22522522.5225 / fha).ToString("0.00");
            }
            else Frequency.Text = "";
        }

        private void FluxLines_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(FluxLines.Text, out int flux)) {
                FluxLines.Text = flux.ToString();
                var fha = float.Parse(CHeight.Text) * float.Parse(CWidth.Text) * int.Parse(Frequency.Text) * int.Parse(FluxLines.Text);
                TurnVolt.Text = (22522522.5225 / fha).ToString("0.00");
            }
            else FluxLines.Text = "";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("cmd", "/c start https://helloantor.blogspot.com");
        }

        private void PrimaryAdd_Click(object sender, EventArgs e) {
            bool valid = float.TryParse(TurnVolt.Text, out float turn);
            if (valid == false) return;
            valid = float.TryParse(Pvolt.Text, out float volt);
            if (valid == false) return;
            valid = float.TryParse(Power.Text, out float power);
            if (valid == false) return;

            PvoltList.Items.Add(Pvolt.Text);
            PturnList.Items.Add((turn * volt).ToString("0.00"));
            PampList.Items.Add((power / volt).ToString("0.00"));
        }

        private void PrimaryRemove_Click(object sender, EventArgs e) {
            int selected = PvoltList.SelectedIndex;
            if (selected != -1) {
                PvoltList.Items.RemoveAt(selected);
                PturnList.Items.RemoveAt(selected);
                PampList.Items.RemoveAt(selected);
            }
        }

        private void SAdd_Click(object sender, EventArgs e) {
            bool valid = float.TryParse(TurnVolt.Text, out float turn);
            if (valid == false) return;
            valid = float.TryParse(Svolt.Text, out float volt);
            if (valid == false) return;
            valid = float.TryParse(Power.Text, out float power);
            if (valid == false) return;

            double N2 = turn * volt;
            SvoltList.Items.Add(Svolt.Text);
            SturnList.Items.Add((N2).ToString("0.00"));
            SampList.Items.Add((power / volt).ToString("0.00"));

            if (PturnList.Items.Count == 0) return;       
            double N1 = double.Parse(PturnList.Items[PturnList.Items.Count - 1].ToString());
            ShenryList.Items.Add((Math.Pow(N2, 2) / Math.Pow(N1, 2) * 1000).ToString("0.00mH"));
        }

        private void SRemove_Click(object sender, EventArgs e) {
            int selected = SvoltList.SelectedIndex;
            if (selected != -1) {
                try {
                    SvoltList.Items.RemoveAt(selected);
                    SturnList.Items.RemoveAt(selected);
                    SampList.Items.RemoveAt(selected);
                    ShenryList.Items.RemoveAt(selected);
                }
                catch { }
            }
        }

        private void PampList_SelectedIndexChanged(object sender, EventArgs e) {
            if (PampList.SelectedIndex == -1) return;
            double target = double.Parse(PampList.SelectedItem.ToString());
            double nearest = swgTable.OrderBy(x => Math.Abs((double)x - target)).First();
            PSWG.Text = Array.IndexOf(swgTable, nearest).ToString();
        }

        private void SampList_SelectedIndexChanged(object sender, EventArgs e) {
            if (SampList.SelectedIndex == -1) return;
            double target = double.Parse(SampList.SelectedItem.ToString());
            double nearest = swgTable.OrderBy(x => Math.Abs((double)x - target)).First();
            SSWG.Text = Array.IndexOf(swgTable, nearest).ToString();
        }
    }
}
