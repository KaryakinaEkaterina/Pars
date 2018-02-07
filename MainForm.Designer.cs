namespace MKB2._1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.summaryView = new System.Windows.Forms.Label();
            this.listObjectsView = new System.Windows.Forms.ListBox();
            this.openFileBut = new System.Windows.Forms.Button();
            this.startSimulationBut = new System.Windows.Forms.Button();
            this.yesBut = new System.Windows.Forms.Button();
            this.noBut = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.kurBut = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.kuBox = new System.Windows.Forms.GroupBox();
            this.rBox = new System.Windows.Forms.GroupBox();
            this.listActiveQuestions = new System.Windows.Forms.ListBox();
            this.listPassiveQuestions = new System.Windows.Forms.ListBox();
            this.doPassive = new System.Windows.Forms.Button();
            this.doActive = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.Info = new System.Windows.Forms.Label();
            this.orderByBox = new System.Windows.Forms.GroupBox();
            this.byPrb = new System.Windows.Forms.RadioButton();
            this.byABCrb = new System.Windows.Forms.RadioButton();
            this.activeQuestion = new System.Windows.Forms.TextBox();
            this.kuBox.SuspendLayout();
            this.rBox.SuspendLayout();
            this.orderByBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryView
            // 
            this.summaryView.AutoSize = true;
            this.summaryView.Location = new System.Drawing.Point(96, 12);
            this.summaryView.MaximumSize = new System.Drawing.Size(550, 0);
            this.summaryView.Name = "summaryView";
            this.summaryView.Size = new System.Drawing.Size(50, 52);
            this.summaryView.TabIndex = 0;
            this.summaryView.Text = "Summary\r\nSummary\r\nSummary\r\nSummary";
            // 
            // listObjectsView
            // 
            this.listObjectsView.FormattingEnabled = true;
            this.listObjectsView.Location = new System.Drawing.Point(12, 67);
            this.listObjectsView.Name = "listObjectsView";
            this.listObjectsView.Size = new System.Drawing.Size(201, 147);
            this.listObjectsView.TabIndex = 1;
            // 
            // openFileBut
            // 
            this.openFileBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFileBut.BackgroundImage")));
            this.openFileBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openFileBut.Location = new System.Drawing.Point(12, 12);
            this.openFileBut.Name = "openFileBut";
            this.openFileBut.Size = new System.Drawing.Size(36, 36);
            this.openFileBut.TabIndex = 3;
            this.openFileBut.UseVisualStyleBackColor = true;
            this.openFileBut.Click += new System.EventHandler(this.openFileBut_Click);
            // 
            // startSimulationBut
            // 
            this.startSimulationBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startSimulationBut.BackgroundImage")));
            this.startSimulationBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startSimulationBut.Location = new System.Drawing.Point(54, 12);
            this.startSimulationBut.Name = "startSimulationBut";
            this.startSimulationBut.Size = new System.Drawing.Size(36, 36);
            this.startSimulationBut.TabIndex = 4;
            this.startSimulationBut.UseVisualStyleBackColor = true;
            this.startSimulationBut.Click += new System.EventHandler(this.startSimulationBut_Click);
            // 
            // yesBut
            // 
            this.yesBut.Location = new System.Drawing.Point(213, 19);
            this.yesBut.Name = "yesBut";
            this.yesBut.Size = new System.Drawing.Size(205, 32);
            this.yesBut.TabIndex = 6;
            this.yesBut.Text = "Да (1)";
            this.yesBut.UseVisualStyleBackColor = true;
            this.yesBut.Click += new System.EventHandler(this.yesBut_Click);
            // 
            // noBut
            // 
            this.noBut.Location = new System.Drawing.Point(6, 19);
            this.noBut.Name = "noBut";
            this.noBut.Size = new System.Drawing.Size(201, 32);
            this.noBut.TabIndex = 7;
            this.noBut.Text = "Нет (0)";
            this.noBut.UseVisualStyleBackColor = true;
            this.noBut.Click += new System.EventHandler(this.noBut_Click);
            // 
            // but_3
            // 
            this.but_3.Location = new System.Drawing.Point(82, 19);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(32, 32);
            this.but_3.TabIndex = 8;
            this.but_3.Text = "-3";
            this.but_3.UseVisualStyleBackColor = true;
            this.but_3.Click += new System.EventHandler(this._kuButs_Click);
            // 
            // but_4
            // 
            this.but_4.Location = new System.Drawing.Point(44, 19);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(32, 32);
            this.but_4.TabIndex = 9;
            this.but_4.Text = "-4";
            this.but_4.UseVisualStyleBackColor = true;
            this.but_4.Click += new System.EventHandler(this._kuButs_Click);
            // 
            // but_5
            // 
            this.but_5.Location = new System.Drawing.Point(6, 19);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(32, 32);
            this.but_5.TabIndex = 10;
            this.but_5.Text = "-5";
            this.but_5.UseVisualStyleBackColor = true;
            this.but_5.Click += new System.EventHandler(this._kuButs_Click);
            // 
            // but_2
            // 
            this.but_2.Location = new System.Drawing.Point(120, 19);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(32, 32);
            this.but_2.TabIndex = 11;
            this.but_2.Text = "-2";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this._kuButs_Click);
            // 
            // but_1
            // 
            this.but_1.Location = new System.Drawing.Point(158, 19);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(32, 32);
            this.but_1.TabIndex = 12;
            this.but_1.Text = "-1";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this._kuButs_Click);
            // 
            // kurBut
            // 
            this.kurBut.Location = new System.Drawing.Point(139, 220);
            this.kurBut.Name = "kurBut";
            this.kurBut.Size = new System.Drawing.Size(74, 67);
            this.kurBut.TabIndex = 13;
            this.kurBut.Text = "КУ/Р";
            this.kurBut.UseVisualStyleBackColor = true;
            this.kurBut.Click += new System.EventHandler(this.kurBut_Click);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(234, 19);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(32, 32);
            this.but1.TabIndex = 18;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.kuButs_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(272, 20);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(32, 32);
            this.but2.TabIndex = 17;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.kuButs_Click);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(386, 20);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(32, 32);
            this.but5.TabIndex = 16;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.kuButs_Click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(348, 20);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(32, 32);
            this.but4.TabIndex = 15;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.kuButs_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(310, 20);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(32, 32);
            this.but3.TabIndex = 14;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.kuButs_Click);
            // 
            // but0
            // 
            this.but0.Location = new System.Drawing.Point(196, 19);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(32, 32);
            this.but0.TabIndex = 19;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.ku0Buts_Click);
            // 
            // kuBox
            // 
            this.kuBox.Controls.Add(this.but_5);
            this.kuBox.Controls.Add(this.but0);
            this.kuBox.Controls.Add(this.but_3);
            this.kuBox.Controls.Add(this.but1);
            this.kuBox.Controls.Add(this.but_4);
            this.kuBox.Controls.Add(this.but2);
            this.kuBox.Controls.Add(this.but_2);
            this.kuBox.Controls.Add(this.but5);
            this.kuBox.Controls.Add(this.but_1);
            this.kuBox.Controls.Add(this.but4);
            this.kuBox.Controls.Add(this.but3);
            this.kuBox.Location = new System.Drawing.Point(219, -3);
            this.kuBox.Name = "kuBox";
            this.kuBox.Size = new System.Drawing.Size(433, 67);
            this.kuBox.TabIndex = 20;
            this.kuBox.TabStop = false;
            this.kuBox.Text = "Коэффициент уверенности";
            this.kuBox.Visible = false;
            // 
            // rBox
            // 
            this.rBox.Controls.Add(this.yesBut);
            this.rBox.Controls.Add(this.noBut);
            this.rBox.Location = new System.Drawing.Point(219, 220);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(434, 67);
            this.rBox.TabIndex = 21;
            this.rBox.TabStop = false;
            this.rBox.Text = "Вероятность истинности свидетельства";
            // 
            // listActiveQuestions
            // 
            this.listActiveQuestions.FormattingEnabled = true;
            this.listActiveQuestions.Location = new System.Drawing.Point(12, 293);
            this.listActiveQuestions.Name = "listActiveQuestions";
            this.listActiveQuestions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listActiveQuestions.Size = new System.Drawing.Size(211, 186);
            this.listActiveQuestions.TabIndex = 22;
            // 
            // listPassiveQuestions
            // 
            this.listPassiveQuestions.FormattingEnabled = true;
            this.listPassiveQuestions.Location = new System.Drawing.Point(442, 293);
            this.listPassiveQuestions.Name = "listPassiveQuestions";
            this.listPassiveQuestions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listPassiveQuestions.Size = new System.Drawing.Size(211, 186);
            this.listPassiveQuestions.TabIndex = 23;
            // 
            // doPassive
            // 
            this.doPassive.Location = new System.Drawing.Point(228, 293);
            this.doPassive.Name = "doPassive";
            this.doPassive.Size = new System.Drawing.Size(88, 49);
            this.doPassive.TabIndex = 1;
            this.doPassive.Text = "Отключить =>";
            this.doPassive.UseVisualStyleBackColor = true;
            this.doPassive.Click += new System.EventHandler(this.doPassive_Click);
            // 
            // doActive
            // 
            this.doActive.Location = new System.Drawing.Point(348, 293);
            this.doActive.Name = "doActive";
            this.doActive.Size = new System.Drawing.Size(88, 49);
            this.doActive.TabIndex = 1;
            this.doActive.Text = "Включить <=";
            this.doActive.UseVisualStyleBackColor = true;
            this.doActive.Click += new System.EventHandler(this.doActive_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(219, 67);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(434, 108);
            this.listResult.TabIndex = 26;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(229, 453);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(96, 26);
            this.Info.TabIndex = 28;
            this.Info.Text = "Свидетельств: 18\r\nИсходов: 20";
            // 
            // orderByBox
            // 
            this.orderByBox.Controls.Add(this.byPrb);
            this.orderByBox.Controls.Add(this.byABCrb);
            this.orderByBox.Location = new System.Drawing.Point(12, 220);
            this.orderByBox.Name = "orderByBox";
            this.orderByBox.Size = new System.Drawing.Size(121, 67);
            this.orderByBox.TabIndex = 29;
            this.orderByBox.TabStop = false;
            this.orderByBox.Text = "Сортировка";
            // 
            // byPrb
            // 
            this.byPrb.AutoSize = true;
            this.byPrb.Checked = true;
            this.byPrb.Location = new System.Drawing.Point(6, 42);
            this.byPrb.Name = "byPrb";
            this.byPrb.Size = new System.Drawing.Size(112, 17);
            this.byPrb.TabIndex = 1;
            this.byPrb.TabStop = true;
            this.byPrb.Text = "по вероятностям";
            this.byPrb.UseVisualStyleBackColor = true;
            this.byPrb.CheckedChanged += new System.EventHandler(this.sort_CheckedChanged);
            // 
            // byABCrb
            // 
            this.byABCrb.AutoSize = true;
            this.byABCrb.Location = new System.Drawing.Point(6, 19);
            this.byABCrb.Name = "byABCrb";
            this.byABCrb.Size = new System.Drawing.Size(88, 17);
            this.byABCrb.TabIndex = 0;
            this.byABCrb.TabStop = true;
            this.byABCrb.Text = "по алфавиту";
            this.byABCrb.UseVisualStyleBackColor = true;
            this.byABCrb.CheckedChanged += new System.EventHandler(this.sort_CheckedChanged);
            // 
            // activeQuestion
            // 
            this.activeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeQuestion.Location = new System.Drawing.Point(219, 192);
            this.activeQuestion.Name = "activeQuestion";
            this.activeQuestion.ReadOnly = true;
            this.activeQuestion.Size = new System.Drawing.Size(434, 22);
            this.activeQuestion.TabIndex = 30;
            this.activeQuestion.Text = "Консультация завершена";
            this.activeQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 489);
            this.Controls.Add(this.activeQuestion);
            this.Controls.Add(this.orderByBox);
            this.Controls.Add(this.doActive);
            this.Controls.Add(this.doPassive);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.listPassiveQuestions);
            this.Controls.Add(this.listActiveQuestions);
            this.Controls.Add(this.kuBox);
            this.Controls.Add(this.kurBut);
            this.Controls.Add(this.startSimulationBut);
            this.Controls.Add(this.openFileBut);
            this.Controls.Add(this.listObjectsView);
            this.Controls.Add(this.summaryView);
            this.Controls.Add(this.rBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Малая экспертная система 2.1 by Deamond";
            this.kuBox.ResumeLayout(false);
            this.rBox.ResumeLayout(false);
            this.orderByBox.ResumeLayout(false);
            this.orderByBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label summaryView;
        private System.Windows.Forms.ListBox listObjectsView;
        private System.Windows.Forms.Button openFileBut;
        private System.Windows.Forms.Button startSimulationBut;
        private System.Windows.Forms.Button yesBut;
        private System.Windows.Forms.Button noBut;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button kurBut;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.GroupBox kuBox;
        private System.Windows.Forms.GroupBox rBox;
        private System.Windows.Forms.ListBox listActiveQuestions;
        private System.Windows.Forms.ListBox listPassiveQuestions;
        private System.Windows.Forms.Button doPassive;
        private System.Windows.Forms.Button doActive;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.GroupBox orderByBox;
        private System.Windows.Forms.RadioButton byPrb;
        private System.Windows.Forms.RadioButton byABCrb;
        private System.Windows.Forms.TextBox activeQuestion;

    }
}