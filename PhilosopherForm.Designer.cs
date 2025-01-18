namespace SP2._2
{
    partial class PhilosopherForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.panelHunger = new System.Windows.Forms.Panel();
            this.panelThink = new System.Windows.Forms.Panel();
            this.panelEat = new System.Windows.Forms.Panel();
            this.labelHunger = new System.Windows.Forms.Label();
            this.labelThink = new System.Windows.Forms.Label();
            this.labelEat = new System.Windows.Forms.Label();
            this.textBoxCntMeals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTh4Delay = new System.Windows.Forms.TrackBar();
            this.trackBarTh1Delay = new System.Windows.Forms.TrackBar();
            this.trackBarTh2Delay = new System.Windows.Forms.TrackBar();
            this.trackBarTh3Delay = new System.Windows.Forms.TrackBar();
            this.trackBarTh5Delay = new System.Windows.Forms.TrackBar();
            this.labelTh1Delay = new System.Windows.Forms.Label();
            this.labelTh1DelayName = new System.Windows.Forms.Label();
            this.labelTh2Delay = new System.Windows.Forms.Label();
            this.labelTh2DelayName = new System.Windows.Forms.Label();
            this.labelTh3Delay = new System.Windows.Forms.Label();
            this.labelTh3DelayName = new System.Windows.Forms.Label();
            this.labelTh4Delay = new System.Windows.Forms.Label();
            this.labelTh4DelayName = new System.Windows.Forms.Label();
            this.labelTh5Delay = new System.Windows.Forms.Label();
            this.labelTh5DelayName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh4Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh1Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh2Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh3Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh5Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(615, 401);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(615, 430);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(105, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerUp
            // 
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // panelHunger
            // 
            this.panelHunger.BackColor = System.Drawing.Color.Blue;
            this.panelHunger.Location = new System.Drawing.Point(501, 38);
            this.panelHunger.Name = "panelHunger";
            this.panelHunger.Size = new System.Drawing.Size(39, 36);
            this.panelHunger.TabIndex = 2;
            // 
            // panelThink
            // 
            this.panelThink.BackColor = System.Drawing.Color.Yellow;
            this.panelThink.Location = new System.Drawing.Point(501, 80);
            this.panelThink.Name = "panelThink";
            this.panelThink.Size = new System.Drawing.Size(39, 36);
            this.panelThink.TabIndex = 3;
            // 
            // panelEat
            // 
            this.panelEat.BackColor = System.Drawing.Color.Red;
            this.panelEat.Location = new System.Drawing.Point(501, 122);
            this.panelEat.Name = "panelEat";
            this.panelEat.Size = new System.Drawing.Size(39, 36);
            this.panelEat.TabIndex = 3;
            // 
            // labelHunger
            // 
            this.labelHunger.AutoSize = true;
            this.labelHunger.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHunger.Location = new System.Drawing.Point(541, 43);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(155, 23);
            this.labelHunger.TabIndex = 4;
            this.labelHunger.Text = "- философ голоден";
            // 
            // labelThink
            // 
            this.labelThink.AutoSize = true;
            this.labelThink.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThink.Location = new System.Drawing.Point(541, 86);
            this.labelThink.Name = "labelThink";
            this.labelThink.Size = new System.Drawing.Size(147, 23);
            this.labelThink.TabIndex = 5;
            this.labelThink.Text = "- философ думает";
            // 
            // labelEat
            // 
            this.labelEat.AutoSize = true;
            this.labelEat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEat.Location = new System.Drawing.Point(542, 129);
            this.labelEat.Name = "labelEat";
            this.labelEat.Size = new System.Drawing.Size(118, 23);
            this.labelEat.TabIndex = 6;
            this.labelEat.Text = "- философ ест";
            // 
            // textBoxCntMeals
            // 
            this.textBoxCntMeals.Location = new System.Drawing.Point(581, 403);
            this.textBoxCntMeals.Name = "textBoxCntMeals";
            this.textBoxCntMeals.Size = new System.Drawing.Size(26, 20);
            this.textBoxCntMeals.TabIndex = 7;
            this.textBoxCntMeals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCntMeals_KeyDown);
            this.textBoxCntMeals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCntMeals_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сколько раз должны поесть философы: ";
            // 
            // trackBarTh4Delay
            // 
            this.trackBarTh4Delay.Location = new System.Drawing.Point(432, 301);
            this.trackBarTh4Delay.Maximum = 15;
            this.trackBarTh4Delay.Name = "trackBarTh4Delay";
            this.trackBarTh4Delay.Size = new System.Drawing.Size(134, 45);
            this.trackBarTh4Delay.TabIndex = 9;
            this.trackBarTh4Delay.Scroll += new System.EventHandler(this.trackBarTh4Delay_Scroll);
            // 
            // trackBarTh1Delay
            // 
            this.trackBarTh1Delay.Location = new System.Drawing.Point(12, 301);
            this.trackBarTh1Delay.Maximum = 15;
            this.trackBarTh1Delay.Name = "trackBarTh1Delay";
            this.trackBarTh1Delay.Size = new System.Drawing.Size(134, 45);
            this.trackBarTh1Delay.TabIndex = 10;
            this.trackBarTh1Delay.Scroll += new System.EventHandler(this.trackBarTh1Delay_Scroll);
            // 
            // trackBarTh2Delay
            // 
            this.trackBarTh2Delay.Location = new System.Drawing.Point(152, 301);
            this.trackBarTh2Delay.Maximum = 15;
            this.trackBarTh2Delay.Name = "trackBarTh2Delay";
            this.trackBarTh2Delay.Size = new System.Drawing.Size(134, 45);
            this.trackBarTh2Delay.TabIndex = 11;
            this.trackBarTh2Delay.Scroll += new System.EventHandler(this.trackBarTh2Delay_Scroll);
            // 
            // trackBarTh3Delay
            // 
            this.trackBarTh3Delay.Location = new System.Drawing.Point(292, 301);
            this.trackBarTh3Delay.Maximum = 15;
            this.trackBarTh3Delay.Name = "trackBarTh3Delay";
            this.trackBarTh3Delay.Size = new System.Drawing.Size(134, 45);
            this.trackBarTh3Delay.TabIndex = 12;
            this.trackBarTh3Delay.Scroll += new System.EventHandler(this.trackBarTh3Delay_Scroll);
            // 
            // trackBarTh5Delay
            // 
            this.trackBarTh5Delay.Location = new System.Drawing.Point(572, 301);
            this.trackBarTh5Delay.Maximum = 15;
            this.trackBarTh5Delay.Name = "trackBarTh5Delay";
            this.trackBarTh5Delay.Size = new System.Drawing.Size(134, 45);
            this.trackBarTh5Delay.TabIndex = 13;
            this.trackBarTh5Delay.Scroll += new System.EventHandler(this.trackBarTh5Delay_Scroll);
            // 
            // labelTh1Delay
            // 
            this.labelTh1Delay.AutoSize = true;
            this.labelTh1Delay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh1Delay.Location = new System.Drawing.Point(105, 338);
            this.labelTh1Delay.Name = "labelTh1Delay";
            this.labelTh1Delay.Size = new System.Drawing.Size(26, 18);
            this.labelTh1Delay.TabIndex = 15;
            this.labelTh1Delay.Text = "---";
            // 
            // labelTh1DelayName
            // 
            this.labelTh1DelayName.AutoSize = true;
            this.labelTh1DelayName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh1DelayName.Location = new System.Drawing.Point(28, 338);
            this.labelTh1DelayName.Name = "labelTh1DelayName";
            this.labelTh1DelayName.Size = new System.Drawing.Size(71, 18);
            this.labelTh1DelayName.TabIndex = 14;
            this.labelTh1DelayName.Text = "Задержка:";
            // 
            // labelTh2Delay
            // 
            this.labelTh2Delay.AutoSize = true;
            this.labelTh2Delay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh2Delay.Location = new System.Drawing.Point(247, 338);
            this.labelTh2Delay.Name = "labelTh2Delay";
            this.labelTh2Delay.Size = new System.Drawing.Size(26, 18);
            this.labelTh2Delay.TabIndex = 17;
            this.labelTh2Delay.Text = "---";
            // 
            // labelTh2DelayName
            // 
            this.labelTh2DelayName.AutoSize = true;
            this.labelTh2DelayName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh2DelayName.Location = new System.Drawing.Point(170, 338);
            this.labelTh2DelayName.Name = "labelTh2DelayName";
            this.labelTh2DelayName.Size = new System.Drawing.Size(71, 18);
            this.labelTh2DelayName.TabIndex = 16;
            this.labelTh2DelayName.Text = "Задержка:";
            // 
            // labelTh3Delay
            // 
            this.labelTh3Delay.AutoSize = true;
            this.labelTh3Delay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh3Delay.Location = new System.Drawing.Point(386, 338);
            this.labelTh3Delay.Name = "labelTh3Delay";
            this.labelTh3Delay.Size = new System.Drawing.Size(26, 18);
            this.labelTh3Delay.TabIndex = 19;
            this.labelTh3Delay.Text = "---";
            // 
            // labelTh3DelayName
            // 
            this.labelTh3DelayName.AutoSize = true;
            this.labelTh3DelayName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh3DelayName.Location = new System.Drawing.Point(309, 338);
            this.labelTh3DelayName.Name = "labelTh3DelayName";
            this.labelTh3DelayName.Size = new System.Drawing.Size(71, 18);
            this.labelTh3DelayName.TabIndex = 18;
            this.labelTh3DelayName.Text = "Задержка:";
            // 
            // labelTh4Delay
            // 
            this.labelTh4Delay.AutoSize = true;
            this.labelTh4Delay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh4Delay.Location = new System.Drawing.Point(528, 338);
            this.labelTh4Delay.Name = "labelTh4Delay";
            this.labelTh4Delay.Size = new System.Drawing.Size(26, 18);
            this.labelTh4Delay.TabIndex = 21;
            this.labelTh4Delay.Text = "---";
            // 
            // labelTh4DelayName
            // 
            this.labelTh4DelayName.AutoSize = true;
            this.labelTh4DelayName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh4DelayName.Location = new System.Drawing.Point(451, 338);
            this.labelTh4DelayName.Name = "labelTh4DelayName";
            this.labelTh4DelayName.Size = new System.Drawing.Size(71, 18);
            this.labelTh4DelayName.TabIndex = 20;
            this.labelTh4DelayName.Text = "Задержка:";
            // 
            // labelTh5Delay
            // 
            this.labelTh5Delay.AutoSize = true;
            this.labelTh5Delay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh5Delay.Location = new System.Drawing.Point(666, 338);
            this.labelTh5Delay.Name = "labelTh5Delay";
            this.labelTh5Delay.Size = new System.Drawing.Size(26, 18);
            this.labelTh5Delay.TabIndex = 23;
            this.labelTh5Delay.Text = "---";
            // 
            // labelTh5DelayName
            // 
            this.labelTh5DelayName.AutoSize = true;
            this.labelTh5DelayName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTh5DelayName.Location = new System.Drawing.Point(589, 338);
            this.labelTh5DelayName.Name = "labelTh5DelayName";
            this.labelTh5DelayName.Size = new System.Drawing.Size(71, 18);
            this.labelTh5DelayName.TabIndex = 22;
            this.labelTh5DelayName.Text = "Задержка:";
            // 
            // PhilosopherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 465);
            this.Controls.Add(this.labelTh5Delay);
            this.Controls.Add(this.labelTh5DelayName);
            this.Controls.Add(this.labelTh4Delay);
            this.Controls.Add(this.labelTh4DelayName);
            this.Controls.Add(this.labelTh3Delay);
            this.Controls.Add(this.labelTh3DelayName);
            this.Controls.Add(this.labelTh2Delay);
            this.Controls.Add(this.labelTh2DelayName);
            this.Controls.Add(this.labelTh1Delay);
            this.Controls.Add(this.labelTh1DelayName);
            this.Controls.Add(this.trackBarTh5Delay);
            this.Controls.Add(this.trackBarTh3Delay);
            this.Controls.Add(this.trackBarTh2Delay);
            this.Controls.Add(this.trackBarTh1Delay);
            this.Controls.Add(this.trackBarTh4Delay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCntMeals);
            this.Controls.Add(this.labelEat);
            this.Controls.Add(this.labelThink);
            this.Controls.Add(this.labelHunger);
            this.Controls.Add(this.panelEat);
            this.Controls.Add(this.panelThink);
            this.Controls.Add(this.panelHunger);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "PhilosopherForm";
            this.Text = "Philosophers";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh4Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh1Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh2Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh3Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTh5Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Panel panelHunger;
        private System.Windows.Forms.Panel panelThink;
        private System.Windows.Forms.Panel panelEat;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelThink;
        private System.Windows.Forms.Label labelEat;
        private System.Windows.Forms.TextBox textBoxCntMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTh4Delay;
        private System.Windows.Forms.TrackBar trackBarTh1Delay;
        private System.Windows.Forms.TrackBar trackBarTh2Delay;
        private System.Windows.Forms.TrackBar trackBarTh3Delay;
        private System.Windows.Forms.TrackBar trackBarTh5Delay;
        private System.Windows.Forms.Label labelTh1Delay;
        private System.Windows.Forms.Label labelTh1DelayName;
        private System.Windows.Forms.Label labelTh2Delay;
        private System.Windows.Forms.Label labelTh2DelayName;
        private System.Windows.Forms.Label labelTh3Delay;
        private System.Windows.Forms.Label labelTh3DelayName;
        private System.Windows.Forms.Label labelTh4Delay;
        private System.Windows.Forms.Label labelTh4DelayName;
        private System.Windows.Forms.Label labelTh5Delay;
        private System.Windows.Forms.Label labelTh5DelayName;
    }
}

