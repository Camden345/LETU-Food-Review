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
                    pb.Click += new System.EventHandler((sender, e) => this.loadHiveReviews(food.imageId));
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
                    pb.Click += new System.EventHandler((sender, e) => this.loadSagaReviews(food.imageId));
                    lb.Size = new System.Drawing.Size(110, 16);
                    lb.Text = food.name;
                    this.sagaFlowPanel.Controls.Add(pb);
                    this.sagaFlowPanel.Controls.Add(lb);
                }
            }
        }
        
        private void clearHiveReviews(object sender, EventArgs e)
        {
            this.hiveFlowPanel.Controls.Clear();
            this.LoadHive();
        }
        private void clearSagaReviews(object sender, EventArgs e)
        {
            this.sagaFlowPanel.Controls.Clear();
            this.LoadSaga();
        }

        private void loadHiveReviews(string foodId)
        {
            this.hiveFlowPanel.Controls.Clear();
            Button back = new Button();
            back.Size = new System.Drawing.Size(100, 23);
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += new System.EventHandler(this.clearHiveReviews);
            Label waste = new Label();
            waste.Size = new System.Drawing.Size(110, 16);
            waste.Text = "         ";
            this.hiveFlowPanel.Controls.Add(back);
            this.hiveFlowPanel.Controls.Add(waste);
            var result = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            foreach (var review in result)
            {
                Label userlbl = new Label();
                userlbl.Size = new System.Drawing.Size(110, 16);
                userlbl.Text = review.name;
                Label ratinglbl = new Label();
                ratinglbl.Size = new System.Drawing.Size(110, 16);
                ratinglbl.Text = review.rating;
                Label reviewlbl = new Label();
                reviewlbl.Size = new System.Drawing.Size(110, 16);
                reviewlbl.Text = review.review;
                waste = new Label();
                waste.Size = new System.Drawing.Size(110, 16);
                waste.Text = "         ";
                this.hiveFlowPanel.Controls.Add(userlbl);
                this.hiveFlowPanel.Controls.Add(ratinglbl);
                this.hiveFlowPanel.Controls.Add(reviewlbl);
                this.hiveFlowPanel.Controls.Add(waste);
            }
            Button upload = new Button();
            upload.Size = new System.Drawing.Size(100, 23);
            upload.Text = "Upload Review";
            upload.UseVisualStyleBackColor = true;
            upload.Click += new System.EventHandler((x, y) => this.click_uploadHiveReview(foodId));
            this.hiveFlowPanel.Controls.Add(upload);
        }

        private void click_uploadHiveReview(string foodId)
        {
            this.hiveFlowPanel.Controls.Clear();
            Label userNameLb = new Label();
            userNameLb.Size = new System.Drawing.Size(110, 16);
            userNameLb.Text = "User Name:";
            this.hiveFlowPanel.Controls.Add(userNameLb);
            TextBox userNameTb = new TextBox();
            userNameTb.Name = "UserName";
            userNameTb.Size = new System.Drawing.Size(100, 22);
            this.hiveFlowPanel.Controls.Add(userNameTb);
            Label ratingLb = new Label();
            ratingLb.Size = new System.Drawing.Size(110, 16);
            ratingLb.Text = "Rating:";
            this.hiveFlowPanel.Controls.Add(ratingLb);
            TextBox ratingTb = new TextBox();
            ratingTb.Name = "Rating";
            ratingTb.Size = new System.Drawing.Size(100, 22);
            this.hiveFlowPanel.Controls.Add(ratingTb);
            Label reviewLb = new Label();
            reviewLb.Size = new System.Drawing.Size(110, 16);
            reviewLb.Text = "Review:";
            this.hiveFlowPanel.Controls.Add(reviewLb);
            TextBox reviewTb = new TextBox();
            reviewTb.Name = "Review";
            reviewTb.Size = new System.Drawing.Size(100, 22);
            this.hiveFlowPanel.Controls.Add(reviewTb);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler((x, y) => this.submitHiveReview(foodId));
            this.hiveFlowPanel.Controls.Add(submit);
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearHiveReviews);
            this.hiveFlowPanel.Controls.Add(cancel);
        }

        private void submitHiveReview(string foodId)
        {
            var result = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            result.Add(new Review()
            {
                name = this.hiveFlowPanel.Controls.Find("UserName", true)[0].Text,
                rating = this.hiveFlowPanel.Controls.Find("Rating", true)[0].Text,
                review = this.hiveFlowPanel.Controls.Find("Review", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/" + foodId + ".json", JsonConvert.SerializeObject(result));
            this.hiveFlowPanel.Controls.Clear();
            this.loadHiveReviews(foodId);
        }

        private void loadSagaReviews(string foodId)
        {
            this.sagaFlowPanel.Controls.Clear();
            Button back = new Button();
            back.Size = new System.Drawing.Size(100, 23);
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += new System.EventHandler(this.clearSagaReviews);
            Label waste = new Label();
            waste.Size = new System.Drawing.Size(110, 16);
            waste.Text = "         ";
            this.sagaFlowPanel.Controls.Add(back);
            this.sagaFlowPanel.Controls.Add(waste);
            var result = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            foreach (var review in result)
            {
                Label userlbl = new Label();
                userlbl.Size = new System.Drawing.Size(110, 16);
                userlbl.Text = review.name;
                Label ratinglbl = new Label();
                ratinglbl.Size = new System.Drawing.Size(110, 16);
                ratinglbl.Text = review.rating;
                Label reviewlbl = new Label();
                reviewlbl.Size = new System.Drawing.Size(110, 16);
                reviewlbl.Text = review.review;
                waste = new Label();
                waste.Size = new System.Drawing.Size(110, 16);
                waste.Text = "         ";
                this.sagaFlowPanel.Controls.Add(userlbl);
                this.sagaFlowPanel.Controls.Add(ratinglbl);
                this.sagaFlowPanel.Controls.Add(reviewlbl);
                this.sagaFlowPanel.Controls.Add(waste);
            }
            Button upload = new Button();
            upload.Size = new System.Drawing.Size(100, 23);
            upload.Text = "Upload Review";
            upload.UseVisualStyleBackColor = true;
            upload.Click += new System.EventHandler((x, y) => this.click_uploadSagaReview(foodId));
            this.sagaFlowPanel.Controls.Add(upload);
        }

        private void click_uploadSagaReview(string foodId)
        {
            this.sagaFlowPanel.Controls.Clear();
            Label userNameLb = new Label();
            userNameLb.Size = new System.Drawing.Size(110, 16);
            userNameLb.Text = "User Name:";
            this.sagaFlowPanel.Controls.Add(userNameLb);
            TextBox userNameTb = new TextBox();
            userNameTb.Name = "UserName";
            userNameTb.Size = new System.Drawing.Size(100, 22);
            this.sagaFlowPanel.Controls.Add(userNameTb);
            Label ratingLb = new Label();
            ratingLb.Size = new System.Drawing.Size(110, 16);
            ratingLb.Text = "Rating:";
            this.sagaFlowPanel.Controls.Add(ratingLb);
            TextBox ratingTb = new TextBox();
            ratingTb.Name = "Rating";
            ratingTb.Size = new System.Drawing.Size(100, 22);
            this.sagaFlowPanel.Controls.Add(ratingTb);
            Label reviewLb = new Label();
            reviewLb.Size = new System.Drawing.Size(110, 16);
            reviewLb.Text = "Review:";
            this.sagaFlowPanel.Controls.Add(reviewLb);
            TextBox reviewTb = new TextBox();
            reviewTb.Name = "Review";
            reviewTb.Size = new System.Drawing.Size(100, 22);
            this.sagaFlowPanel.Controls.Add(reviewTb);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler((x, y) => this.submitSagaReview(foodId));
            this.sagaFlowPanel.Controls.Add(submit);
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearSagaReviews);
            this.sagaFlowPanel.Controls.Add(cancel);
        }

        private void submitSagaReview(string foodId)
        {
            var result = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            result.Add(new Review()
            {
                name = this.sagaFlowPanel.Controls.Find("UserName", true)[0].Text,
                rating = this.sagaFlowPanel.Controls.Find("Rating", true)[0].Text,
                review = this.sagaFlowPanel.Controls.Find("Review", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/" + foodId + ".json", JsonConvert.SerializeObject(result));
            this.sagaFlowPanel.Controls.Clear();
            this.loadSagaReviews(foodId);
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
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearHiveReviews);
            this.hiveFlowPanel.Controls.Add(cancel);
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
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearSagaReviews);
            this.sagaFlowPanel.Controls.Add(cancel);
        }
    }
}
public struct HFood {
    public string name;
    public string rating;
    public string imageId;
    public bool accepted;
}

public struct Review
{
    public string name;
    public string rating;
    public string review;
}