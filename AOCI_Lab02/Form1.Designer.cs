namespace AOCI_Lab02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DefaultImage = new Emgu.CV.UI.ImageBox();
            this.ProcessImage = new Emgu.CV.UI.ImageBox();
            this.OpenImageBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.KontrastBtn = new System.Windows.Forms.Button();
            this.HSVBtn = new System.Windows.Forms.Button();
            this.HSVBar = new System.Windows.Forms.TrackBar();
            this.BlurBtn = new System.Windows.Forms.Button();
            this.SharpBtn = new System.Windows.Forms.Button();
            this.FiltContrTxt = new System.Windows.Forms.TextBox();
            this.FiltContrTxt1 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt2 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt5 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt4 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt3 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt8 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt7 = new System.Windows.Forms.TextBox();
            this.FiltContrTxt6 = new System.Windows.Forms.TextBox();
            this.RGBTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSVBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultImage
            // 
            this.DefaultImage.Location = new System.Drawing.Point(12, 12);
            this.DefaultImage.Name = "DefaultImage";
            this.DefaultImage.Size = new System.Drawing.Size(640, 480);
            this.DefaultImage.TabIndex = 2;
            this.DefaultImage.TabStop = false;
            // 
            // ProcessImage
            // 
            this.ProcessImage.Location = new System.Drawing.Point(658, 12);
            this.ProcessImage.Name = "ProcessImage";
            this.ProcessImage.Size = new System.Drawing.Size(640, 480);
            this.ProcessImage.TabIndex = 3;
            this.ProcessImage.TabStop = false;
            // 
            // OpenImageBtn
            // 
            this.OpenImageBtn.Location = new System.Drawing.Point(12, 499);
            this.OpenImageBtn.Name = "OpenImageBtn";
            this.OpenImageBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenImageBtn.TabIndex = 4;
            this.OpenImageBtn.Text = "Open Image";
            this.OpenImageBtn.UseVisualStyleBackColor = true;
            this.OpenImageBtn.Click += new System.EventHandler(this.OpenImageBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(93, 499);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 5;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // KontrastBtn
            // 
            this.KontrastBtn.Location = new System.Drawing.Point(174, 499);
            this.KontrastBtn.Name = "KontrastBtn";
            this.KontrastBtn.Size = new System.Drawing.Size(75, 23);
            this.KontrastBtn.TabIndex = 6;
            this.KontrastBtn.Text = "Kontrast";
            this.KontrastBtn.UseVisualStyleBackColor = true;
            this.KontrastBtn.Click += new System.EventHandler(this.KontrastBtn_Click);
            // 
            // HSVBtn
            // 
            this.HSVBtn.Location = new System.Drawing.Point(255, 499);
            this.HSVBtn.Name = "HSVBtn";
            this.HSVBtn.Size = new System.Drawing.Size(75, 23);
            this.HSVBtn.TabIndex = 7;
            this.HSVBtn.Text = "HSV";
            this.HSVBtn.UseVisualStyleBackColor = true;
            this.HSVBtn.Click += new System.EventHandler(this.HSVBtn_Click);
            // 
            // HSVBar
            // 
            this.HSVBar.Location = new System.Drawing.Point(371, 499);
            this.HSVBar.Maximum = 255;
            this.HSVBar.Name = "HSVBar";
            this.HSVBar.Size = new System.Drawing.Size(281, 45);
            this.HSVBar.TabIndex = 8;
            this.HSVBar.Scroll += new System.EventHandler(this.HSVBar_Scroll);
            // 
            // BlurBtn
            // 
            this.BlurBtn.Location = new System.Drawing.Point(255, 538);
            this.BlurBtn.Name = "BlurBtn";
            this.BlurBtn.Size = new System.Drawing.Size(75, 23);
            this.BlurBtn.TabIndex = 9;
            this.BlurBtn.Text = "Blur";
            this.BlurBtn.UseVisualStyleBackColor = true;
            this.BlurBtn.Click += new System.EventHandler(this.BlurBtn_Click);
            // 
            // SharpBtn
            // 
            this.SharpBtn.Location = new System.Drawing.Point(174, 538);
            this.SharpBtn.Name = "SharpBtn";
            this.SharpBtn.Size = new System.Drawing.Size(75, 23);
            this.SharpBtn.TabIndex = 10;
            this.SharpBtn.Text = "Sharp";
            this.SharpBtn.UseVisualStyleBackColor = true;
            this.SharpBtn.Click += new System.EventHandler(this.SharpBtn_Click);
            // 
            // FiltContrTxt
            // 
            this.FiltContrTxt.Location = new System.Drawing.Point(659, 499);
            this.FiltContrTxt.MaxLength = 3;
            this.FiltContrTxt.Name = "FiltContrTxt";
            this.FiltContrTxt.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt.TabIndex = 11;
            // 
            // FiltContrTxt1
            // 
            this.FiltContrTxt1.Location = new System.Drawing.Point(701, 499);
            this.FiltContrTxt1.MaxLength = 3;
            this.FiltContrTxt1.Name = "FiltContrTxt1";
            this.FiltContrTxt1.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt1.TabIndex = 12;
            // 
            // FiltContrTxt2
            // 
            this.FiltContrTxt2.Location = new System.Drawing.Point(743, 499);
            this.FiltContrTxt2.MaxLength = 3;
            this.FiltContrTxt2.Name = "FiltContrTxt2";
            this.FiltContrTxt2.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt2.TabIndex = 13;
            // 
            // FiltContrTxt5
            // 
            this.FiltContrTxt5.Location = new System.Drawing.Point(743, 524);
            this.FiltContrTxt5.MaxLength = 3;
            this.FiltContrTxt5.Name = "FiltContrTxt5";
            this.FiltContrTxt5.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt5.TabIndex = 16;
            // 
            // FiltContrTxt4
            // 
            this.FiltContrTxt4.Location = new System.Drawing.Point(701, 524);
            this.FiltContrTxt4.MaxLength = 3;
            this.FiltContrTxt4.Name = "FiltContrTxt4";
            this.FiltContrTxt4.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt4.TabIndex = 15;
            // 
            // FiltContrTxt3
            // 
            this.FiltContrTxt3.Location = new System.Drawing.Point(659, 524);
            this.FiltContrTxt3.MaxLength = 3;
            this.FiltContrTxt3.Name = "FiltContrTxt3";
            this.FiltContrTxt3.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt3.TabIndex = 14;
            // 
            // FiltContrTxt8
            // 
            this.FiltContrTxt8.Location = new System.Drawing.Point(743, 550);
            this.FiltContrTxt8.MaxLength = 3;
            this.FiltContrTxt8.Name = "FiltContrTxt8";
            this.FiltContrTxt8.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt8.TabIndex = 19;
            // 
            // FiltContrTxt7
            // 
            this.FiltContrTxt7.Location = new System.Drawing.Point(701, 550);
            this.FiltContrTxt7.MaxLength = 3;
            this.FiltContrTxt7.Name = "FiltContrTxt7";
            this.FiltContrTxt7.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt7.TabIndex = 18;
            // 
            // FiltContrTxt6
            // 
            this.FiltContrTxt6.Location = new System.Drawing.Point(659, 550);
            this.FiltContrTxt6.MaxLength = 3;
            this.FiltContrTxt6.Name = "FiltContrTxt6";
            this.FiltContrTxt6.Size = new System.Drawing.Size(36, 20);
            this.FiltContrTxt6.TabIndex = 17;
            // 
            // RGBTxt
            // 
            this.RGBTxt.FormattingEnabled = true;
            this.RGBTxt.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.RGBTxt.Location = new System.Drawing.Point(371, 540);
            this.RGBTxt.Name = "RGBTxt";
            this.RGBTxt.Size = new System.Drawing.Size(121, 21);
            this.RGBTxt.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 627);
            this.Controls.Add(this.RGBTxt);
            this.Controls.Add(this.FiltContrTxt8);
            this.Controls.Add(this.FiltContrTxt7);
            this.Controls.Add(this.FiltContrTxt6);
            this.Controls.Add(this.FiltContrTxt5);
            this.Controls.Add(this.FiltContrTxt4);
            this.Controls.Add(this.FiltContrTxt3);
            this.Controls.Add(this.FiltContrTxt2);
            this.Controls.Add(this.FiltContrTxt1);
            this.Controls.Add(this.FiltContrTxt);
            this.Controls.Add(this.SharpBtn);
            this.Controls.Add(this.BlurBtn);
            this.Controls.Add(this.HSVBar);
            this.Controls.Add(this.HSVBtn);
            this.Controls.Add(this.KontrastBtn);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.OpenImageBtn);
            this.Controls.Add(this.ProcessImage);
            this.Controls.Add(this.DefaultImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSVBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox DefaultImage;
        private Emgu.CV.UI.ImageBox ProcessImage;
        private System.Windows.Forms.Button OpenImageBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Button KontrastBtn;
        private System.Windows.Forms.Button HSVBtn;
        private System.Windows.Forms.TrackBar HSVBar;
        private System.Windows.Forms.Button BlurBtn;
        private System.Windows.Forms.Button SharpBtn;
        private System.Windows.Forms.TextBox FiltContrTxt;
        private System.Windows.Forms.TextBox FiltContrTxt1;
        private System.Windows.Forms.TextBox FiltContrTxt2;
        private System.Windows.Forms.TextBox FiltContrTxt5;
        private System.Windows.Forms.TextBox FiltContrTxt4;
        private System.Windows.Forms.TextBox FiltContrTxt3;
        private System.Windows.Forms.TextBox FiltContrTxt8;
        private System.Windows.Forms.TextBox FiltContrTxt7;
        private System.Windows.Forms.TextBox FiltContrTxt6;
        private System.Windows.Forms.ComboBox RGBTxt;
    }
}

