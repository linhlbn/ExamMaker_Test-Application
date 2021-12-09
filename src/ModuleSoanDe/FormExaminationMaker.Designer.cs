namespace ModuleSoanDe
{
    partial class FormExaminationMaker
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
            this.lbShowInfo = new System.Windows.Forms.Label();
            this.btCreateQuestions = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pnCreateQuestion = new System.Windows.Forms.Panel();
            this.lboxQuestionList = new System.Windows.Forms.ListBox();
            this.pnCQ_btDeleteQuestion = new System.Windows.Forms.Button();
            this.pnCQ_btUpdateQuestion = new System.Windows.Forms.Button();
            this.pnCQ_btNextQuestion = new System.Windows.Forms.Button();
            this.pnCQ_btSaveToEB = new System.Windows.Forms.Button();
            this.pnCQ_txtA4 = new System.Windows.Forms.TextBox();
            this.pnCQ_txtA3 = new System.Windows.Forms.TextBox();
            this.pnCQ_txtA2 = new System.Windows.Forms.TextBox();
            this.pnCQ_txtA1 = new System.Windows.Forms.TextBox();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.pnCQ_txtQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLoadFromAFile = new System.Windows.Forms.Button();
            this.btMakeAnExamFile = new System.Windows.Forms.Button();
            this.btScoreEmpExam = new System.Windows.Forms.Button();
            this.btMakeResultFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnCreateQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbShowInfo
            // 
            this.lbShowInfo.AutoSize = true;
            this.lbShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbShowInfo.Location = new System.Drawing.Point(8, 9);
            this.lbShowInfo.Name = "lbShowInfo";
            this.lbShowInfo.Size = new System.Drawing.Size(50, 16);
            this.lbShowInfo.TabIndex = 0;
            this.lbShowInfo.Text = "label1";
            // 
            // btCreateQuestions
            // 
            this.btCreateQuestions.Location = new System.Drawing.Point(9, 13);
            this.btCreateQuestions.Name = "btCreateQuestions";
            this.btCreateQuestions.Size = new System.Drawing.Size(112, 27);
            this.btCreateQuestions.TabIndex = 1;
            this.btCreateQuestions.Text = "Create questions";
            this.btCreateQuestions.UseVisualStyleBackColor = true;
            this.btCreateQuestions.Click += new System.EventHandler(this.btCreateQuestion);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(770, 13);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(43, 27);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pnCreateQuestion
            // 
            this.pnCreateQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCreateQuestion.Controls.Add(this.lboxQuestionList);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_btDeleteQuestion);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_btUpdateQuestion);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_btNextQuestion);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_btSaveToEB);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_txtA4);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_txtA3);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_txtA2);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_txtA1);
            this.pnCreateQuestion.Controls.Add(this.rd4);
            this.pnCreateQuestion.Controls.Add(this.rd3);
            this.pnCreateQuestion.Controls.Add(this.rd2);
            this.pnCreateQuestion.Controls.Add(this.rd1);
            this.pnCreateQuestion.Controls.Add(this.pnCQ_txtQ);
            this.pnCreateQuestion.Controls.Add(this.label2);
            this.pnCreateQuestion.Controls.Add(this.label1);
            this.pnCreateQuestion.Location = new System.Drawing.Point(12, 113);
            this.pnCreateQuestion.Name = "pnCreateQuestion";
            this.pnCreateQuestion.Size = new System.Drawing.Size(831, 541);
            this.pnCreateQuestion.TabIndex = 0;
            // 
            // lboxQuestionList
            // 
            this.lboxQuestionList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lboxQuestionList.FormattingEnabled = true;
            this.lboxQuestionList.Location = new System.Drawing.Point(9, 270);
            this.lboxQuestionList.Name = "lboxQuestionList";
            this.lboxQuestionList.Size = new System.Drawing.Size(803, 225);
            this.lboxQuestionList.TabIndex = 8;
            this.lboxQuestionList.SelectedIndexChanged += new System.EventHandler(this.lboxQuestionList_SelectedIndexChanged);
            // 
            // pnCQ_btDeleteQuestion
            // 
            this.pnCQ_btDeleteQuestion.Location = new System.Drawing.Point(715, 238);
            this.pnCQ_btDeleteQuestion.Name = "pnCQ_btDeleteQuestion";
            this.pnCQ_btDeleteQuestion.Size = new System.Drawing.Size(98, 23);
            this.pnCQ_btDeleteQuestion.TabIndex = 6;
            this.pnCQ_btDeleteQuestion.Text = "Delete Question";
            this.pnCQ_btDeleteQuestion.UseVisualStyleBackColor = true;
            this.pnCQ_btDeleteQuestion.Click += new System.EventHandler(this.pnCQ_btDeleteQuestion_Click);
            // 
            // pnCQ_btUpdateQuestion
            // 
            this.pnCQ_btUpdateQuestion.Location = new System.Drawing.Point(611, 238);
            this.pnCQ_btUpdateQuestion.Name = "pnCQ_btUpdateQuestion";
            this.pnCQ_btUpdateQuestion.Size = new System.Drawing.Size(98, 23);
            this.pnCQ_btUpdateQuestion.TabIndex = 6;
            this.pnCQ_btUpdateQuestion.Text = "Update Question";
            this.pnCQ_btUpdateQuestion.UseVisualStyleBackColor = true;
            this.pnCQ_btUpdateQuestion.Click += new System.EventHandler(this.pnCQ_btUpdateQuestion_Click);
            // 
            // pnCQ_btNextQuestion
            // 
            this.pnCQ_btNextQuestion.Location = new System.Drawing.Point(507, 238);
            this.pnCQ_btNextQuestion.Name = "pnCQ_btNextQuestion";
            this.pnCQ_btNextQuestion.Size = new System.Drawing.Size(98, 23);
            this.pnCQ_btNextQuestion.TabIndex = 6;
            this.pnCQ_btNextQuestion.Text = "Next question";
            this.pnCQ_btNextQuestion.UseVisualStyleBackColor = true;
            this.pnCQ_btNextQuestion.Click += new System.EventHandler(this.pnCQ_btNextQuestion_Click);
            // 
            // pnCQ_btSaveToEB
            // 
            this.pnCQ_btSaveToEB.Location = new System.Drawing.Point(681, 510);
            this.pnCQ_btSaveToEB.Name = "pnCQ_btSaveToEB";
            this.pnCQ_btSaveToEB.Size = new System.Drawing.Size(131, 23);
            this.pnCQ_btSaveToEB.TabIndex = 7;
            this.pnCQ_btSaveToEB.Text = "Save to exam bank";
            this.pnCQ_btSaveToEB.UseVisualStyleBackColor = true;
            this.pnCQ_btSaveToEB.Click += new System.EventHandler(this.pnCQ_btSaveToEB_Click);
            // 
            // pnCQ_txtA4
            // 
            this.pnCQ_txtA4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnCQ_txtA4.Location = new System.Drawing.Point(64, 208);
            this.pnCQ_txtA4.Multiline = true;
            this.pnCQ_txtA4.Name = "pnCQ_txtA4";
            this.pnCQ_txtA4.Size = new System.Drawing.Size(749, 20);
            this.pnCQ_txtA4.TabIndex = 5;
            // 
            // pnCQ_txtA3
            // 
            this.pnCQ_txtA3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnCQ_txtA3.Location = new System.Drawing.Point(64, 175);
            this.pnCQ_txtA3.Multiline = true;
            this.pnCQ_txtA3.Name = "pnCQ_txtA3";
            this.pnCQ_txtA3.Size = new System.Drawing.Size(749, 20);
            this.pnCQ_txtA3.TabIndex = 4;
            // 
            // pnCQ_txtA2
            // 
            this.pnCQ_txtA2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnCQ_txtA2.Location = new System.Drawing.Point(64, 142);
            this.pnCQ_txtA2.Multiline = true;
            this.pnCQ_txtA2.Name = "pnCQ_txtA2";
            this.pnCQ_txtA2.Size = new System.Drawing.Size(749, 20);
            this.pnCQ_txtA2.TabIndex = 3;
            // 
            // pnCQ_txtA1
            // 
            this.pnCQ_txtA1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnCQ_txtA1.Location = new System.Drawing.Point(64, 109);
            this.pnCQ_txtA1.Multiline = true;
            this.pnCQ_txtA1.Name = "pnCQ_txtA1";
            this.pnCQ_txtA1.Size = new System.Drawing.Size(749, 20);
            this.pnCQ_txtA1.TabIndex = 2;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(37, 212);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(14, 13);
            this.rd4.TabIndex = 0;
            this.rd4.TabStop = true;
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(37, 179);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(14, 13);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(37, 146);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(14, 13);
            this.rd2.TabIndex = 0;
            this.rd2.TabStop = true;
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(37, 113);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(14, 13);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // pnCQ_txtQ
            // 
            this.pnCQ_txtQ.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnCQ_txtQ.Location = new System.Drawing.Point(64, 9);
            this.pnCQ_txtQ.Multiline = true;
            this.pnCQ_txtQ.Name = "pnCQ_txtQ";
            this.pnCQ_txtQ.Size = new System.Drawing.Size(749, 88);
            this.pnCQ_txtQ.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your question list:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // btLoadFromAFile
            // 
            this.btLoadFromAFile.Location = new System.Drawing.Point(127, 13);
            this.btLoadFromAFile.Name = "btLoadFromAFile";
            this.btLoadFromAFile.Size = new System.Drawing.Size(97, 27);
            this.btLoadFromAFile.TabIndex = 9;
            this.btLoadFromAFile.Text = "Load from a file";
            this.btLoadFromAFile.UseVisualStyleBackColor = true;
            this.btLoadFromAFile.Click += new System.EventHandler(this.btLoadFromAFile_Click);
            // 
            // btMakeAnExamFile
            // 
            this.btMakeAnExamFile.Location = new System.Drawing.Point(230, 13);
            this.btMakeAnExamFile.Name = "btMakeAnExamFile";
            this.btMakeAnExamFile.Size = new System.Drawing.Size(106, 27);
            this.btMakeAnExamFile.TabIndex = 10;
            this.btMakeAnExamFile.Text = "Make an Exam file";
            this.btMakeAnExamFile.UseVisualStyleBackColor = true;
            this.btMakeAnExamFile.Click += new System.EventHandler(this.btMakeAnExamFile_Click);
            // 
            // btScoreEmpExam
            // 
            this.btScoreEmpExam.Location = new System.Drawing.Point(463, 13);
            this.btScoreEmpExam.Name = "btScoreEmpExam";
            this.btScoreEmpExam.Size = new System.Drawing.Size(151, 27);
            this.btScoreEmpExam.TabIndex = 11;
            this.btScoreEmpExam.Text = "Score the Employee exam";
            this.btScoreEmpExam.UseVisualStyleBackColor = true;
            this.btScoreEmpExam.Click += new System.EventHandler(this.btScoreEmpExam_Click);
            // 
            // btMakeResultFile
            // 
            this.btMakeResultFile.Location = new System.Drawing.Point(342, 13);
            this.btMakeResultFile.Name = "btMakeResultFile";
            this.btMakeResultFile.Size = new System.Drawing.Size(115, 27);
            this.btMakeResultFile.TabIndex = 12;
            this.btMakeResultFile.Text = "Make a result file";
            this.btMakeResultFile.UseVisualStyleBackColor = true;
            this.btMakeResultFile.Click += new System.EventHandler(this.btMakeResultFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btCreateQuestions);
            this.panel1.Controls.Add(this.btMakeResultFile);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btScoreEmpExam);
            this.panel1.Controls.Add(this.btLoadFromAFile);
            this.panel1.Controls.Add(this.btMakeAnExamFile);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 56);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lbShowInfo);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 36);
            this.panel2.TabIndex = 14;
            // 
            // FormExaminationMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(857, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnCreateQuestion);
            this.Name = "FormExaminationMaker";
            this.Text = "Examination Maker";
            this.pnCreateQuestion.ResumeLayout(false);
            this.pnCreateQuestion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbShowInfo;
        private System.Windows.Forms.Button btCreateQuestions;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel pnCreateQuestion;
        private System.Windows.Forms.TextBox pnCQ_txtQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.TextBox pnCQ_txtA4;
        private System.Windows.Forms.TextBox pnCQ_txtA3;
        private System.Windows.Forms.TextBox pnCQ_txtA2;
        private System.Windows.Forms.TextBox pnCQ_txtA1;
        private System.Windows.Forms.Button pnCQ_btNextQuestion;
        private System.Windows.Forms.Button pnCQ_btSaveToEB;
        private System.Windows.Forms.ListBox lboxQuestionList;
        private System.Windows.Forms.Button pnCQ_btDeleteQuestion;
        private System.Windows.Forms.Button pnCQ_btUpdateQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLoadFromAFile;
        private System.Windows.Forms.Button btMakeAnExamFile;
        private System.Windows.Forms.Button btScoreEmpExam;
        private System.Windows.Forms.Button btMakeResultFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}