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
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(469, 263);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(469, 292);
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
            this.panelHunger.Location = new System.Drawing.Point(391, 12);
            this.panelHunger.Name = "panelHunger";
            this.panelHunger.Size = new System.Drawing.Size(39, 36);
            this.panelHunger.TabIndex = 2;
            // 
            // panelThink
            // 
            this.panelThink.BackColor = System.Drawing.Color.Yellow;
            this.panelThink.Location = new System.Drawing.Point(391, 54);
            this.panelThink.Name = "panelThink";
            this.panelThink.Size = new System.Drawing.Size(39, 36);
            this.panelThink.TabIndex = 3;
            // 
            // panelEat
            // 
            this.panelEat.BackColor = System.Drawing.Color.Red;
            this.panelEat.Location = new System.Drawing.Point(391, 96);
            this.panelEat.Name = "panelEat";
            this.panelEat.Size = new System.Drawing.Size(39, 36);
            this.panelEat.TabIndex = 3;
            // 
            // labelHunger
            // 
            this.labelHunger.AutoSize = true;
            this.labelHunger.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHunger.Location = new System.Drawing.Point(431, 17);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(155, 23);
            this.labelHunger.TabIndex = 4;
            this.labelHunger.Text = "- философ голоден";
            // 
            // labelThink
            // 
            this.labelThink.AutoSize = true;
            this.labelThink.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThink.Location = new System.Drawing.Point(431, 60);
            this.labelThink.Name = "labelThink";
            this.labelThink.Size = new System.Drawing.Size(147, 23);
            this.labelThink.TabIndex = 5;
            this.labelThink.Text = "- философ думает";
            // 
            // labelEat
            // 
            this.labelEat.AutoSize = true;
            this.labelEat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEat.Location = new System.Drawing.Point(432, 103);
            this.labelEat.Name = "labelEat";
            this.labelEat.Size = new System.Drawing.Size(118, 23);
            this.labelEat.TabIndex = 6;
            this.labelEat.Text = "- философ ест";
            // 
            // textBoxCntMeals
            // 
            this.textBoxCntMeals.Location = new System.Drawing.Point(548, 237);
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
            this.label1.Location = new System.Drawing.Point(276, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сколько раз должны поесть философы: ";
            // 
            // PhilosopherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 327);
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
    }
}

