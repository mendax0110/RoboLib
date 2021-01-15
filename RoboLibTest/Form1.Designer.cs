namespace RoboLibTest
{
    partial class Roboter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roboter));
            this.pictureBox_room = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_left = new System.Windows.Forms.Button();
            this.button_faster = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_slower = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.button_party = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_room)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_room
            // 
            this.pictureBox_room.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_room.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_room.BackgroundImage")));
            this.pictureBox_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_room.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_room.Name = "pictureBox_room";
            this.pictureBox_room.Size = new System.Drawing.Size(515, 366);
            this.pictureBox_room.TabIndex = 0;
            this.pictureBox_room.TabStop = false;
            this.pictureBox_room.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autonomous:";
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(24, 434);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 3;
            this.button_left.Text = "Left";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_faster
            // 
            this.button_faster.Location = new System.Drawing.Point(118, 390);
            this.button_faster.Name = "button_faster";
            this.button_faster.Size = new System.Drawing.Size(75, 23);
            this.button_faster.TabIndex = 4;
            this.button_faster.Text = "Faster";
            this.button_faster.UseVisualStyleBackColor = true;
            this.button_faster.Click += new System.EventHandler(this.button_faster_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(211, 434);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 5;
            this.button_right.Text = "Right";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_slower
            // 
            this.button_slower.Location = new System.Drawing.Point(118, 476);
            this.button_slower.Name = "button_slower";
            this.button_slower.Size = new System.Drawing.Size(75, 23);
            this.button_slower.TabIndex = 6;
            this.button_slower.Text = "Slower";
            this.button_slower.UseVisualStyleBackColor = true;
            this.button_slower.Click += new System.EventHandler(this.button_slower_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(118, 434);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 23);
            this.button_move.TabIndex = 7;
            this.button_move.Text = "Move";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(9, 476);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(62, 16);
            this.label_speed.TabIndex = 8;
            this.label_speed.Text = "Speed: 0";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(452, 473);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 10;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(452, 390);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_party
            // 
            this.button_party.Location = new System.Drawing.Point(363, 473);
            this.button_party.Name = "button_party";
            this.button_party.Size = new System.Drawing.Size(75, 23);
            this.button_party.TabIndex = 11;
            this.button_party.Text = "Party!!";
            this.button_party.UseVisualStyleBackColor = true;
            this.button_party.Click += new System.EventHandler(this.button_party_Click);
            // 
            // Roboter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 511);
            this.Controls.Add(this.button_party);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_slower);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_faster);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_room);
            this.Name = "Roboter";
            this.Text = "Roboter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_faster;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_slower;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_party;
    }
}

