namespace frontend
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
            this.label3 = new System.Windows.Forms.Label();
            this.postCode1Input = new MaterialSkin.Controls.MaterialTextBox2();
            this.postCode2Input = new MaterialSkin.Controls.MaterialTextBox2();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(393, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 38);
            this.label3.TabIndex = 3;
            // 
            // postCode1Input
            // 
            this.postCode1Input.AnimateReadOnly = false;
            this.postCode1Input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.postCode1Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.postCode1Input.Depth = 0;
            this.postCode1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.postCode1Input.HideSelection = true;
            this.postCode1Input.LeadingIcon = null;
            this.postCode1Input.Location = new System.Drawing.Point(8, 73);
            this.postCode1Input.MaxLength = 32767;
            this.postCode1Input.MouseState = MaterialSkin.MouseState.OUT;
            this.postCode1Input.Name = "postCode1Input";
            this.postCode1Input.PasswordChar = '\0';
            this.postCode1Input.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.postCode1Input.PrefixSuffixText = "Postcode 1:";
            this.postCode1Input.ReadOnly = false;
            this.postCode1Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postCode1Input.SelectedText = "";
            this.postCode1Input.SelectionLength = 0;
            this.postCode1Input.SelectionStart = 0;
            this.postCode1Input.ShortcutsEnabled = true;
            this.postCode1Input.Size = new System.Drawing.Size(278, 48);
            this.postCode1Input.TabIndex = 8;
            this.postCode1Input.TabStop = false;
            this.postCode1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.postCode1Input.TrailingIcon = null;
            this.postCode1Input.UseSystemPasswordChar = false;
            this.postCode1Input.Click += new System.EventHandler(this.postCode1Input_Click);
            // 
            // postCode2Input
            // 
            this.postCode2Input.AnimateReadOnly = false;
            this.postCode2Input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.postCode2Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.postCode2Input.Depth = 0;
            this.postCode2Input.ErrorMessage = "Enter a valid postcode";
            this.postCode2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.postCode2Input.HideSelection = true;
            this.postCode2Input.LeadingIcon = null;
            this.postCode2Input.Location = new System.Drawing.Point(292, 73);
            this.postCode2Input.MaxLength = 32767;
            this.postCode2Input.MouseState = MaterialSkin.MouseState.OUT;
            this.postCode2Input.Name = "postCode2Input";
            this.postCode2Input.PasswordChar = '\0';
            this.postCode2Input.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.postCode2Input.PrefixSuffixText = "Postcode 2:";
            this.postCode2Input.ReadOnly = false;
            this.postCode2Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postCode2Input.SelectedText = "";
            this.postCode2Input.SelectionLength = 0;
            this.postCode2Input.SelectionStart = 0;
            this.postCode2Input.ShortcutsEnabled = true;
            this.postCode2Input.Size = new System.Drawing.Size(278, 48);
            this.postCode2Input.TabIndex = 9;
            this.postCode2Input.TabStop = false;
            this.postCode2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.postCode2Input.TrailingIcon = null;
            this.postCode2Input.UseSystemPasswordChar = false;
            this.postCode2Input.Click += new System.EventHandler(this.postCode2Input_Click);
            // 
            // submitButton
            // 
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(583, 79);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(20, 142);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 29);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Origin:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(20, 177);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 29);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Dest:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(20, 212);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 29);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Driving Time:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(20, 245);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 29);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Distance: ";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(8, 127);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(562, 5);
            this.materialProgressBar1.TabIndex = 15;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(558, 22);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(68, 48);
            this.materialSwitch1.TabIndex = 16;
            this.materialSwitch1.UseVisualStyleBackColor = false;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(479, 22);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 47);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Miles";
            // 
            // materialLabel6
            // 
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(618, 22);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 43);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "KM";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(8, 428);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(654, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Developed by Umar Farooq | Data retrieved from Google Maps API |  Made with Visua" +
    "l Studio";
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.postCode2Input);
            this.Controls.Add(this.postCode1Input);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Enter Two Postcodes Below";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 postCode1Input;
        private MaterialSkin.Controls.MaterialTextBox2 postCode2Input;
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}