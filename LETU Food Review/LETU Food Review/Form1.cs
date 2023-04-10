using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LETU_Food_Review.Properties;
using Newtonsoft.Json;

namespace LETU_Food_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Hive Foods
            var result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/hive.json"));
            foreach (var food in result) {
                Label lb = new Label();
                PictureBox pb = new PictureBox();
                pb.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(food.imageId)));
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                lb.Size = new System.Drawing.Size(110, 16);
                lb.Text = food.name;
                this.hiveFlowPanel.Controls.Add(pb);
                this.hiveFlowPanel.Controls.Add(lb);
            }

            //Load Saga Foods
            result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/saga.json"));
            foreach (var food in result)
            {
                Label lb = new Label();
                PictureBox pb = new PictureBox();
                pb.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(food.imageId)));
                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                lb.Size = new System.Drawing.Size(110, 16);
                lb.Text = food.name;
                this.sagaFlowPanel.Controls.Add(pb);
                this.sagaFlowPanel.Controls.Add(lb);
            }
        }
    }
}
public struct HFood {
    public string name;
    public string rating;
    public string imageId;
}