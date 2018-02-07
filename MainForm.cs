using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKB2._1
{
    public partial class MainForm : Form
    {
        bool simulationIsStart = false;
        MKB mkb, mkb_clone;
        public MainForm()
        {
            InitializeComponent();

            startSimulationBut.Enabled = false;
            listObjectsView.Enabled = false;
            Info.Text = null;
            activeQuestion.Text = "Загрузите базу знаний...";
            listActiveQuestions.Enabled = false;
            listPassiveQuestions.Enabled = false;
            summaryView.Text = null;
            kuBox.Visible = false;
            kuBox.Enabled = false;
            kuBox.Location = rBox.Location;
            rBox.Enabled = false;
            listResult.Enabled = false;
            orderByBox.Enabled = false;
        }

        private void kurBut_Click(object sender, EventArgs e)
        {
            kuBox.Visible = !kuBox.Visible;
            rBox.Visible = !rBox.Visible;
        }

        private void openFileBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dOpen = new OpenFileDialog();
            Stream fileStream = null;
            dOpen.Title = "Открыть файл";
            dOpen.Multiselect = false;
            dOpen.Filter = "mkb files (*.mkb)|*.mkb";
            dOpen.FilterIndex = 1;
            dOpen.RestoreDirectory = true;

            if (dOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = dOpen.OpenFile()) != null)
                    {
                        string file = "";
                        int streamLength = (int)fileStream.Length;
                        byte[] buffer = new byte[streamLength];
                        fileStream.Read(buffer, 0, streamLength);
                        fileStream.Close();
                        buffer = Encoding.Convert(Encoding.GetEncoding("Windows-1251"), Encoding.UTF8, buffer);
                        file = Encoding.UTF8.GetString(buffer);
                        mkb = MKB_parser.parseMKB(file);
                        sortBy(mkb);
                        Info.Text = "Свидетельств: " + mkb.Questions.Count + "\r\nИсходов: " + mkb.Objects.Count;
                        activeQuestion.Text = "Можно начинать консультацию...";
                        startSimulationBut.Enabled = true;
                        listObjectsView.Enabled = true;
                        listActiveQuestions.Enabled = true;
                        listPassiveQuestions.Enabled = true;
                        listResult.Enabled = true;
                        orderByBox.Enabled = true;
                        summaryView.Text = mkb.Summary;
                        updateObjects(mkb);
                        foreach(string q in mkb.Questions)
                        {
                            listActiveQuestions.Items.Add(q);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Original error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doPassive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listActiveQuestions.SelectedItems.Count; ++i)
            {
                listPassiveQuestions.Items.Add(listActiveQuestions.SelectedItems[i]);
                listActiveQuestions.Items.Remove(listActiveQuestions.SelectedItems[i]);
            }
        }

        private void doActive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPassiveQuestions.SelectedItems.Count; ++i)
            {
                listActiveQuestions.Items.Add(listPassiveQuestions.SelectedItems[i]);
                listPassiveQuestions.Items.Remove(listPassiveQuestions.SelectedItems[i]);
            }
        }

        private void startSimulationBut_Click(object sender, EventArgs e)
        {
            simulationIsStart = !simulationIsStart;
            if (simulationIsStart)
            {
                mkb_clone = mkb.Clone();
                sortBy(mkb_clone);
                startSimulationBut.BackgroundImage = Image.FromFile("imgs/ON.jpg");
                rBox.Enabled = true;
                kuBox.Enabled = true;
                activeQuestion.Text = listActiveQuestions.Items[0].ToString();
                listActiveQuestions.Items.RemoveAt(0);
            }
            else
            {
                listActiveQuestions.Items.Clear();
                foreach (string q in mkb.Questions)
                {
                    listActiveQuestions.Items.Add(q);
                }
                startSimulationBut.BackgroundImage = Image.FromFile("imgs/OFF.jpg");
                listResult.Items.Clear();
                rBox.Enabled = false;
                kuBox.Enabled = false;
                activeQuestion.Text = "Можно начинать консультацию...";
            }
        }

        private void yesBut_Click(object sender, EventArgs e)
        {
            listResult.Items.Add("(Р=1) " + activeQuestion.Text);
            int questIndex = mkb.Questions.IndexOf(activeQuestion.Text), zeroCount = 0;
            foreach (MKBObject o in mkb_clone.Objects)
            {
                o.Probabl = (o.Probabl * o.QuestProbabls[questIndex].Probabl1)/
                            (o.QuestProbabls[questIndex].Probabl1 * o.Probabl + o.QuestProbabls[questIndex].Probabl2 * (1 - o.Probabl));
                if (o.Probabl == 0 || o.Probabl == 1)
                {
                    if (o.Probabl == 0) zeroCount++;
                    if (zeroCount == mkb_clone.Objects.Count || o.Probabl == 1)
                    {
                        rBox.Enabled = false;
                        kuBox.Enabled = false;
                        listResult.Items.Add("Консультация закончена");
                        activeQuestion.Text = "Чтоб начать новую консультацию, завершите текущую";
                        sortBy(mkb_clone);
                        updateObjects(mkb_clone);
                        return;
                    }
                }
            }
            sortBy(mkb_clone);
            updateObjects(mkb_clone);
            updateQuestions();
        }

        private void noBut_Click(object sender, EventArgs e)
        {
            listResult.Items.Add("(Р=0) " + activeQuestion.Text);
            int questIndex = mkb.Questions.IndexOf(activeQuestion.Text), zeroCount = 0;
            foreach (MKBObject o in mkb_clone.Objects)
            {
                o.Probabl = (o.Probabl * (1 - o.QuestProbabls[questIndex].Probabl1)) /
                            ((1 - o.QuestProbabls[questIndex].Probabl1) * o.Probabl + o.QuestProbabls[questIndex].Probabl2 * (1 - o.Probabl));
                if (o.Probabl == 0 || o.Probabl == 1)
                {
                    if (o.Probabl == 0) zeroCount++;
                    if (zeroCount == mkb_clone.Objects.Count || o.Probabl == 1)
                    {
                        rBox.Enabled = false;
                        kuBox.Enabled = false;
                        listResult.Items.Add("Консультация закончена");
                        activeQuestion.Text = "Чтоб начать новую консультацию, завершите текущую";
                        sortBy(mkb_clone);
                        updateObjects(mkb_clone);
                        return;
                    }
                }
            }
            sortBy(mkb_clone);
            updateObjects(mkb_clone);
            updateQuestions();
        }

        private void _kuButs_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            listResult.Items.Add("(КУ=" + b.Text + ") " + activeQuestion.Text);
            int questIndex = mkb.Questions.IndexOf(activeQuestion.Text), zeroCount = 0;
            foreach (MKBObject o in mkb_clone.Objects)
            {
                double approx = (o.Probabl * (1 - o.QuestProbabls[questIndex].Probabl1)) /
                            ((1 - o.QuestProbabls[questIndex].Probabl1) * o.Probabl + o.QuestProbabls[questIndex].Probabl2 * (1 - o.Probabl));
                double dessert = o.Probabl - approx;
                double step = dessert / 5;
                int but = int.Parse(b.Text);
                o.Probabl += but * step;
                if (o.Probabl == 0 || o.Probabl == 1)
                {
                    if (o.Probabl == 0) zeroCount++;
                    if (zeroCount == mkb_clone.Objects.Count || o.Probabl == 1)
                    {
                        rBox.Enabled = false;
                        kuBox.Enabled = false;
                        listResult.Items.Add("Консультация закончена");
                        activeQuestion.Text = "Чтоб начать новую консультацию, завершите текущую";
                        sortBy(mkb_clone);
                        updateObjects(mkb_clone);
                        return;
                    }
                }
            }
            sortBy(mkb_clone);
            updateObjects(mkb_clone);
            updateQuestions();
        }
        private void kuButs_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            listResult.Items.Add("(КУ=" + b.Text + ") " + activeQuestion.Text);
            int questIndex = mkb.Questions.IndexOf(activeQuestion.Text), zeroCount = 0;
            foreach (MKBObject o in mkb_clone.Objects)
            {
                double approx = (o.Probabl * o.QuestProbabls[questIndex].Probabl1) /
                            (o.QuestProbabls[questIndex].Probabl1 * o.Probabl + o.QuestProbabls[questIndex].Probabl2 * (1 - o.Probabl));
                double dessert = approx - o.Probabl;
                double step = dessert / 5;
                int but = int.Parse(b.Text);
                o.Probabl += but * step;
                if (o.Probabl == 0 || o.Probabl == 1)
                {
                    if (o.Probabl == 0) zeroCount++;
                    if (zeroCount == mkb_clone.Objects.Count || o.Probabl == 1)
                    {
                        rBox.Enabled = false;
                        kuBox.Enabled = false;
                        listResult.Items.Add("Консультация закончена");
                        activeQuestion.Text = "Чтоб начать новую консультацию, завершите текущую";
                        sortBy(mkb_clone);
                        updateObjects(mkb_clone);
                        return;
                    }
                }
            }
            sortBy(mkb_clone);
            updateObjects(mkb_clone);
            updateQuestions();
        }
        private void ku0Buts_Click(object sender, EventArgs e)
        {
            updateObjects(mkb_clone);
            listResult.Items.Add("(КУ=0) " + activeQuestion.Text);
            updateQuestions();
        }
        private void updateObjects(MKB mkb)
        {
            listObjectsView.Items.Clear();
            foreach (MKBObject o in mkb.Objects)
            {
                if (o.Probabl == 0 || o.Probabl == 1)
                    listObjectsView.Items.Add("(" + o.Probabl + ".000) " + o.Name);
                else listObjectsView.Items.Add("(" + Math.Round(o.Probabl, 3) + ") " + o.Name);
            }
        }
        private void updateQuestions()
        {
            if (listActiveQuestions.Items.Count != 0)
            {
                activeQuestion.Text = listActiveQuestions.Items[0].ToString();
                listActiveQuestions.Items.RemoveAt(0);
            }
            else
            {
                rBox.Enabled = false;
                kuBox.Enabled = false;
                listResult.Items.Add("Консультация закончена");
                activeQuestion.Text = "Чтоб начать новую консультацию, завершите текущую";
                sortBy(mkb_clone);
                updateObjects(mkb_clone);
            }
        }
        private void sortBy(MKB mkb)
        {
            if (byABCrb.Checked)
            {
                mkb.Objects = mkb.Objects.OrderBy(o => o.Name).ToList();
            }
            else if (byPrb.Checked)
            {
                mkb.Objects = mkb.Objects.OrderByDescending(o => o.Probabl).ToList();
            }
            updateObjects(mkb);
        }

        private void sort_CheckedChanged(object sender, EventArgs e)
        {
            if (simulationIsStart)
            {
                sortBy(mkb_clone);
            }
            else
            {
                sortBy(mkb);
            }
        }
    }
}
