
namespace HMPTM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DropDownFiller = new System.Windows.Forms.ComboBox();
            this.DropDownContainer = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DropDownFiller
            // 
            resources.ApplyResources(this.DropDownFiller, "DropDownFiller");
            this.DropDownFiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownFiller.FormattingEnabled = true;
            this.DropDownFiller.Name = "DropDownFiller";
            this.DropDownFiller.SelectedIndexChanged += new System.EventHandler(this.DropDownFiller_SelectedIndexChanged);
            // 
            // DropDownContainer
            // 
            resources.ApplyResources(this.DropDownContainer, "DropDownContainer");
            this.DropDownContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownContainer.FormattingEnabled = true;
            this.DropDownContainer.Name = "DropDownContainer";
            this.DropDownContainer.SelectedIndexChanged += new System.EventHandler(this.DropDownContainer_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DropDownContainer);
            this.Controls.Add(this.DropDownFiller);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropDownFiller;
        private System.Windows.Forms.ComboBox DropDownContainer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }

}

