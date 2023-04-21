﻿using System.Windows.Forms;

namespace LETU_Food_Review
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accountPage1 = new System.Windows.Forms.TabPage();
            this.account1 = new LETU_Food_Review.Account();
            this.hivePage1 = new System.Windows.Forms.TabPage();
            this.addHiveFood = new System.Windows.Forms.Button();
            this.hiveRefresh = new System.Windows.Forms.Button();
            this.hiveFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sagaPage1 = new System.Windows.Forms.TabPage();
            this.addSagaFood = new System.Windows.Forms.Button();
            this.sagaRefresh = new System.Windows.Forms.Button();
            this.sagaFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homePage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.accountPage1.SuspendLayout();
            this.hivePage1.SuspendLayout();
            this.sagaPage1.SuspendLayout();
            this.homePage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.accountPage1);
            this.tabControl1.Controls.Add(this.hivePage1);
            this.tabControl1.Controls.Add(this.sagaPage1);
            this.tabControl1.Controls.Add(this.homePage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 598);
            this.tabControl1.TabIndex = 2;
            // 
            // accountPage1
            // 
            this.accountPage1.Controls.Add(this.account1);
            this.accountPage1.Location = new System.Drawing.Point(4, 64);
            this.accountPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPage1.Name = "accountPage1";
            this.accountPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPage1.Size = new System.Drawing.Size(397, 530);
            this.accountPage1.TabIndex = 0;
            this.accountPage1.Text = "Account";
            this.accountPage1.UseVisualStyleBackColor = true;
            // 
            // account1
            // 
            this.account1.Location = new System.Drawing.Point(0, 0);
            this.account1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(315, 380);
            this.account1.TabIndex = 9;
            // 
            // hivePage1
            // 
            this.hivePage1.Controls.Add(this.addHiveFood);
            this.hivePage1.Controls.Add(this.hiveRefresh);
            this.hivePage1.Controls.Add(this.hiveFlowPanel);
            this.hivePage1.Location = new System.Drawing.Point(4, 64);
            this.hivePage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hivePage1.Name = "hivePage1";
            this.hivePage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hivePage1.Size = new System.Drawing.Size(397, 530);
            this.hivePage1.TabIndex = 1;
            this.hivePage1.Text = "Hive";
            this.hivePage1.UseVisualStyleBackColor = true;
            // 
            // addHiveFood
            // 
            this.addHiveFood.Location = new System.Drawing.Point(4, 491);
            this.addHiveFood.Name = "addHiveFood";
            this.addHiveFood.Size = new System.Drawing.Size(100, 23);
            this.addHiveFood.TabIndex = 15;
            this.addHiveFood.Text = "Add Food";
            this.addHiveFood.UseVisualStyleBackColor = true;
            this.addHiveFood.Click += new System.EventHandler(this.addHiveFood_Click);
            // 
            // hiveRefresh
            // 
            this.hiveRefresh.Location = new System.Drawing.Point(110, 491);
            this.hiveRefresh.Name = "hiveRefresh";
            this.hiveRefresh.Size = new System.Drawing.Size(100, 23);
            this.hiveRefresh.TabIndex = 14;
            this.hiveRefresh.Text = "Refresh Page";
            this.hiveRefresh.UseVisualStyleBackColor = true;
            this.hiveRefresh.Click += new System.EventHandler(this.hiveRefresh_Click);
            // 
            // hiveFlowPanel
            // 
            this.hiveFlowPanel.AutoScroll = true;
            this.hiveFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.hiveFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.hiveFlowPanel.Name = "hiveFlowPanel";
            this.hiveFlowPanel.Size = new System.Drawing.Size(395, 484);
            this.hiveFlowPanel.TabIndex = 13;
            // 
            // sagaPage1
            // 
            this.sagaPage1.Controls.Add(this.addSagaFood);
            this.sagaPage1.Controls.Add(this.sagaRefresh);
            this.sagaPage1.Controls.Add(this.sagaFlowPanel);
            this.sagaPage1.Location = new System.Drawing.Point(4, 64);
            this.sagaPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sagaPage1.Name = "sagaPage1";
            this.sagaPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sagaPage1.Size = new System.Drawing.Size(397, 530);
            this.sagaPage1.TabIndex = 2;
            this.sagaPage1.Text = "Corner";
            this.sagaPage1.UseVisualStyleBackColor = true;
            // 
            // addSagaFood
            // 
            this.addSagaFood.Location = new System.Drawing.Point(4, 491);
            this.addSagaFood.Name = "addSagaFood";
            this.addSagaFood.Size = new System.Drawing.Size(100, 23);
            this.addSagaFood.TabIndex = 2;
            this.addSagaFood.Text = "Add Food";
            this.addSagaFood.UseVisualStyleBackColor = true;
            this.addSagaFood.Click += new System.EventHandler(this.addSagaFood_Click);
            // 
            // sagaRefresh
            // 
            this.sagaRefresh.Location = new System.Drawing.Point(110, 491);
            this.sagaRefresh.Name = "sagaRefresh";
            this.sagaRefresh.Size = new System.Drawing.Size(100, 23);
            this.sagaRefresh.TabIndex = 1;
            this.sagaRefresh.Text = "Refresh Page";
            this.sagaRefresh.UseVisualStyleBackColor = true;
            this.sagaRefresh.Click += new System.EventHandler(this.sagaRefresh_Click);
            // 
            // sagaFlowPanel
            // 
            this.sagaFlowPanel.AutoScroll = true;
            this.sagaFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.sagaFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sagaFlowPanel.Name = "sagaFlowPanel";
            this.sagaFlowPanel.Size = new System.Drawing.Size(395, 484);
            this.sagaFlowPanel.TabIndex = 0;
            // 
            // homePage1
            // 
            this.homePage1.Controls.Add(this.panel1);
            this.homePage1.Location = new System.Drawing.Point(4, 64);
            this.homePage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage1.Name = "homePage1";
            this.homePage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage1.Size = new System.Drawing.Size(397, 530);
            this.homePage1.TabIndex = 3;
            this.homePage1.Text = "Home";
            this.homePage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 380);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pasta (2.7)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 187);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Corner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Burrito Bowl (3.8)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chicken Tacos (4.2)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviewed Foods";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 608);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.accountPage1.ResumeLayout(false);
            this.hivePage1.ResumeLayout(false);
            this.sagaPage1.ResumeLayout(false);
            this.homePage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Account account1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage accountPage1;
        private System.Windows.Forms.TabPage hivePage1;
        private System.Windows.Forms.TabPage sagaPage1;
        private System.Windows.Forms.TabPage homePage1;
        private FlowLayoutPanel hiveFlowPanel;
        private FlowLayoutPanel sagaFlowPanel;
        private Button hiveRefresh;
        private Button sagaRefresh;
        private Button addHiveFood;
        private Button addSagaFood;
    }
}

