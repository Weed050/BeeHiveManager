namespace BeeHiveManager
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
            label1 = new Label();
            label2 = new Label();
            workerBeeJob = new ComboBox();
            assignJob = new Button();
            nextShift = new Button();
            Shifts = new NumericUpDown();
            label3 = new Label();
            report = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Shifts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "Przydział prac robotnikom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Zadanie:";
            // 
            // workerBeeJob
            // 
            workerBeeJob.DisplayMember = "Uczenie pszczół";
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Items.AddRange(new object[] { "Pielęgnacja jaj", "Uczenie pszczół", "Utrzymywanie ula", "Patrol z żądłami", "Wytwarzanie miodu", "Zbieranie nektaru" });
            workerBeeJob.Location = new Point(24, 61);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(151, 28);
            workerBeeJob.TabIndex = 2;
            workerBeeJob.ValueMember = "Uczenie pszczół";
            // 
            // assignJob
            // 
            assignJob.Location = new Point(24, 95);
            assignJob.Name = "assignJob";
            assignJob.Size = new Size(286, 29);
            assignJob.TabIndex = 3;
            assignJob.Text = "Przypisz pracę";
            assignJob.UseVisualStyleBackColor = true;
            assignJob.Click += assignJob_Click;
            // 
            // nextShift
            // 
            nextShift.Location = new Point(335, 13);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(121, 111);
            nextShift.TabIndex = 4;
            nextShift.Text = "Przepracuj kolejną zmianę";
            nextShift.UseVisualStyleBackColor = true;
            nextShift.Click += nextShift_Click;
            // 
            // Shifts
            // 
            Shifts.Location = new Point(190, 61);
            Shifts.Name = "Shifts";
            Shifts.Size = new Size(120, 27);
            Shifts.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 38);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 7;
            label3.Text = "Liczba zmian:";
            // 
            // report
            // 
            report.BorderStyle = BorderStyle.FixedSingle;
            report.Location = new Point(24, 140);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(432, 298);
            report.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(report);
            Controls.Add(label3);
            Controls.Add(Shifts);
            Controls.Add(nextShift);
            Controls.Add(assignJob);
            Controls.Add(workerBeeJob);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox workerBeeJob;
        private Button assignJob;
        private Button nextShift;
        private NumericUpDown Shifts;
        private Label label3;
        private TextBox report;
    }
}