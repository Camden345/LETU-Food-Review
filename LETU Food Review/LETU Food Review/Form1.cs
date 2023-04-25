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
            LoadAccountPage();
            LoadHive();
            LoadSaga();
        }

        private void click_createAccountButton(object sender, EventArgs e)
        {
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            result.user = this.accountFlowPanel.Controls.Find("Email", true)[0].Text;
            System.IO.File.WriteAllText(@"./db/localdata.json", JsonConvert.SerializeObject(result));
            var result2 = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"./db/users.json"));
            result2.Add(new User()
            {
                name = this.accountFlowPanel.Controls.Find("Name", true)[0].Text,
                email = this.accountFlowPanel.Controls.Find("Email", true)[0].Text,
                password = this.accountFlowPanel.Controls.Find("Password", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/users.json", JsonConvert.SerializeObject(result2));
            LoadAccountPage();
        }

        private void LoadCreateAccount(object sender, EventArgs e)
        {
            this.accountFlowPanel.Controls.Clear();
            Label nameLb = new Label();
            nameLb.Size = new System.Drawing.Size(110, 16);
            nameLb.Text = "Name:";
            TextBox nameTb = new TextBox();
            nameTb.Name = "Name";
            nameTb.Size = new System.Drawing.Size(100, 22);
            TextBox emailTb = new TextBox();
            Label emailLb = new Label();
            emailLb.Size = new System.Drawing.Size(110, 16);
            emailLb.Text = "Email:";
            emailTb.Name = "Email";
            emailTb.Size = new System.Drawing.Size(100, 22);
            Label passwordLb = new Label();
            passwordLb.Size = new System.Drawing.Size(110, 16);
            passwordLb.Text = "Password:";
            TextBox passTb = new TextBox();
            passTb.Name = "Password";
            passTb.Size = new System.Drawing.Size(100, 22);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler(this.click_createAccountButton);
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler((s, es) => this.LoadAccountPage());
            this.accountFlowPanel.Controls.Add(nameLb);
            this.accountFlowPanel.Controls.Add(nameTb);
            this.accountFlowPanel.Controls.Add(emailLb);
            this.accountFlowPanel.Controls.Add(emailTb);
            this.accountFlowPanel.Controls.Add(passwordLb);
            this.accountFlowPanel.Controls.Add(passTb);
            this.accountFlowPanel.Controls.Add(submit);
            this.accountFlowPanel.Controls.Add(cancel);
        }

        private void click_signInButton(object sender, EventArgs e)
        {
            var result = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"./db/users.json"));
            foreach(var user in result)
            {
                if(user.email == this.accountFlowPanel.Controls.Find("Email", true)[0].Text && user.password == this.accountFlowPanel.Controls.Find("Password", true)[0].Text)
                {
                    var result2 = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
                    result2.user = user.email;
                    System.IO.File.WriteAllText(@"./db/localdata.json", JsonConvert.SerializeObject(result2));
                    this.LoadAccountPage();
                    return;
                }
            }
            if(accountFlowPanel.Controls.Find("WrongPass", true).Length == 0)
            {
                Label wrongPass = new Label();
                wrongPass.Size = new System.Drawing.Size(110, 16);
                wrongPass.Text = "Wrong Password";
                wrongPass.Name = "WrongPass";
                this.accountFlowPanel.Controls.Add(wrongPass);
            }
        }

        private void click_signOutButton(object sender, EventArgs e)
        {
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            result.user = "";
            System.IO.File.WriteAllText(@"./db/localdata.json", JsonConvert.SerializeObject(result));
            this.LoadAccountPage();
        }

        private void loadSignIn(object sender, EventArgs e)
        {
            this.accountFlowPanel.Controls.Clear();
            TextBox emailTb = new TextBox();
            Label emailLb = new Label();
            emailLb.Size = new System.Drawing.Size(110, 16);
            emailLb.Text = "Email:";
            emailTb.Name = "Email";
            emailTb.Size = new System.Drawing.Size(100, 22);
            Label passwordLb = new Label();
            passwordLb.Size = new System.Drawing.Size(110, 16);
            passwordLb.Text = "Password:";
            TextBox passTb = new TextBox();
            passTb.Name = "Password";
            passTb.Size = new System.Drawing.Size(100, 22);
            Button submit = new Button();
            submit.Size = new System.Drawing.Size(100, 23);
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += new System.EventHandler(this.click_signInButton);
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler((s, es) => this.LoadAccountPage());
            this.accountFlowPanel.Controls.Add(emailLb);
            this.accountFlowPanel.Controls.Add(emailTb);
            this.accountFlowPanel.Controls.Add(passwordLb);
            this.accountFlowPanel.Controls.Add(passTb);
            this.accountFlowPanel.Controls.Add(submit);
            this.accountFlowPanel.Controls.Add(cancel);
        }

        private void LoadAccountPage()
        {
            this.accountFlowPanel.Controls.Clear();
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            if(result.user == "")
            {
                Button create = new Button();
                create.Size = new System.Drawing.Size(100, 23);
                create.Text = "Create Account";
                create.UseVisualStyleBackColor = true;
                create.Click += new System.EventHandler(this.LoadCreateAccount);
                Button signIn = new Button();
                signIn.Size = new System.Drawing.Size(100, 23);
                signIn.Text = "Sign In";
                signIn.UseVisualStyleBackColor = true;
                signIn.Click += new System.EventHandler(this.loadSignIn);
                this.accountFlowPanel.Controls.Add(create);
                this.accountFlowPanel.Controls.Add(signIn);
            }
            else
            {
                var result2 = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"./db/users.json"));
                var ans = result2.Find(x => x.email == result.user);
                Label welcome = new Label();
                welcome.Text = "Welcome " + ans.name;
                Button signOut = new Button();
                signOut.Size = new System.Drawing.Size(100, 23);
                signOut.Text = "Sign Out";
                signOut.UseVisualStyleBackColor = true;
                signOut.Click += new System.EventHandler(this.click_signOutButton);
                this.accountFlowPanel.Controls.Add(welcome);
                this.accountFlowPanel.Controls.Add(signOut);
            }
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
            Button addFood = new Button();
            addFood.Text = "Add Food";
            addFood.UseVisualStyleBackColor = true;
            addFood.Click += new System.EventHandler(this.addHiveFood_Click);
            this.hiveFlowPanel.Controls.Add(addFood);
            Button refresh = new Button();
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += new System.EventHandler(this.hiveRefresh_Click);
            this.hiveFlowPanel.Controls.Add(refresh);
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
            Button addFood = new Button();
            addFood.Text = "Add Food";
            addFood.UseVisualStyleBackColor = true;
            addFood.Click += new System.EventHandler(this.addSagaFood_Click);
            this.sagaFlowPanel.Controls.Add(addFood);
            Button refresh = new Button();
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += new System.EventHandler(this.sagaRefresh_Click);
            this.sagaFlowPanel.Controls.Add(refresh);
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
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            if (result.user != "")
            {
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
            }
            else
            {
                Label reviewLb = new Label();
                reviewLb.Size = new System.Drawing.Size(2000, 16);
                reviewLb.Text = "You must be signed in to review a food.";
                this.hiveFlowPanel.Controls.Add(reviewLb);
            }
            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearHiveReviews);
            this.hiveFlowPanel.Controls.Add(cancel);
        }

        private void submitHiveReview(string foodId)
        {
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            var name = "";
            var result2 = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"./db/users.json"));
            foreach(var user in result2)
            {
                if(user.email == result.user)
                {
                    name = user.name;
                    break;
                }
            }
            var result3 = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            result3.Add(new Review()
            {
                name = name,
                rating = this.hiveFlowPanel.Controls.Find("Rating", true)[0].Text,
                review = this.hiveFlowPanel.Controls.Find("Review", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/" + foodId + ".json", JsonConvert.SerializeObject(result3));
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
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            if (result.user != "")
            {
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
            }
            else
            {
                Label reviewLb = new Label();
                reviewLb.Size = new System.Drawing.Size(2000, 16);
                reviewLb.Text = "You must be signed in to review a food.";
                this.sagaFlowPanel.Controls.Add(reviewLb);
            }
            Button cancel = new Button();
            cancel.Size = new System.Drawing.Size(100, 23);
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += new System.EventHandler(this.clearSagaReviews);
            this.sagaFlowPanel.Controls.Add(cancel);
        }

        private void submitSagaReview(string foodId)
        {
            var result = JsonConvert.DeserializeObject<LocalData>(File.ReadAllText(@"./db/localdata.json"));
            var name = "";
            var result2 = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@"./db/users.json"));
            foreach (var user in result2)
            {
                if (user.email == result.user)
                {
                    name = user.name;
                    break;
                }
            }
            var result3 = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText(@"./db/" + foodId + ".json"));
            result3.Add(new Review()
            {
                name = name,
                rating = this.sagaFlowPanel.Controls.Find("Rating", true)[0].Text,
                review = this.sagaFlowPanel.Controls.Find("Review", true)[0].Text
            });
            System.IO.File.WriteAllText(@"./db/" + foodId + ".json", JsonConvert.SerializeObject(result3));
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
public struct HFood 
{
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

public struct LocalData
{
    public string user;
}

public struct User
{
    public string name;
    public string email;
    public string password;
}