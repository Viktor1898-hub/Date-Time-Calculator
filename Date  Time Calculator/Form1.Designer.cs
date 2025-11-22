namespace Date__Time_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MenuPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.BirthdayInformer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TimeConverter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DateWorkCount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LeapCounter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DateComparer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.UnixPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DateComparPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UnixLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TimerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MenuPanel.SuspendLayout();
            this.UnixPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(896, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 26);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(863, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(36, 26);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MenuPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BorderRadius = 17;
            this.MenuPanel.Controls.Add(this.guna2ImageButton1);
            this.MenuPanel.Controls.Add(this.BirthdayInformer);
            this.MenuPanel.Controls.Add(this.TimeConverter);
            this.MenuPanel.Controls.Add(this.DateWorkCount);
            this.MenuPanel.Controls.Add(this.LeapCounter);
            this.MenuPanel.Controls.Add(this.DateComparer);
            this.MenuPanel.FillColor = System.Drawing.Color.Transparent;
            this.MenuPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.MenuPanel.Location = new System.Drawing.Point(0, -1);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(119, 674);
            this.MenuPanel.TabIndex = 4;
            // 
            // BirthdayInformer
            // 
            this.BirthdayInformer.Animated = true;
            this.BirthdayInformer.BackColor = System.Drawing.Color.Transparent;
            this.BirthdayInformer.BorderColor = System.Drawing.Color.Transparent;
            this.BirthdayInformer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BirthdayInformer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BirthdayInformer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BirthdayInformer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BirthdayInformer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BirthdayInformer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BirthdayInformer.FillColor = System.Drawing.Color.Transparent;
            this.BirthdayInformer.FillColor2 = System.Drawing.Color.White;
            this.BirthdayInformer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BirthdayInformer.ForeColor = System.Drawing.Color.Black;
            this.BirthdayInformer.Location = new System.Drawing.Point(0, 470);
            this.BirthdayInformer.Name = "BirthdayInformer";
            this.BirthdayInformer.Size = new System.Drawing.Size(120, 73);
            this.BirthdayInformer.TabIndex = 4;
            this.BirthdayInformer.Text = "Birthday Informer";
            this.BirthdayInformer.UseTransparentBackground = true;
            // 
            // TimeConverter
            // 
            this.TimeConverter.Animated = true;
            this.TimeConverter.BackColor = System.Drawing.Color.Transparent;
            this.TimeConverter.BorderColor = System.Drawing.Color.Transparent;
            this.TimeConverter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TimeConverter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TimeConverter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TimeConverter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TimeConverter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TimeConverter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TimeConverter.FillColor = System.Drawing.Color.Transparent;
            this.TimeConverter.FillColor2 = System.Drawing.Color.White;
            this.TimeConverter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeConverter.ForeColor = System.Drawing.Color.Black;
            this.TimeConverter.Location = new System.Drawing.Point(0, 391);
            this.TimeConverter.Name = "TimeConverter";
            this.TimeConverter.Size = new System.Drawing.Size(120, 73);
            this.TimeConverter.TabIndex = 3;
            this.TimeConverter.Text = "Time Converter";
            this.TimeConverter.UseTransparentBackground = true;
            // 
            // DateWorkCount
            // 
            this.DateWorkCount.Animated = true;
            this.DateWorkCount.BackColor = System.Drawing.Color.Transparent;
            this.DateWorkCount.BorderColor = System.Drawing.Color.Transparent;
            this.DateWorkCount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DateWorkCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DateWorkCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DateWorkCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DateWorkCount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DateWorkCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DateWorkCount.FillColor = System.Drawing.Color.Transparent;
            this.DateWorkCount.FillColor2 = System.Drawing.Color.White;
            this.DateWorkCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateWorkCount.ForeColor = System.Drawing.Color.Black;
            this.DateWorkCount.Location = new System.Drawing.Point(0, 233);
            this.DateWorkCount.Name = "DateWorkCount";
            this.DateWorkCount.Size = new System.Drawing.Size(120, 73);
            this.DateWorkCount.TabIndex = 2;
            this.DateWorkCount.Text = "2 Date Working Counter";
            this.DateWorkCount.UseTransparentBackground = true;
            // 
            // LeapCounter
            // 
            this.LeapCounter.Animated = true;
            this.LeapCounter.BackColor = System.Drawing.Color.Transparent;
            this.LeapCounter.BorderColor = System.Drawing.Color.Transparent;
            this.LeapCounter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LeapCounter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeapCounter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeapCounter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeapCounter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeapCounter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeapCounter.FillColor = System.Drawing.Color.Transparent;
            this.LeapCounter.FillColor2 = System.Drawing.Color.White;
            this.LeapCounter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeapCounter.ForeColor = System.Drawing.Color.Black;
            this.LeapCounter.Location = new System.Drawing.Point(0, 312);
            this.LeapCounter.Name = "LeapCounter";
            this.LeapCounter.Size = new System.Drawing.Size(120, 73);
            this.LeapCounter.TabIndex = 1;
            this.LeapCounter.Text = "Leap Conter";
            this.LeapCounter.UseTransparentBackground = true;
            // 
            // DateComparer
            // 
            this.DateComparer.Animated = true;
            this.DateComparer.BackColor = System.Drawing.Color.Transparent;
            this.DateComparer.BorderColor = System.Drawing.Color.Transparent;
            this.DateComparer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DateComparer.Checked = true;
            this.DateComparer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DateComparer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DateComparer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DateComparer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DateComparer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DateComparer.FillColor = System.Drawing.Color.Transparent;
            this.DateComparer.FillColor2 = System.Drawing.Color.White;
            this.DateComparer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateComparer.ForeColor = System.Drawing.Color.Black;
            this.DateComparer.Location = new System.Drawing.Point(0, 154);
            this.DateComparer.Name = "DateComparer";
            this.DateComparer.Size = new System.Drawing.Size(120, 73);
            this.DateComparer.TabIndex = 0;
            this.DateComparer.Text = "2 Date Comparer";
            this.DateComparer.UseTransparentBackground = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.UnixPanel;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // UnixPanel
            // 
            this.UnixPanel.BorderRadius = 17;
            this.UnixPanel.Controls.Add(this.TimerLabel);
            this.UnixPanel.Controls.Add(this.UnixLabel);
            this.UnixPanel.Controls.Add(this.guna2ControlBox1);
            this.UnixPanel.Controls.Add(this.guna2ControlBox2);
            this.UnixPanel.FillColor = System.Drawing.Color.Transparent;
            this.UnixPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.UnixPanel.Location = new System.Drawing.Point(118, -1);
            this.UnixPanel.Name = "UnixPanel";
            this.UnixPanel.Size = new System.Drawing.Size(934, 100);
            this.UnixPanel.TabIndex = 5;
            // 
            // DateComparPanel
            // 
            this.DateComparPanel.BorderRadius = 17;
            this.DateComparPanel.FillColor = System.Drawing.Color.Transparent;
            this.DateComparPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.DateComparPanel.Location = new System.Drawing.Point(120, 100);
            this.DateComparPanel.Name = "DateComparPanel";
            this.DateComparPanel.Size = new System.Drawing.Size(930, 573);
            this.DateComparPanel.TabIndex = 6;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Enabled = false;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 19);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(118, 118);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.guna2ImageButton1;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.DateComparPanel;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UnixLabel
            // 
            this.UnixLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnixLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnixLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.UnixLabel.Location = new System.Drawing.Point(105, 36);
            this.UnixLabel.Name = "UnixLabel";
            this.UnixLabel.Size = new System.Drawing.Size(214, 31);
            this.UnixLabel.TabIndex = 4;
            this.UnixLabel.Text = "Unix Time Stamp";
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TimerLabel.Location = new System.Drawing.Point(353, 36);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(3, 2);
            this.TimerLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1050, 673);
            this.Controls.Add(this.DateComparPanel);
            this.Controls.Add(this.UnixPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.UnixPanel.ResumeLayout(false);
            this.UnixPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MenuPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel UnixPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel DateComparPanel;
        private Guna.UI2.WinForms.Guna2GradientButton DateComparer;
        private Guna.UI2.WinForms.Guna2GradientButton TimeConverter;
        private Guna.UI2.WinForms.Guna2GradientButton DateWorkCount;
        private Guna.UI2.WinForms.Guna2GradientButton LeapCounter;
        private Guna.UI2.WinForms.Guna2GradientButton BirthdayInformer;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2HtmlLabel TimerLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel UnixLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

