using System.Windows.Forms;

namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoving = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textToDoList = new System.Windows.Forms.Label();
            this.ListBoxTasks = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnRemoving);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textToDoList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoving
            // 
            this.btnRemoving.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoving.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoving.BackgroundImage")));
            this.btnRemoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoving.Location = new System.Drawing.Point(767, 0);
            this.btnRemoving.Name = "btnRemoving";
            this.btnRemoving.Size = new System.Drawing.Size(77, 70);
            this.btnRemoving.TabIndex = 3;
            this.btnRemoving.UseVisualStyleBackColor = false;
            this.btnRemoving.Click += new System.EventHandler(this.btnRemoving_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(840, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textToDoList
            // 
            this.textToDoList.AutoSize = true;
            this.textToDoList.Font = new System.Drawing.Font("Swis721 BlkEx BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToDoList.ForeColor = System.Drawing.Color.White;
            this.textToDoList.Location = new System.Drawing.Point(348, 14);
            this.textToDoList.Name = "textToDoList";
            this.textToDoList.Size = new System.Drawing.Size(217, 40);
            this.textToDoList.TabIndex = 1;
            this.textToDoList.Text = "ToDoList";
            // 
            // ListBoxTasks
            // 
            this.ListBoxTasks.BackColor = System.Drawing.Color.Silver;
            this.ListBoxTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBoxTasks.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxTasks.FormattingEnabled = true;
            this.ListBoxTasks.HorizontalScrollbar = true;
            this.ListBoxTasks.ItemHeight = 36;
            this.ListBoxTasks.Location = new System.Drawing.Point(0, 71);
            this.ListBoxTasks.Name = "ListBoxTasks";
            this.ListBoxTasks.Size = new System.Drawing.Size(920, 504);
            this.ListBoxTasks.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 563);
            this.Controls.Add(this.ListBoxTasks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textToDoList;
        private Button button1;
        private ListBox ListBoxTasks;
        private Button btnRemoving;
    }
}

