using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MKB2._1
{
    public static class MKB_parser
    {
        public static MKB parseMKB (string file)
        {
            MKB mkb = new MKB();// создаем объект 
            bool summaryIsHere = false, questionsIsHere = true, probablsIsHere = true;
            int begin = 0;
            string[] global_array = file.Split('\n'); // разбиваем строку 
            for (int i = 0; i < global_array.Length; ++i )
            {
                if (!summaryIsHere && global_array[i].CompareTo("Признаки:\r") == 0)
                {
                    string summary = "";
                    for (int j = 0; j < i-1; ++j) // проходимся по признакам
                    {
                        summary += global_array[j];
                    }
                    mkb.Summary = "" + summary;
                    summaryIsHere = true;
                    questionsIsHere = false;
                    begin = i + 1;
                    continue;
                }

                if (!questionsIsHere && global_array[i].CompareTo("\r") == 0)
                {
                    mkb.Questions = new List<string>();
                    for (int j = 0, k = begin; k < i; ++j, ++k)// проходимся по вопросам
                    {
                        mkb.Questions.Add(global_array[k]);
                    }
                    questionsIsHere = true;
				    probablsIsHere = false;
				    begin = i + 1;
				    continue;
                }

                if (!probablsIsHere)
                {
                    mkb.Objects = new List<MKBObject>();
                    for (int j = 0, k = begin; k < global_array.Length; ++j, ++k)
				    {
					    string[] line_array = global_array[k].Split(',');
                        MKBObject mkb_obj = new MKBObject();
					    mkb_obj.Name = line_array[0];
                        mkb_obj.Probabl = double.Parse(line_array[1], CultureInfo.InvariantCulture);
                        mkb_obj.QuestProbabls = new List<MKBQuest>();
					    for (int r = 2; r < line_array.Length; r+=3)
					    {
                            MKBQuest mkb_quest = new MKBQuest();
						    mkb_quest.ID = int.Parse(line_array[r]) - 1;
                            mkb_quest.Probabl1 = double.Parse(line_array[r + 1], CultureInfo.InvariantCulture);
                            mkb_quest.Probabl2 = double.Parse(line_array[r + 2], CultureInfo.InvariantCulture);
                            mkb_obj.QuestProbabls.Add(mkb_quest);
                        }
                        mkb.Objects.Add(mkb_obj);
				    }
				    probablsIsHere = true;
                }
            }
            return mkb;
        }
    }

    public class MKB
    {
        public string Summary { get; set; }
        public List<string> Questions { get; set; }
        public List<MKBObject> Objects { get; set; }
        public MKB Clone()
        {
            MKB mkb_clone = new MKB();
            mkb_clone.Summary = "" + Summary;
            mkb_clone.Objects = new List<MKBObject>();
            mkb_clone.Questions = new List<string>();
            foreach (MKBObject o in Objects)
            {
                MKBObject oc = new MKBObject();
                oc.Name = "" + o.Name;
                oc.Probabl = o.Probabl;
                oc.QuestProbabls = new List<MKBQuest>();
                foreach (MKBQuest q in o.QuestProbabls)
                {
                    MKBQuest qc = new MKBQuest();
                    qc.ID = q.ID;
                    qc.Probabl1 = q.Probabl1;
                    qc.Probabl2 = q.Probabl2;
                    oc.QuestProbabls.Add(qc);
                }
                mkb_clone.Objects.Add(oc);
            }
            foreach(string q in Questions)
            {
                mkb_clone.Questions.Add("" + q);
            }
            return mkb_clone;
        }
    }

    public class MKBQuest
    {
        public int ID { get; set; }
        public double Probabl1 { get; set; }
        public double Probabl2 { get; set; }
    }

    public class MKBObject
    {
        public string Name { get; set; }
        public double Probabl { get; set; }
        public List<MKBQuest> QuestProbabls { get; set; }
    }
}
