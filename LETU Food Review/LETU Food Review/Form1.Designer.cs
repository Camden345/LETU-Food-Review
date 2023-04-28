using System.Windows.Forms;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accountPage1 = new System.Windows.Forms.TabPage();
            this.accountFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hivePage1 = new System.Windows.Forms.TabPage();
            this.hiveFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sagaPage1 = new System.Windows.Forms.TabPage();
            this.sagaFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.accountPage1.SuspendLayout();
            this.hivePage1.SuspendLayout();
            this.sagaPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.accountPage1);
            this.tabControl1.Controls.Add(this.hivePage1);
            this.tabControl1.Controls.Add(this.sagaPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 608);
            this.tabControl1.TabIndex = 2;
            // 
            // accountPage1
            // 
            this.accountPage1.Controls.Add(this.accountFlowPanel);
            this.accountPage1.Location = new System.Drawing.Point(4, 64);
            this.accountPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPage1.Name = "accountPage1";
            this.accountPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPage1.Size = new System.Drawing.Size(397, 540);
            this.accountPage1.TabIndex = 0;
            this.accountPage1.Text = "Account";
            this.accountPage1.UseVisualStyleBackColor = true;
            // 
            // accountFlowPanel
            // 
            this.accountFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.accountFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.accountFlowPanel.Name = "accountFlowPanel";
            this.accountFlowPanel.Size = new System.Drawing.Size(395, 521);
            this.accountFlowPanel.TabIndex = 0;
            // 
            // hivePage1
            // 
            this.hivePage1.Controls.Add(this.hiveFlowPanel);
            this.hivePage1.Location = new System.Drawing.Point(4, 64);
            this.hivePage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hivePage1.Name = "hivePage1";
            this.hivePage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hivePage1.Size = new System.Drawing.Size(397, 540);
            this.hivePage1.TabIndex = 1;
            this.hivePage1.Text = "Hive";
            this.hivePage1.UseVisualStyleBackColor = true;
            // 
            // hiveFlowPanel
            // 
            this.hiveFlowPanel.AutoScroll = true;
            this.hiveFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.hiveFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.hiveFlowPanel.Name = "hiveFlowPanel";
            this.hiveFlowPanel.Size = new System.Drawing.Size(395, 521);
            this.hiveFlowPanel.TabIndex = 13;
            // 
            // sagaPage1
            // 
            this.sagaPage1.Controls.Add(this.sagaFlowPanel);
            this.sagaPage1.Location = new System.Drawing.Point(4, 64);
            this.sagaPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sagaPage1.Name = "sagaPage1";
            this.sagaPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sagaPage1.Size = new System.Drawing.Size(397, 540);
            this.sagaPage1.TabIndex = 2;
            this.sagaPage1.Text = "Corner";
            this.sagaPage1.UseVisualStyleBackColor = true;
            // 
            // sagaFlowPanel
            // 
            this.sagaFlowPanel.AutoScroll = true;
            this.sagaFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.sagaFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sagaFlowPanel.Name = "sagaFlowPanel";
            this.sagaFlowPanel.Size = new System.Drawing.Size(395, 521);
            this.sagaFlowPanel.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage accountPage1;
        private System.Windows.Forms.TabPage hivePage1;
        private System.Windows.Forms.TabPage sagaPage1;
        private FlowLayoutPanel hiveFlowPanel;
        private FlowLayoutPanel sagaFlowPanel;
        private FlowLayoutPanel accountFlowPanel;
    }
}

