namespace Keker
{
    partial class Main
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
            this.btnOpen = new PearXLib.Engine.Flat.FlatButton();
            this.imgKek = new System.Windows.Forms.PictureBox();
            this.dgOpen = new System.Windows.Forms.OpenFileDialog();
            this.useAlternative = new PearXLib.Engine.Flat.FlatCheckbox();
            this.dgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new PearXLib.Engine.Flat.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgKek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Border = 0;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.Location = new System.Drawing.Point(12, 257);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(401, 64);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Select Image";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpen.UseInterpolation = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imgKek
            // 
            this.imgKek.Location = new System.Drawing.Point(12, 40);
            this.imgKek.Name = "imgKek";
            this.imgKek.Size = new System.Drawing.Size(401, 211);
            this.imgKek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgKek.TabIndex = 1;
            this.imgKek.TabStop = false;
            // 
            // dgOpen
            // 
            this.dgOpen.Filter = "Images|*.jpg;*.jpeg;*.png;*.tiff;*.gif;*.bmp";
            this.dgOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.dgOpen_FileOk);
            // 
            // useAlternative
            // 
            this.useAlternative.ColorBGFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.useAlternative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useAlternative.Location = new System.Drawing.Point(12, 327);
            this.useAlternative.Name = "useAlternative";
            this.useAlternative.Size = new System.Drawing.Size(194, 40);
            this.useAlternative.TabIndex = 2;
            this.useAlternative.Text = "Use another side";
            this.useAlternative.UseInterpolation = false;
            // 
            // dgSave
            // 
            this.dgSave.Filter = "PNG|*.png";
            this.dgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.dgSave_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Border = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(212, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseInterpolation = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 374);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.useAlternative);
            this.Controls.Add(this.imgKek);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "KEKER - Make Kek-Style Images";
            ((System.ComponentModel.ISupportInitialize)(this.imgKek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PearXLib.Engine.Flat.FlatButton btnOpen;
        private System.Windows.Forms.PictureBox imgKek;
        private System.Windows.Forms.OpenFileDialog dgOpen;
        private PearXLib.Engine.Flat.FlatCheckbox useAlternative;
        private System.Windows.Forms.SaveFileDialog dgSave;
        private PearXLib.Engine.Flat.FlatButton btnSave;
    }
}

