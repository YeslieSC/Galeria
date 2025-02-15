namespace ImageGallery
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddImages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddImages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // flowLayoutPanel1
            
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 370);
            this.flowLayoutPanel1.TabIndex = 0;
            
            // btnAddImages
            
            this.btnAddImages.Location = new System.Drawing.Point(338, 400);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(124, 29);
            this.btnAddImages.TabIndex = 1;
            this.btnAddImages.Text = "Agregar Imágenes";
            this.btnAddImages.UseVisualStyleBackColor = true;
            this.btnAddImages.Click += new System.EventHandler(this.btnAddImages_Click);
            
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddImages);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }
}