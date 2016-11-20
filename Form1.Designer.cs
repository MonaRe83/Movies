namespace Movies_Students_Pro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MovieRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieDes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Movie = new System.Windows.Forms.TextBox();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.MovieD = new System.Windows.Forms.TextBox();
            this.MovieAct = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MovieReference No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MovieRating
            // 
            this.MovieRating.Location = new System.Drawing.Point(218, 292);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(160, 20);
            this.MovieRating.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Movie Rating";
            // 
            // MovieDes
            // 
            this.MovieDes.AutoSize = true;
            this.MovieDes.Location = new System.Drawing.Point(96, 366);
            this.MovieDes.Name = "MovieDes";
            this.MovieDes.Size = new System.Drawing.Size(44, 13);
            this.MovieDes.TabIndex = 7;
            this.MovieDes.Text = "MovieD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Movie Production Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Movie Actors";
            // 
            // Movie
            // 
            this.Movie.Location = new System.Drawing.Point(218, 240);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(160, 20);
            this.Movie.TabIndex = 10;
            this.Movie.TextChanged += new System.EventHandler(this.Movie_TextChanged);
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(218, 266);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(160, 20);
            this.MovieName.TabIndex = 11;
            // 
            // MovieD
            // 
            this.MovieD.Location = new System.Drawing.Point(218, 366);
            this.MovieD.Name = "MovieD";
            this.MovieD.Size = new System.Drawing.Size(160, 20);
            this.MovieD.TabIndex = 12;
            // 
            // MovieAct
            // 
            this.MovieAct.Location = new System.Drawing.Point(218, 316);
            this.MovieAct.Name = "MovieAct";
            this.MovieAct.Size = new System.Drawing.Size(160, 20);
            this.MovieAct.TabIndex = 13;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(73, 401);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Insert";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 457);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.MovieAct);
            this.Controls.Add(this.MovieD);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.Movie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MovieDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox MovieRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MovieDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Movie;
        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.TextBox MovieD;
        private System.Windows.Forms.TextBox MovieAct;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

