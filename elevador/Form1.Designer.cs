namespace elevador
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
            components = new System.ComponentModel.Container();
            btn_close = new Button();
            btn_open = new Button();
            btn_alarm = new Button();
            btn_G = new Button();
            btn_1 = new Button();
            btn_down = new Button();
            btn_up = new Button();
            timer_lift_down = new System.Windows.Forms.Timer(components);
            timer_lift_up = new System.Windows.Forms.Timer(components);
            timer_door_close_down = new System.Windows.Forms.Timer(components);
            timer_door_open_up = new System.Windows.Forms.Timer(components);
            timer_door_open_down = new System.Windows.Forms.Timer(components);
            timer_door_close_up = new System.Windows.Forms.Timer(components);
            picture_lift = new PictureBox();
            bg_firstfloor = new PictureBox();
            door_right_up = new PictureBox();
            door_left_up = new PictureBox();
            concrete = new PictureBox();
            bg_groundfloor = new PictureBox();
            door_left_down = new PictureBox();
            door_right_down = new PictureBox();
            bg_panel = new PictureBox();
            display_panel = new PictureBox();
            btn_exit = new Button();
            door_right_mid = new PictureBox();
            door_left_mid = new PictureBox();
            bg_mid = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_mid = new Button();
            timer_lift_mid = new System.Windows.Forms.Timer(components);
            timer_door_open_mid = new System.Windows.Forms.Timer(components);
            timer_door_close_mid = new System.Windows.Forms.Timer(components);
            btn_middle = new Button();
            timer_lift_mid2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picture_lift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_firstfloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_right_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_left_up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)concrete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_groundfloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_left_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_right_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)display_panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_right_mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door_left_mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = Properties.Resources.closedoorsbutton;
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Location = new Point(328, 513);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(42, 40);
            btn_close.TabIndex = 0;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_open
            // 
            btn_open.BackgroundImage = Properties.Resources.opendoorbutton;
            btn_open.BackgroundImageLayout = ImageLayout.Zoom;
            btn_open.Location = new Point(380, 513);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(42, 40);
            btn_open.TabIndex = 1;
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_alarm
            // 
            btn_alarm.BackgroundImage = Properties.Resources.alarmbellbutton;
            btn_alarm.BackgroundImageLayout = ImageLayout.Zoom;
            btn_alarm.Location = new Point(354, 569);
            btn_alarm.Name = "btn_alarm";
            btn_alarm.Size = new Size(42, 40);
            btn_alarm.TabIndex = 2;
            btn_alarm.UseVisualStyleBackColor = true;
            btn_alarm.Click += btn_alarm_Click;
            // 
            // btn_G
            // 
            btn_G.BackgroundImage = Properties.Resources.pbfloorbutton;
            btn_G.BackgroundImageLayout = ImageLayout.Zoom;
            btn_G.Location = new Point(354, 456);
            btn_G.Name = "btn_G";
            btn_G.Size = new Size(40, 40);
            btn_G.TabIndex = 3;
            btn_G.UseVisualStyleBackColor = true;
            btn_G.Click += btn_G_Click;
            // 
            // btn_1
            // 
            btn_1.BackgroundImage = Properties.Resources.secondfloorbutton;
            btn_1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_1.Location = new Point(354, 364);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(40, 40);
            btn_1.TabIndex = 4;
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_2_Click;
            // 
            // btn_down
            // 
            btn_down.BackColor = Color.Transparent;
            btn_down.BackgroundImage = Properties.Resources.floorbutton;
            btn_down.BackgroundImageLayout = ImageLayout.Zoom;
            btn_down.Location = new Point(199, 658);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(35, 34);
            btn_down.TabIndex = 5;
            btn_down.UseVisualStyleBackColor = false;
            btn_down.Click += btn_up_Click;
            // 
            // btn_up
            // 
            btn_up.BackColor = Color.Transparent;
            btn_up.BackgroundImage = Properties.Resources.floorbutton;
            btn_up.BackgroundImageLayout = ImageLayout.Zoom;
            btn_up.Location = new Point(199, 128);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(35, 34);
            btn_up.TabIndex = 6;
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_down_Click;
            // 
            // timer_lift_down
            // 
            timer_lift_down.Interval = 8;
            timer_lift_down.Tick += timer_lift_down_Tick;
            // 
            // timer_lift_up
            // 
            timer_lift_up.Interval = 8;
            timer_lift_up.Tick += timer_lift_up_Tick;
            // 
            // timer_door_close_down
            // 
            timer_door_close_down.Interval = 5;
            timer_door_close_down.Tick += door_close_down_Tick;
            // 
            // timer_door_open_up
            // 
            timer_door_open_up.Interval = 5;
            timer_door_open_up.Tick += timer_door_open_up_Tick;
            // 
            // timer_door_open_down
            // 
            timer_door_open_down.Interval = 5;
            timer_door_open_down.Tick += door_open_down_Tick;
            // 
            // timer_door_close_up
            // 
            timer_door_close_up.Interval = 5;
            timer_door_close_up.Tick += timer_door_close_up_Tick;
            // 
            // picture_lift
            // 
            picture_lift.BackColor = Color.Transparent;
            picture_lift.Image = Properties.Resources.Inside_of_the_lift;
            picture_lift.Location = new Point(77, 70);
            picture_lift.Name = "picture_lift";
            picture_lift.Size = new Size(104, 155);
            picture_lift.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_lift.TabIndex = 7;
            picture_lift.TabStop = false;
            // 
            // bg_firstfloor
            // 
            bg_firstfloor.BackColor = Color.Transparent;
            bg_firstfloor.Image = Properties.Resources.First_Floor;
            bg_firstfloor.Location = new Point(12, 12);
            bg_firstfloor.Name = "bg_firstfloor";
            bg_firstfloor.Size = new Size(237, 262);
            bg_firstfloor.SizeMode = PictureBoxSizeMode.Zoom;
            bg_firstfloor.TabIndex = 8;
            bg_firstfloor.TabStop = false;
            // 
            // door_right_up
            // 
            door_right_up.BackColor = Color.Transparent;
            door_right_up.Image = Properties.Resources.lift_door_right;
            door_right_up.Location = new Point(129, 70);
            door_right_up.Name = "door_right_up";
            door_right_up.Size = new Size(52, 155);
            door_right_up.SizeMode = PictureBoxSizeMode.StretchImage;
            door_right_up.TabIndex = 9;
            door_right_up.TabStop = false;
            // 
            // door_left_up
            // 
            door_left_up.BackColor = Color.Transparent;
            door_left_up.Image = Properties.Resources.lift_door_left;
            door_left_up.Location = new Point(77, 70);
            door_left_up.Name = "door_left_up";
            door_left_up.Size = new Size(52, 155);
            door_left_up.SizeMode = PictureBoxSizeMode.StretchImage;
            door_left_up.TabIndex = 10;
            door_left_up.TabStop = false;
            // 
            // concrete
            // 
            concrete.BackColor = Color.Transparent;
            concrete.Image = Properties.Resources.concrete;
            concrete.Location = new Point(15, 521);
            concrete.Name = "concrete";
            concrete.Size = new Size(229, 27);
            concrete.SizeMode = PictureBoxSizeMode.StretchImage;
            concrete.TabIndex = 11;
            concrete.TabStop = false;
            // 
            // bg_groundfloor
            // 
            bg_groundfloor.BackColor = Color.Transparent;
            bg_groundfloor.Image = Properties.Resources.Ground_Floor;
            bg_groundfloor.Location = new Point(12, 541);
            bg_groundfloor.Name = "bg_groundfloor";
            bg_groundfloor.Size = new Size(237, 262);
            bg_groundfloor.SizeMode = PictureBoxSizeMode.Zoom;
            bg_groundfloor.TabIndex = 12;
            bg_groundfloor.TabStop = false;
            // 
            // door_left_down
            // 
            door_left_down.BackColor = Color.Transparent;
            door_left_down.Image = Properties.Resources.lift_door_left;
            door_left_down.Location = new Point(77, 598);
            door_left_down.Name = "door_left_down";
            door_left_down.Size = new Size(52, 155);
            door_left_down.SizeMode = PictureBoxSizeMode.StretchImage;
            door_left_down.TabIndex = 13;
            door_left_down.TabStop = false;
            // 
            // door_right_down
            // 
            door_right_down.BackColor = Color.Transparent;
            door_right_down.Image = Properties.Resources.lift_door_right;
            door_right_down.Location = new Point(129, 598);
            door_right_down.Name = "door_right_down";
            door_right_down.Size = new Size(52, 155);
            door_right_down.SizeMode = PictureBoxSizeMode.StretchImage;
            door_right_down.TabIndex = 14;
            door_right_down.TabStop = false;
            // 
            // bg_panel
            // 
            bg_panel.Image = Properties.Resources.panel;
            bg_panel.Location = new Point(312, 240);
            bg_panel.Name = "bg_panel";
            bg_panel.Size = new Size(124, 394);
            bg_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            bg_panel.TabIndex = 15;
            bg_panel.TabStop = false;
            // 
            // display_panel
            // 
            display_panel.BackColor = Color.Black;
            display_panel.Image = Properties.Resources.black;
            display_panel.Location = new Point(344, 275);
            display_panel.Name = "display_panel";
            display_panel.Size = new Size(60, 70);
            display_panel.SizeMode = PictureBoxSizeMode.StretchImage;
            display_panel.TabIndex = 16;
            display_panel.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.BackgroundImageLayout = ImageLayout.None;
            btn_exit.Font = new Font("LEMON MILK Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(459, 774);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 29);
            btn_exit.TabIndex = 17;
            btn_exit.Text = "Salir";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // door_right_mid
            // 
            door_right_mid.BackColor = Color.Transparent;
            door_right_mid.Image = Properties.Resources.lift_door_right;
            door_right_mid.Location = new Point(129, 330);
            door_right_mid.Name = "door_right_mid";
            door_right_mid.Size = new Size(52, 155);
            door_right_mid.SizeMode = PictureBoxSizeMode.StretchImage;
            door_right_mid.TabIndex = 22;
            door_right_mid.TabStop = false;
            // 
            // door_left_mid
            // 
            door_left_mid.BackColor = Color.Transparent;
            door_left_mid.Image = Properties.Resources.lift_door_left;
            door_left_mid.Location = new Point(77, 330);
            door_left_mid.Name = "door_left_mid";
            door_left_mid.Size = new Size(52, 155);
            door_left_mid.SizeMode = PictureBoxSizeMode.StretchImage;
            door_left_mid.TabIndex = 21;
            door_left_mid.TabStop = false;
            // 
            // bg_mid
            // 
            bg_mid.BackColor = Color.Transparent;
            bg_mid.Image = Properties.Resources.Ground_Floor;
            bg_mid.Location = new Point(12, 273);
            bg_mid.Name = "bg_mid";
            bg_mid.Size = new Size(237, 262);
            bg_mid.SizeMode = PictureBoxSizeMode.Zoom;
            bg_mid.TabIndex = 20;
            bg_mid.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.concrete;
            pictureBox1.Location = new Point(15, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btn_mid
            // 
            btn_mid.BackColor = Color.Transparent;
            btn_mid.BackgroundImage = Properties.Resources.floorbutton;
            btn_mid.BackgroundImageLayout = ImageLayout.Zoom;
            btn_mid.Location = new Point(199, 376);
            btn_mid.Name = "btn_mid";
            btn_mid.Size = new Size(35, 34);
            btn_mid.TabIndex = 25;
            btn_mid.UseVisualStyleBackColor = false;
            btn_mid.Click += btn_mid_Click;
            // 
            // timer_lift_mid
            // 
            timer_lift_mid.Interval = 8;
            timer_lift_mid.Tick += timer_lift_mid_Tick;
            // 
            // timer_door_open_mid
            // 
            timer_door_open_mid.Interval = 5;
            timer_door_open_mid.Tick += timer_door_openmid_Tick;
            // 
            // timer_door_close_mid
            // 
            timer_door_close_mid.Interval = 5;
            timer_door_close_mid.Tick += timer_door_closemid_Tick;
            // 
            // btn_middle
            // 
            btn_middle.BackgroundImage = Properties.Resources.firstfloorbutton;
            btn_middle.BackgroundImageLayout = ImageLayout.Zoom;
            btn_middle.Location = new Point(354, 410);
            btn_middle.Name = "btn_middle";
            btn_middle.Size = new Size(40, 40);
            btn_middle.TabIndex = 26;
            btn_middle.UseVisualStyleBackColor = true;
            btn_middle.Click += btn_1_Click;
            // 
            // timer_lift_mid2
            // 
            timer_lift_mid2.Interval = 8;
            timer_lift_mid2.Tick += timer_lift_mid2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(546, 811);
            Controls.Add(door_left_mid);
            Controls.Add(door_right_mid);
            Controls.Add(btn_middle);
            Controls.Add(btn_mid);
            Controls.Add(pictureBox1);
            Controls.Add(concrete);
            Controls.Add(btn_exit);
            Controls.Add(display_panel);
            Controls.Add(door_right_down);
            Controls.Add(door_left_down);
            Controls.Add(door_left_up);
            Controls.Add(door_right_up);
            Controls.Add(picture_lift);
            Controls.Add(btn_up);
            Controls.Add(btn_down);
            Controls.Add(btn_1);
            Controls.Add(btn_G);
            Controls.Add(btn_alarm);
            Controls.Add(btn_open);
            Controls.Add(btn_close);
            Controls.Add(bg_firstfloor);
            Controls.Add(bg_groundfloor);
            Controls.Add(bg_mid);
            Controls.Add(bg_panel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picture_lift).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_firstfloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_right_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_left_up).EndInit();
            ((System.ComponentModel.ISupportInitialize)concrete).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_groundfloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_left_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_right_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)display_panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_right_mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)door_left_mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_close;
        private Button btn_open;
        private Button btn_alarm;
        private Button btn_G;
        private Button btn_1;
        private Button btn_down;
        private Button btn_up;
        private System.Windows.Forms.Timer timer_lift_down;
        private System.Windows.Forms.Timer timer_lift_up;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_up;
        private PictureBox picture_lift;
        private PictureBox bg_firstfloor;
        private PictureBox door_right_up;
        private PictureBox door_left_up;
        private PictureBox concrete;
        private PictureBox bg_groundfloor;
        private PictureBox door_left_down;
        private PictureBox door_right_down;
        private PictureBox bg_panel;
        private PictureBox display_panel;
        private Button btn_exit;
        private PictureBox door_right_mid;
        private PictureBox door_left_mid;
        private PictureBox bg_mid;
        private PictureBox pictureBox1;
        private Button btn_mid;
        private System.Windows.Forms.Timer timer_lift_mid;
        private System.Windows.Forms.Timer timer_door_open_mid;
        private System.Windows.Forms.Timer timer_door_close_mid;
        private Button btn_middle;
        private System.Windows.Forms.Timer timer_lift_mid2;
    }
}
