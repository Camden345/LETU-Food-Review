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
            LoadHive();
            LoadSaga();
        }

        private void LoadHive()
        {
            var result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/hive.json"));
            foreach (var food in result)
            {
                if (food.accepted)
                {
                    Label lb = new Label();
                    PictureBox pb = new PictureBox();
                    pb.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(food.imageId)));
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    lb.Size = new System.Drawing.Size(110, 16);
                    lb.Text = food.name;
                    this.hiveFlowPanel.Controls.Add(pb);
                    this.hiveFlowPanel.Controls.Add(lb);
                }
            }
        }

        private void LoadSaga()
        {
            var result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/saga.json"));
            foreach (var food in result)
            {
                if (food.accepted)
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

        private void hiveRefresh_Click(object sender, EventArgs e)
        {
            this.hiveFlowPanel.Controls.Clear();
            LoadHive();
        }

        private void sagaRefresh_Click(object sender, EventArgs e)
        {
            this.sagaFlowPanel.Controls.Clear();
            LoadSaga();
        }

        private void submitHiveFood_Click(object sender, EventArgs e)
        {
            var result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/hive.json"));
            result.Add(new HFood(){
                name = this.hiveFlowPanel.Controls.Find("HiveFoodName", true)[0].Text,
                imageId = this.hiveFlowPanel.Controls.Find("HiveImageName", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/hive.json", JsonConvert.SerializeObject(result));
            this.hiveFlowPanel.Controls.Clear();
            LoadHive();
        }

        private void submitSagaFood_Click(object sender, EventArgs e)
        {
            var result = JsonConvert.DeserializeObject<List<HFood>>(File.ReadAllText(@"./db/saga.json"));
            result.Add(new HFood()
            {
                name = this.sagaFlowPanel.Controls.Find("SagaFoodName", true)[0].Text,
                imageId = this.sagaFlowPanel.Controls.Find("SagaImageName", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/saga.json", JsonConvert.SerializeObject(result));
            this.sagaFlowPanel.Controls.Clear();
            LoadSaga();
        }

        private void addHiveFood_Click(object sender, EventArgs e)
        {
            this.hiveFlowPanel.Controls.Clear();
            Label foodNameLb = new Label();
            foodNameLb.Size = new System.Drawing.Size(110, 16);
            foodNameLb.Text = "Food Name:";
            this.hiveFlowPanel.Controls.Add(foodNameLb);
            TextBox foodNameTb = new TextBox();
            foodNameTb.Name = "HiveFoodName";
            foodNameTb.Size = new System.Drawing.Size(100, 22);
            this.hiveFlowPanel.Controls.Add(foodNameTb);
            Label imageNameLb = new Label();
            imageNameLb.Size = new System.Drawing.Size(110, 16);
            imageNameLb.Text = "Image Name:";
            this.hiveFlowPanel.Controls.Add(imageNameLb);
            TextBox imageNameTb = new TextBox();
            imageNameTb.Name = "HiveImageName";
            imageNameTb.Size = new System.Drawing.Size(100, 22);
            this.hiveFlowPanel.Controls.Add(imageNameTb);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler(this.submitHiveFood_Click);
            this.hiveFlowPanel.Controls.Add(submit);
        }

        private void addSagaFood_Click(object sender, EventArgs e)
        {
            this.sagaFlowPanel.Controls.Clear();
            Label foodNameLb = new Label();
            foodNameLb.Size = new System.Drawing.Size(110, 16);
            foodNameLb.Text = "Food Name:";
            this.sagaFlowPanel.Controls.Add(foodNameLb);
            TextBox foodNameTb = new TextBox();
            foodNameTb.Name = "SagaFoodName";
            foodNameTb.Size = new System.Drawing.Size(100, 22);
            this.sagaFlowPanel.Controls.Add(foodNameTb);
            Label imageNameLb = new Label();
            imageNameLb.Size = new System.Drawing.Size(110, 16);
            imageNameLb.Text = "Image Name:";
            this.sagaFlowPanel.Controls.Add(imageNameLb);
            TextBox imageNameTb = new TextBox();
            imageNameTb.Name = "SagaImageName";
            imageNameTb.Size = new System.Drawing.Size(100, 22);
            this.sagaFlowPanel.Controls.Add(imageNameTb);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler(this.submitSagaFood_Click);
            this.sagaFlowPanel.Controls.Add(submit);
        }
    }
}
public struct HFood {
    public string name;
    public string rating;
    public string imageId;
    public bool accepted;
}