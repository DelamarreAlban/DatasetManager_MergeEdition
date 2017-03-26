namespace DatasetManager
{
    partial class DatasetManager
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
            this.loadFolderDatasetButton = new System.Windows.Forms.Button();
            this.filePathtextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Label();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.readyToExportlabel = new System.Windows.Forms.Label();
            this.generatedlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadFolderDatasetButton
            // 
            this.loadFolderDatasetButton.Location = new System.Drawing.Point(24, 23);
            this.loadFolderDatasetButton.Margin = new System.Windows.Forms.Padding(6);
            this.loadFolderDatasetButton.Name = "loadFolderDatasetButton";
            this.loadFolderDatasetButton.Size = new System.Drawing.Size(176, 44);
            this.loadFolderDatasetButton.TabIndex = 0;
            this.loadFolderDatasetButton.Text = "Dataset Folder";
            this.loadFolderDatasetButton.UseVisualStyleBackColor = true;
            this.loadFolderDatasetButton.Click += new System.EventHandler(this.loadDatasetFolderButton_Click);
            // 
            // filePathtextBox
            // 
            this.filePathtextBox.Location = new System.Drawing.Point(252, 29);
            this.filePathtextBox.Margin = new System.Windows.Forms.Padding(6);
            this.filePathtextBox.Name = "filePathtextBox";
            this.filePathtextBox.Size = new System.Drawing.Size(354, 31);
            this.filePathtextBox.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(373, 100);
            this.generateButton.Margin = new System.Windows.Forms.Padding(6);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(302, 44);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate new dataset";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(19, 113);
            this.n.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(80, 25);
            this.n.TabIndex = 4;
            this.n.Text = "Name :";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(111, 107);
            this.newNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(250, 31);
            this.newNameTextBox.TabIndex = 5;
            // 
            // readyToExportlabel
            // 
            this.readyToExportlabel.AutoSize = true;
            this.readyToExportlabel.Location = new System.Drawing.Point(680, 29);
            this.readyToExportlabel.Name = "readyToExportlabel";
            this.readyToExportlabel.Size = new System.Drawing.Size(0, 25);
            this.readyToExportlabel.TabIndex = 6;
            // 
            // generatedlabel
            // 
            this.generatedlabel.AutoSize = true;
            this.generatedlabel.Location = new System.Drawing.Point(727, 113);
            this.generatedlabel.Name = "generatedlabel";
            this.generatedlabel.Size = new System.Drawing.Size(0, 25);
            this.generatedlabel.TabIndex = 7;
            // 
            // DatasetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 185);
            this.Controls.Add(this.generatedlabel);
            this.Controls.Add(this.readyToExportlabel);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.n);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.filePathtextBox);
            this.Controls.Add(this.loadFolderDatasetButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DatasetManager";
            this.Text = "DatasetManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFolderDatasetButton;
        private System.Windows.Forms.TextBox filePathtextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label readyToExportlabel;
        private System.Windows.Forms.Label generatedlabel;
    }
}

