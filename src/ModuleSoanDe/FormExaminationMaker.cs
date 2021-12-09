using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;

namespace ModuleSoanDe
{
    public partial class FormExaminationMaker : Form
    {
        private String userName;
        public String UserName
        {
            get { return userName; }
            set {
                userName = value;
                lbShowInfo.Text = $"Welcome {userName} to the Examination Maker application! Hang around to get instruction to each our functions";
            }
        }
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------
        // Variables------------------------------------------------------------------------------------
        private int NumOfQuestion = 0;
        private List<ExamBank> examBanks = new List<ExamBank>();
        private ExamBank tempEB = new ExamBank();
        private List<String> EID_Res = new List<String>();
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------
        public FormExaminationMaker()
        {
            InitializeComponent();

            SettingUpForm();



        }

        private void SettingUpForm()
        {
            // alight form to center
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;


            pnCreateQuestion.Hide();
            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;

            btMakeAnExamFile.Enabled = false;
            btMakeResultFile.Enabled = false;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCreateQuestion(object sender, EventArgs e)
        {
            // set up
            pnCreateQuestion.Show();
            btCreateQuestions.Enabled = false;


            lbShowInfo.Text = $"Create your question in the panel below! Remember to check the radio button for each correct answer!";

        }
        private void ClearContentInPanel()
        {
            pnCQ_txtQ.Clear();
            pnCQ_txtA1.Clear();
            pnCQ_txtA2.Clear();
            pnCQ_txtA3.Clear();
            pnCQ_txtA4.Clear();
            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;
        }
        private void ClearPanelAndUpdateInfo()
        {
            lbShowInfo.Text = $"Create your question number {++NumOfQuestion}!";
            ClearContentInPanel();
        }
        private bool CheckValidCreateQuestion()
        {
            if (pnCQ_txtQ.Text == "" || pnCQ_txtA1.Text == "" || pnCQ_txtA2.Text == "" || pnCQ_txtA3.Text == "" || pnCQ_txtA4.Text == "")
                return false;
            if (!rd1.Checked && !rd2.Checked && !rd3.Checked && !rd4.Checked)
                return false;
            return true;
        }

        private void GetValueFromForm()
        {
            // new temp variable
            tempEB = new ExamBank();

            // question
            tempEB._Q = pnCQ_txtQ.Text;

            // answers
            // (có cách tốt hơn nếu số lượng tb & rb quá nhiều là nhóm đưa nhóm textbox vào 1 panel riêng, radiobutton vào 1 panel riêng)
            TextBox[] textBoxes = new[] { pnCQ_txtA1, pnCQ_txtA2, pnCQ_txtA3, pnCQ_txtA4 };
            RadioButton[] radioButtons = new RadioButton[] { rd1, rd2, rd3, rd4 };
            int index = -1;
            foreach (RadioButton rb in radioButtons)
            {
                index++;
                if (!rb.Checked)
                    tempEB._A.Add("0-" + textBoxes[index].Text);
                else
                    tempEB._A.Add("1-" + textBoxes[index].Text);
            }
        }
        private void SaveAQuestionToExamBank()
        {
            // get value
            GetValueFromForm();

            // add to exam bank
            examBanks.Add(tempEB);

            // add to listbox
            lboxQuestionList.Items.Add(tempEB.ToString());
        }
        private void pnCQ_btNextQuestion_Click(object sender, EventArgs e)
        {
            if (!CheckValidCreateQuestion())
                MessageBox.Show("Don't leave the blank field or uncheck the radio button as known as the answer!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // save to exambank
                SaveAQuestionToExamBank();

                // Update elements
                ClearPanelAndUpdateInfo();
            }
            

        }

        private void pnCQ_btUpdateQuestion_Click(object sender, EventArgs e)
        {
            int index = lboxQuestionList.SelectedIndex;
            if (!CheckValidCreateQuestion())
                MessageBox.Show("Don't leave the blank field or uncheck the radio button as known as the answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (index >=0)
            {
                GetValueFromForm();
                examBanks[index] = tempEB;
                lboxQuestionList.Items[index] = tempEB.ToString();
                ClearContentInPanel();
            }
            else
                MessageBox.Show("No selected question to UPDATE or have no question in the current list!","Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pnCQ_btDeleteQuestion_Click(object sender, EventArgs e)
        {
            int index = lboxQuestionList.SelectedIndex;
            if (index >= 0)
            {
                examBanks.RemoveAt(index);
                lboxQuestionList.Items.RemoveAt(index);
                ClearContentInPanel();
            }
            else
                MessageBox.Show("No selected question to DELETE or have no question in the current list!", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MakeXMLFile(string FileName, List<ExamBank> examBanks, string purpose)
        {
            // ____________________ XML ____________________
            String pathh = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            

            XmlWriter wr = XmlWriter.Create($"{pathh}/{FileName}", new XmlWriterSettings() { Indent = true });

            wr.WriteStartElement("ExamBank");
            // Exambank: NumQuestions is number of question
            if (purpose == "ForExamBank")
                wr.WriteAttributeString("NumQuestions", examBanks.Count.ToString());
            // Employee: 
            if (purpose == "ForEmployee")
                wr.WriteAttributeString("ID_NumQ", mixCount.ToString() + "_" + examBanks.Count.ToString());

            foreach (var quest in examBanks)
            {
                wr.WriteStartElement("question");

                wr.WriteValue(quest._Q);

                wr.WriteEndElement();

                int k_index = -1;
                foreach (var ans in quest._A)
                {
                    k_index++;
                    wr.WriteStartElement("answer");
                    if (purpose == "ForExamBank")
                        wr.WriteValue(ans);
                    if (purpose == "ForEmployee")
                        wr.WriteValue(ans.Split('-')[1]);
                    wr.WriteEndElement();

                }
            }

            wr.WriteEndElement();
            wr.Close();

        }
        private void pnCQ_btSaveToEB_Click(object sender, EventArgs e)
        {
            MakeXMLFile("ExamBank.xml", examBanks, "ForExamBank");


            lbShowInfo.Text = "Save file successfully! Check the Data/ExamBank.xml file in your computer.";

            pnCreateQuestion.Visible = false;
        }
        private void UpdateContentWhenSelected(int index)
        {
            pnCQ_txtQ.Text = examBanks[index]._Q.ToString();
            pnCQ_txtA1.Text = examBanks[index]._A[0].ToString().Split('-')[1];
            pnCQ_txtA2.Text = examBanks[index]._A[1].ToString().Split('-')[1];
            pnCQ_txtA3.Text = examBanks[index]._A[2].ToString().Split('-')[1];
            pnCQ_txtA4.Text = examBanks[index]._A[3].ToString().Split('-')[1];

            RadioButton[] radioButtons = new RadioButton[] { rd1, rd2, rd3, rd4 };
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (int.Parse(examBanks[index]._A[i].Split('-')[0]) == 1)
                {
                    radioButtons[i].Checked = true;
                    break;
                }
            }
        }
        private void lboxQuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxQuestionList.SelectedIndex;
            if (index >= 0)
            {
                // update the content when select
                UpdateContentWhenSelected(index);
            }

        }
        private void LoadAXMLFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Load the xml file .xml|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;

                using (var xml = XmlReader.Create(filePath))
                {
                    xml.ReadToFollowing("ExamBank");
                    xml.MoveToAttribute("NumQuestions");
                    int numQ = int.Parse(xml.Value);

                    for (int i = 0; i < numQ; i++)
                    {


                        ExamBank temp = new ExamBank();

                        xml.ReadToFollowing("question");
                        temp._Q = xml.ReadElementContentAsString();

                        for (int j = 0; j < 4; j++)
                        {
                            xml.ReadToFollowing("answer");
                            temp._A.Add(xml.ReadElementContentAsString());
                        }

                        examBanks.Add(temp);
                        lboxQuestionList.Items.Add(temp.ToString());

                    }
                }

            }
        }
        private void btLoadFromAFile_Click(object sender, EventArgs e)
        {
            pnCreateQuestion.Visible = true;
            btMakeAnExamFile.Enabled = true;

            LoadAXMLFile();
        }
        private List<ExamBank> mixedEB = new List<ExamBank>();
        private List<ExamBank> tempMixedEB = new List<ExamBank>();
        private int mixCount = 0;


        private void UpdateResultCurrentExamID()
        {
            // EID_Res
            String tt = mixCount.ToString() + "|";
            List<int> res = new List<int>();

            foreach(var q in mixedEB)
            {
                for (int i = 0; i < q._A.Count; i++)
                    if (q._A[i].Split('-')[0] == "1")
                    {
                        res.Add(i + 1);
                    }
            }

            tt += String.Join(",", res);

            EID_Res.Add(tt);

        }
        private void MixThings()
        {
            // mix questions
            var rnd = new Random();
            var randomized = tempMixedEB.OrderBy(item => rnd.Next());

            foreach (var value in randomized)
                mixedEB.Add(value);

            // mix answers
            foreach (var quest in mixedEB)
            {
                rnd = new Random();
                var randomized2 = quest._A.OrderBy(item => rnd.Next());

                List<String> temp = new List<String> { };
                foreach (var ans in randomized2)
                    temp.Add(ans.ToString());
                
                for (int i = 0; i < temp.Count; i++)
                    quest._A[i] = temp[i].ToString();
            }

            UpdateResultCurrentExamID();


        }
        private void btMakeAnExamFile_Click(object sender, EventArgs e)
        {
            // hide the panel
            pnCreateQuestion.Visible = false;
            // enaable 'make result file' button
            btMakeResultFile.Enabled = true;
            // clean
            mixedEB.Clear();
            tempMixedEB.Clear();
            // receveive data from exam bank
            for (int i = 0; i < examBanks.Count; i++)
                tempMixedEB.Add(examBanks[i]);
            // mix questions and answers
            mixCount++;
            MixThings();



            lbShowInfo.Text = $"You has made the ExamIDNo{mixCount}.xml file!";

            MakeXMLFile($"ExamIDNo{mixCount}.xml", mixedEB, "ForEmployee");

        }
        private void btMakeResultFile_Click(object sender, EventArgs e)
        {
            // ____________________ TXT ____________________
            String pathh = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            StreamWriter sw = File.CreateText($"{pathh}/Data/EID_Res.txt");
            sw.WriteLine(EID_Res.Count.ToString());
            for (int i = 0; i < EID_Res.Count; i++)
            {
                sw.WriteLine(EID_Res[i].ToString());
            }

            sw.Close();
            MessageBox.Show("An ID exam with result has been made!");

        }
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------
        // Variables------------------------------------------------------------------------------------
        private List<EmpInfo> empInfos = new List<EmpInfo>();
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------


        private void btScoreEmpExam_Click(object sender, EventArgs e)
        {
            // variable in general:
            List<String> EID_Res_FromText = new List<String>();
            List<String> EID_Res_Employee = new List<String>();
            empInfos.Clear();


            // read the Result of the each ID exam - TXT file  -----------------------------------------------------------------------------------

            // form load file
            String pathh = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filePath = $"{pathh}/Data/EID_Res.txt";
            FileInfo fi = new FileInfo(filePath);

            // check file exists!!
            if (!File.Exists(@fi.FullName))
            {
                MessageBox.Show("File not found!");
                return;
            }

            StreamReader sr = File.OpenText(@fi.FullName);
            int len_EID_Res_FromText = int.Parse(sr.ReadLine());
            

            for (int i = 0; i <= len_EID_Res_FromText; i++)
            {
                String t = sr.ReadLine();
                EID_Res_FromText.Add(t);
            }
            // ---------------------------------------------------------------

            // read the answer of employee - XML file -------------------------------------------------------------------------------------------
            String path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            for (int i = 0; i < fi.FullName.Length - filePath.Length; i++)
                path += fi.FullName[i];
            path += "/Answer from Employee/";

            // get xml files (full path)
            var files = Directory.GetFiles(path).ToList();

            // check file exists!!
            if (files.Count == 0)
            {
                MessageBox.Show("Have no file answer from employee!");
                return;
            }

            foreach (var f in files)
            {
                // clear
                EID_Res_Employee.Clear();

                // get name file - no extension
                FileInfo fii = new FileInfo(f);
                String name_file_without_extension = fii.Name.Split('.')[0];
                // get info: id exam, id employee, time do the test
                EmpInfo tempEI = new EmpInfo();
                tempEI.IDExam = name_file_without_extension.Split('_')[0];
                tempEI.IDEmp = name_file_without_extension.Split('_')[1];
                tempEI.TimeDoTest = name_file_without_extension.Split('_')[2];


                // read xml file
                using (var xml = XmlReader.Create(f))
                {
                    xml.ReadToFollowing("Exam");
                    xml.MoveToAttribute("IDExam_IDEmp");
                    String ignore = xml.Value;

                    while (xml.ReadToFollowing("answer"))
                    {
                        EID_Res_Employee.Add(xml.ReadElementContentAsString());
                    }
                }

                // calculate score
                String[] res_from_text = EID_Res_FromText[int.Parse(tempEI.IDExam) - 1].Split('|')[1].Split(','); // get result based on Exam ID

                for (int i = 0; i < EID_Res_Employee.Count; i++)
                {
                    //MessageBox.Show(EID_Res_Employee[i] + "\n" + res_from_text[i]);
                    if (EID_Res_Employee[i].Equals(res_from_text[i]))
                        tempEI.Score += 1;

                }

                //MessageBox.Show(tempEI.ToString()); // test

                // add to EI list

                empInfos.Add(tempEI);

            }

            // Sort descending
            empInfos.Sort(new DescendingScore());

            // Save to TXT the employee information
            String path3 = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            StreamWriter sw = File.CreateText($"{path3}/Employee_Information_In_Examination.txt");
            sw.WriteLine("IDEmp, IDExam, Time, Score");
            for (int i = 0; i < empInfos.Count; i++)
            {
                sw.WriteLine(empInfos[i].ToString());
            }

            sw.Close();
            MessageBox.Show("Saved file! Check the Employee_Information_In_Examination.txt file in your computer!");

        }


    }
    class DescendingScore : IComparer<EmpInfo>
    {
        public int Compare(EmpInfo e1, EmpInfo e2)
        {
            if (e1.Score < e2.Score)
                return +1;
            if (e1.Score > e2.Score)
                return -1;
            return 0;
        }
    }
}
