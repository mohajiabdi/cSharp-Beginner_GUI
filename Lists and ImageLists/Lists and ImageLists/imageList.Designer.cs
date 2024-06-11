namespace Lists_and_ImageLists
{
    partial class imageList
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imageList));
            picSHow = new PictureBox();
            btnChange = new Button();
            imgLists = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picSHow).BeginInit();
            SuspendLayout();
            // 
            // picSHow
            // 
            picSHow.Location = new Point(237, 49);
            picSHow.Name = "picSHow";
            picSHow.Size = new Size(256, 256);
            picSHow.TabIndex = 0;
            picSHow.TabStop = false;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(499, 160);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(140, 47);
            btnChange.TabIndex = 1;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // imgLists
            // 
            imgLists.ColorDepth = ColorDepth.Depth32Bit;
            imgLists.ImageStream = (ImageListStreamer)resources.GetObject("imgLists.ImageStream");
            imgLists.TransparentColor = Color.Transparent;
            imgLists.Images.SetKeyName(0, "learning.ico");
            imgLists.Images.SetKeyName(1, "graduation-_1_.ico");
            imgLists.Images.SetKeyName(2, "reservation.png");
            imgLists.Images.SetKeyName(3, "cutlery.ico");
            imgLists.Images.SetKeyName(4, "limousine.png");
            imgLists.Images.SetKeyName(5, "cutlery.png");
            imgLists.Images.SetKeyName(6, "pexels-mateusz-chodakowski-693895.jpg");
            imgLists.Images.SetKeyName(7, "5-stars.png");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // imageList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChange);
            Controls.Add(picSHow);
            Name = "imageList";
            Text = "imageList";
            ((System.ComponentModel.ISupportInitialize)picSHow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSHow;
        private Button btnChange;
        private ImageList imgLists;
        private System.Windows.Forms.Timer timer1;
    }
}