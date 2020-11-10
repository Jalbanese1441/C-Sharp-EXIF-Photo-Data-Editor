
namespace WF_test
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
            this.back = new System.Windows.Forms.Button();
            this.openPicture = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeImageView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exposureTextBox = new System.Windows.Forms.TextBox();
            this.photoInfoTopPanel = new System.Windows.Forms.Panel();
            this.photoNameValue = new System.Windows.Forms.Label();
            this.resolutionValue = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.photoNamelabel = new System.Windows.Forms.Label();
            this.cameraModelTextBox = new System.Windows.Forms.TextBox();
            this.lensModelTextBox = new System.Windows.Forms.TextBox();
            this.DTTextBox = new System.Windows.Forms.TextBox();
            this.copyRightTextBox = new System.Windows.Forms.TextBox();
            this.flashTextBox = new System.Windows.Forms.TextBox();
            this.ISOTextBox = new System.Windows.Forms.TextBox();
            this.apertureTextBox = new System.Windows.Forms.TextBox();
            this.FLtextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FLLabel = new System.Windows.Forms.Label();
            this.cameraModelLabel = new System.Windows.Forms.Label();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.flashLabel = new System.Windows.Forms.Label();
            this.cameraMLabel = new System.Windows.Forms.Label();
            this.lensModelLabel = new System.Windows.Forms.Label();
            this.Aperturelabel = new System.Windows.Forms.Label();
            this.exposureLabel = new System.Windows.Forms.Label();
            this.DTLabel = new System.Windows.Forms.Label();
            this.ISOLabel = new System.Windows.Forms.Label();
            this.pasteValues = new System.Windows.Forms.Button();
            this.copyValues = new System.Windows.Forms.Button();
            this.cameraMTextBox = new System.Windows.Forms.TextBox();
            this.showOriginal = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.photoInfoTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.CausesValidation = false;
            this.back.Location = new System.Drawing.Point(30, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(184, 35);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // openPicture
            // 
            this.openPicture.CausesValidation = false;
            this.openPicture.Location = new System.Drawing.Point(252, 6);
            this.openPicture.Name = "openPicture";
            this.openPicture.Size = new System.Drawing.Size(185, 35);
            this.openPicture.TabIndex = 4;
            this.openPicture.Text = "Open new picture";
            this.openPicture.UseVisualStyleBackColor = true;
            this.openPicture.Click += new System.EventHandler(this.openPicture_Click);
            // 
            // next
            // 
            this.next.CausesValidation = false;
            this.next.Location = new System.Drawing.Point(684, 6);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(205, 35);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 556);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.changeImageView);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.openPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 56);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // changeImageView
            // 
            this.changeImageView.CausesValidation = false;
            this.changeImageView.Location = new System.Drawing.Point(458, 6);
            this.changeImageView.Name = "changeImageView";
            this.changeImageView.Size = new System.Drawing.Size(195, 35);
            this.changeImageView.TabIndex = 6;
            this.changeImageView.Text = "Fit image to screen";
            this.changeImageView.UseVisualStyleBackColor = true;
            this.changeImageView.Click += new System.EventHandler(this.changeImageView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exposureTextBox);
            this.panel2.Controls.Add(this.photoInfoTopPanel);
            this.panel2.Controls.Add(this.cameraModelTextBox);
            this.panel2.Controls.Add(this.lensModelTextBox);
            this.panel2.Controls.Add(this.DTTextBox);
            this.panel2.Controls.Add(this.copyRightTextBox);
            this.panel2.Controls.Add(this.flashTextBox);
            this.panel2.Controls.Add(this.ISOTextBox);
            this.panel2.Controls.Add(this.apertureTextBox);
            this.panel2.Controls.Add(this.FLtextBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.FLLabel);
            this.panel2.Controls.Add(this.cameraModelLabel);
            this.panel2.Controls.Add(this.copyRightLabel);
            this.panel2.Controls.Add(this.flashLabel);
            this.panel2.Controls.Add(this.cameraMLabel);
            this.panel2.Controls.Add(this.lensModelLabel);
            this.panel2.Controls.Add(this.Aperturelabel);
            this.panel2.Controls.Add(this.exposureLabel);
            this.panel2.Controls.Add(this.DTLabel);
            this.panel2.Controls.Add(this.ISOLabel);
            this.panel2.Controls.Add(this.pasteValues);
            this.panel2.Controls.Add(this.copyValues);
            this.panel2.Controls.Add(this.cameraMTextBox);
            this.panel2.Controls.Add(this.showOriginal);
            this.panel2.Controls.Add(this.save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 500);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exposureTextBox
            // 
            this.exposureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exposureTextBox.Location = new System.Drawing.Point(690, 394);
            this.exposureTextBox.Name = "exposureTextBox";
            this.exposureTextBox.Size = new System.Drawing.Size(210, 30);
            this.exposureTextBox.TabIndex = 40;
            // 
            // photoInfoTopPanel
            // 
            this.photoInfoTopPanel.Controls.Add(this.photoNameValue);
            this.photoInfoTopPanel.Controls.Add(this.resolutionValue);
            this.photoInfoTopPanel.Controls.Add(this.resolutionLabel);
            this.photoInfoTopPanel.Controls.Add(this.photoNamelabel);
            this.photoInfoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.photoInfoTopPanel.Location = new System.Drawing.Point(458, 0);
            this.photoInfoTopPanel.Name = "photoInfoTopPanel";
            this.photoInfoTopPanel.Size = new System.Drawing.Size(458, 34);
            this.photoInfoTopPanel.TabIndex = 39;
            // 
            // photoNameValue
            // 
            this.photoNameValue.AutoSize = true;
            this.photoNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoNameValue.Location = new System.Drawing.Point(113, 9);
            this.photoNameValue.Name = "photoNameValue";
            this.photoNameValue.Size = new System.Drawing.Size(110, 16);
            this.photoNameValue.TabIndex = 27;
            this.photoNameValue.Text = "Photo name here";
            // 
            // resolutionValue
            // 
            this.resolutionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionValue.AutoSize = true;
            this.resolutionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionValue.Location = new System.Drawing.Point(317, 9);
            this.resolutionValue.Name = "resolutionValue";
            this.resolutionValue.Size = new System.Drawing.Size(105, 16);
            this.resolutionValue.TabIndex = 26;
            this.resolutionValue.Text = "Resolution Here";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolutionLabel.Location = new System.Drawing.Point(229, 9);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(94, 16);
            this.resolutionLabel.TabIndex = 25;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // photoNamelabel
            // 
            this.photoNamelabel.AutoSize = true;
            this.photoNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoNamelabel.Location = new System.Drawing.Point(13, 9);
            this.photoNamelabel.Name = "photoNamelabel";
            this.photoNamelabel.Size = new System.Drawing.Size(94, 16);
            this.photoNamelabel.TabIndex = 24;
            this.photoNamelabel.Text = "Photo name:";
            this.photoNamelabel.Click += new System.EventHandler(this.photoNamelabel_Click);
            // 
            // cameraModelTextBox
            // 
            this.cameraModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraModelTextBox.Location = new System.Drawing.Point(690, 93);
            this.cameraModelTextBox.Name = "cameraModelTextBox";
            this.cameraModelTextBox.Size = new System.Drawing.Size(210, 30);
            this.cameraModelTextBox.TabIndex = 36;
            // 
            // lensModelTextBox
            // 
            this.lensModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lensModelTextBox.Location = new System.Drawing.Point(690, 129);
            this.lensModelTextBox.Name = "lensModelTextBox";
            this.lensModelTextBox.Size = new System.Drawing.Size(210, 30);
            this.lensModelTextBox.TabIndex = 35;
            // 
            // DTTextBox
            // 
            this.DTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTTextBox.Location = new System.Drawing.Point(690, 170);
            this.DTTextBox.Name = "DTTextBox";
            this.DTTextBox.Size = new System.Drawing.Size(210, 30);
            this.DTTextBox.TabIndex = 34;
            // 
            // copyRightTextBox
            // 
            this.copyRightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightTextBox.Location = new System.Drawing.Point(690, 206);
            this.copyRightTextBox.Name = "copyRightTextBox";
            this.copyRightTextBox.Size = new System.Drawing.Size(210, 30);
            this.copyRightTextBox.TabIndex = 33;
            this.copyRightTextBox.TextChanged += new System.EventHandler(this.copyRightTextBox_TextChanged);
            // 
            // flashTextBox
            // 
            this.flashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashTextBox.Location = new System.Drawing.Point(690, 242);
            this.flashTextBox.Name = "flashTextBox";
            this.flashTextBox.Size = new System.Drawing.Size(210, 30);
            this.flashTextBox.TabIndex = 32;
            // 
            // ISOTextBox
            // 
            this.ISOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISOTextBox.Location = new System.Drawing.Point(690, 281);
            this.ISOTextBox.Name = "ISOTextBox";
            this.ISOTextBox.Size = new System.Drawing.Size(210, 30);
            this.ISOTextBox.TabIndex = 31;
            // 
            // apertureTextBox
            // 
            this.apertureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apertureTextBox.Location = new System.Drawing.Point(690, 317);
            this.apertureTextBox.Name = "apertureTextBox";
            this.apertureTextBox.Size = new System.Drawing.Size(210, 30);
            this.apertureTextBox.TabIndex = 30;
            // 
            // FLtextBox
            // 
            this.FLtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLtextBox.Location = new System.Drawing.Point(690, 358);
            this.FLtextBox.Name = "FLtextBox";
            this.FLtextBox.Size = new System.Drawing.Size(210, 30);
            this.FLtextBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FLLabel
            // 
            this.FLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLLabel.Location = new System.Drawing.Point(474, 362);
            this.FLLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FLLabel.Name = "FLLabel";
            this.FLLabel.Size = new System.Drawing.Size(210, 25);
            this.FLLabel.TabIndex = 21;
            this.FLLabel.Text = "FocalLength:";
            // 
            // cameraModelLabel
            // 
            this.cameraModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraModelLabel.Location = new System.Drawing.Point(470, 93);
            this.cameraModelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cameraModelLabel.Name = "cameraModelLabel";
            this.cameraModelLabel.Size = new System.Drawing.Size(210, 25);
            this.cameraModelLabel.TabIndex = 20;
            this.cameraModelLabel.Text = "Camera Model:";
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLabel.Location = new System.Drawing.Point(470, 206);
            this.copyRightLabel.Margin = new System.Windows.Forms.Padding(0);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(210, 25);
            this.copyRightLabel.TabIndex = 19;
            this.copyRightLabel.Text = "Copy right information";
            this.copyRightLabel.Click += new System.EventHandler(this.copyRightLabel_Click);
            // 
            // flashLabel
            // 
            this.flashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashLabel.Location = new System.Drawing.Point(474, 242);
            this.flashLabel.Margin = new System.Windows.Forms.Padding(0);
            this.flashLabel.Name = "flashLabel";
            this.flashLabel.Size = new System.Drawing.Size(210, 25);
            this.flashLabel.TabIndex = 18;
            this.flashLabel.Text = "Flash:";
            // 
            // cameraMLabel
            // 
            this.cameraMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraMLabel.Location = new System.Drawing.Point(471, 47);
            this.cameraMLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cameraMLabel.Name = "cameraMLabel";
            this.cameraMLabel.Size = new System.Drawing.Size(210, 25);
            this.cameraMLabel.TabIndex = 17;
            this.cameraMLabel.Text = "Camera manufacturer:";
            // 
            // lensModelLabel
            // 
            this.lensModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lensModelLabel.Location = new System.Drawing.Point(470, 129);
            this.lensModelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lensModelLabel.Name = "lensModelLabel";
            this.lensModelLabel.Size = new System.Drawing.Size(210, 25);
            this.lensModelLabel.TabIndex = 16;
            this.lensModelLabel.Text = "Lens model:";
            // 
            // Aperturelabel
            // 
            this.Aperturelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aperturelabel.Location = new System.Drawing.Point(474, 321);
            this.Aperturelabel.Margin = new System.Windows.Forms.Padding(0);
            this.Aperturelabel.Name = "Aperturelabel";
            this.Aperturelabel.Size = new System.Drawing.Size(210, 25);
            this.Aperturelabel.TabIndex = 15;
            this.Aperturelabel.Text = "Aperture:";
            // 
            // exposureLabel
            // 
            this.exposureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exposureLabel.Location = new System.Drawing.Point(474, 399);
            this.exposureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.exposureLabel.Name = "exposureLabel";
            this.exposureLabel.Size = new System.Drawing.Size(210, 25);
            this.exposureLabel.TabIndex = 14;
            this.exposureLabel.Text = "Exposure:";
            // 
            // DTLabel
            // 
            this.DTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTLabel.Location = new System.Drawing.Point(470, 170);
            this.DTLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DTLabel.Name = "DTLabel";
            this.DTLabel.Size = new System.Drawing.Size(210, 25);
            this.DTLabel.TabIndex = 13;
            this.DTLabel.Text = "Date and time:";
            // 
            // ISOLabel
            // 
            this.ISOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISOLabel.Location = new System.Drawing.Point(474, 286);
            this.ISOLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ISOLabel.Name = "ISOLabel";
            this.ISOLabel.Size = new System.Drawing.Size(210, 25);
            this.ISOLabel.TabIndex = 11;
            this.ISOLabel.Text = "ISO:";
            // 
            // pasteValues
            // 
            this.pasteValues.CausesValidation = false;
            this.pasteValues.Location = new System.Drawing.Point(794, 431);
            this.pasteValues.Margin = new System.Windows.Forms.Padding(0);
            this.pasteValues.Name = "pasteValues";
            this.pasteValues.Size = new System.Drawing.Size(95, 25);
            this.pasteValues.TabIndex = 7;
            this.pasteValues.Text = "Paste values";
            this.pasteValues.UseVisualStyleBackColor = true;
            this.pasteValues.Click += new System.EventHandler(this.pasteValues_Click);
            // 
            // copyValues
            // 
            this.copyValues.CausesValidation = false;
            this.copyValues.Location = new System.Drawing.Point(690, 431);
            this.copyValues.Margin = new System.Windows.Forms.Padding(0);
            this.copyValues.Name = "copyValues";
            this.copyValues.Size = new System.Drawing.Size(95, 25);
            this.copyValues.TabIndex = 6;
            this.copyValues.Text = "Copy values";
            this.copyValues.UseVisualStyleBackColor = true;
            this.copyValues.Click += new System.EventHandler(this.copyValues_Click);
            // 
            // cameraMTextBox
            // 
            this.cameraMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraMTextBox.Location = new System.Drawing.Point(690, 47);
            this.cameraMTextBox.Name = "cameraMTextBox";
            this.cameraMTextBox.Size = new System.Drawing.Size(210, 30);
            this.cameraMTextBox.TabIndex = 4;
            this.cameraMTextBox.TextChanged += new System.EventHandler(this.cameraMTextBox_TextChanged);
            // 
            // showOriginal
            // 
            this.showOriginal.CausesValidation = false;
            this.showOriginal.Location = new System.Drawing.Point(575, 431);
            this.showOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.showOriginal.Name = "showOriginal";
            this.showOriginal.Size = new System.Drawing.Size(95, 25);
            this.showOriginal.TabIndex = 3;
            this.showOriginal.Text = "Reset values";
            this.showOriginal.UseVisualStyleBackColor = true;
            this.showOriginal.Click += new System.EventHandler(this.showOriginal_Click);
            // 
            // save
            // 
            this.save.CausesValidation = false;
            this.save.Location = new System.Drawing.Point(474, 431);
            this.save.Margin = new System.Windows.Forms.Padding(0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 25);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.openFileDialog.Title = "Choose a picture to open";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(932, 595);
            this.Name = "Form1";
            this.Text = "EXIF Metadata Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.photoInfoTopPanel.ResumeLayout(false);
            this.photoInfoTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button openPicture;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeImageView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cameraMTextBox;
        private System.Windows.Forms.Button showOriginal;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button pasteValues;
        private System.Windows.Forms.Button copyValues;
        private System.Windows.Forms.Label FLLabel;
        private System.Windows.Forms.Label cameraModelLabel;
        private System.Windows.Forms.Label copyRightLabel;
        private System.Windows.Forms.Label flashLabel;
        private System.Windows.Forms.Label cameraMLabel;
        private System.Windows.Forms.Label lensModelLabel;
        private System.Windows.Forms.Label Aperturelabel;
        private System.Windows.Forms.Label exposureLabel;
        private System.Windows.Forms.Label DTLabel;
        private System.Windows.Forms.Label ISOLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cameraModelTextBox;
        private System.Windows.Forms.TextBox lensModelTextBox;
        private System.Windows.Forms.TextBox DTTextBox;
        private System.Windows.Forms.TextBox copyRightTextBox;
        private System.Windows.Forms.TextBox flashTextBox;
        private System.Windows.Forms.TextBox ISOTextBox;
        private System.Windows.Forms.TextBox apertureTextBox;
        private System.Windows.Forms.TextBox FLtextBox;
        private System.Windows.Forms.Panel photoInfoTopPanel;
        private System.Windows.Forms.Label photoNameValue;
        private System.Windows.Forms.Label resolutionValue;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label photoNamelabel;
        private System.Windows.Forms.TextBox exposureTextBox;
    }
}

