using System.Windows.Forms;

namespace FileCleaner.Views
{
    partial class MainFormView
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.firstPathLabel = new System.Windows.Forms.Label();
            this.secondPathLabel = new System.Windows.Forms.Label();
            this.fileExtensionsLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.warningLabel = new System.Windows.Forms.Label();
            this.secondPathButton = new System.Windows.Forms.Button();
            this.firstPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programNameLabel.Location = new System.Drawing.Point(231, 9);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(259, 60);
            this.programNameLabel.TabIndex = 0;
            this.programNameLabel.Text = "File Cleaner";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 38);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 213);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(601, 38);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 293);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(601, 38);
            this.textBox3.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(522, 377);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 51);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(12, 392);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(84, 36);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Done!";
            this.infoLabel.Visible = false;
            // 
            // firstPathLabel
            // 
            this.firstPathLabel.AutoSize = true;
            this.firstPathLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstPathLabel.Location = new System.Drawing.Point(12, 89);
            this.firstPathLabel.Name = "firstPathLabel";
            this.firstPathLabel.Size = new System.Drawing.Size(127, 36);
            this.firstPathLabel.TabIndex = 9;
            this.firstPathLabel.Text = "First path";
            // 
            // secondPathLabel
            // 
            this.secondPathLabel.AutoSize = true;
            this.secondPathLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondPathLabel.Location = new System.Drawing.Point(12, 174);
            this.secondPathLabel.Name = "secondPathLabel";
            this.secondPathLabel.Size = new System.Drawing.Size(287, 36);
            this.secondPathLabel.TabIndex = 10;
            this.secondPathLabel.Text = "Second path (Optional)";
            // 
            // fileExtensionsLabel
            // 
            this.fileExtensionsLabel.AutoSize = true;
            this.fileExtensionsLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileExtensionsLabel.Location = new System.Drawing.Point(12, 254);
            this.fileExtensionsLabel.Name = "fileExtensionsLabel";
            this.fileExtensionsLabel.Size = new System.Drawing.Size(181, 36);
            this.fileExtensionsLabel.TabIndex = 11;
            this.fileExtensionsLabel.Text = "File extension";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(240, 392);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(276, 36);
            this.warningLabel.TabIndex = 12;
            this.warningLabel.Text = "Not all fields are filled";
            this.warningLabel.Visible = false;
            // 
            // secondPathButton
            // 
            this.secondPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondPathButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondPathButton.Location = new System.Drawing.Point(633, 213);
            this.secondPathButton.Name = "secondPathButton";
            this.secondPathButton.Size = new System.Drawing.Size(91, 38);
            this.secondPathButton.TabIndex = 5;
            this.secondPathButton.Text = "Choose";
            this.secondPathButton.UseVisualStyleBackColor = true;
            // 
            // firstPathButton
            // 
            this.firstPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstPathButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstPathButton.Location = new System.Drawing.Point(633, 128);
            this.firstPathButton.Name = "firstPathButton";
            this.firstPathButton.Size = new System.Drawing.Size(91, 38);
            this.firstPathButton.TabIndex = 4;
            this.firstPathButton.Text = "Choose";
            this.firstPathButton.UseVisualStyleBackColor = true;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.fileExtensionsLabel);
            this.Controls.Add(this.secondPathLabel);
            this.Controls.Add(this.firstPathLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondPathButton);
            this.Controls.Add(this.firstPathButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.programNameLabel);
            this.Name = "MainFormView";
            this.Text = "File Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label programNameLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button startButton;
        private Label infoLabel;
        private Label firstPathLabel;
        private Label secondPathLabel;
        private Label fileExtensionsLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label warningLabel;
        private Button secondPathButton;
        private Button firstPathButton;
    }
}