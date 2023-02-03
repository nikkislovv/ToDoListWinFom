namespace ToDoList
{
    partial class TaskCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCreation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textToDoList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreating = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHeader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textToDoList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 84);
            this.panel1.TabIndex = 1;
            // 
            // textToDoList
            // 
            this.textToDoList.AutoSize = true;
            this.textToDoList.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToDoList.ForeColor = System.Drawing.Color.White;
            this.textToDoList.Location = new System.Drawing.Point(302, 18);
            this.textToDoList.Name = "textToDoList";
            this.textToDoList.Size = new System.Drawing.Size(343, 40);
            this.textToDoList.TabIndex = 1;
            this.textToDoList.Text = "Task Creation";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnCreating);
            this.panel2.Controls.Add(this.textDescription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textHeader);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 318);
            this.panel2.TabIndex = 2;
            // 
            // btnCreating
            // 
            this.btnCreating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreating.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreating.ForeColor = System.Drawing.Color.Black;
            this.btnCreating.Location = new System.Drawing.Point(388, 212);
            this.btnCreating.Name = "btnCreating";
            this.btnCreating.Size = new System.Drawing.Size(339, 51);
            this.btnCreating.TabIndex = 4;
            this.btnCreating.Text = "Create";
            this.btnCreating.UseVisualStyleBackColor = false;
            this.btnCreating.Click += new System.EventHandler(this.btnCreating_Click);
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(388, 129);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(339, 41);
            this.textDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // textHeader
            // 
            this.textHeader.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeader.Location = new System.Drawing.Point(388, 54);
            this.textHeader.Multiline = true;
            this.textHeader.Name = "textHeader";
            this.textHeader.Size = new System.Drawing.Size(339, 41);
            this.textHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header:";
            // 
            // TaskCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Creation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textToDoList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreating;
    }
}