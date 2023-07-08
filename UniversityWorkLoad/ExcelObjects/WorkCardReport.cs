using System.Diagnostics;
using UniversityWorkLoad.DatabaseEntities;
using ClosedXML.Report;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.ExcelObjects;

public class WorkCardReport
{
    private WorkCard _workCard;
    public WorkCardReport(WorkCard workCard) => _workCard = workCard;

    public void MakeReport()
    {
        var template = new XLTemplate("ExcelPatterns/WorkCardPattern.xltx");
        var sfd = new SaveFileDialog();
        sfd.Filter = "XLSX|*.xlsx|XLS|*.xls";
        if (sfd.ShowDialog() != DialogResult.OK) return;
        var reportData = ReportData.Transform(_workCard);
        template.AddVariable(reportData);
        template.Generate();
        template.Workbook.Worksheets.Worksheet(template.Workbook.Worksheets.First().Name).ColumnsUsed()
            .AdjustToContents();
        template.SaveAs(sfd.FileName);
    }

    private class ReportData
    {
        public int CardId { get; set; }
        public int ReportCardId { get; set; }
        public string Lecturer { get; set; }

        public string Position { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<ReportItemValue> WorkLoadLines { get; set; } = new List<ReportItemValue>();

        public static ReportData Transform(WorkCard workCard)
        {
            return new ReportData()
            {
                CardId = workCard.CardId,
                Lecturer = workCard.Lecturer.ToString(),
                Position = workCard.Lecturer.Position.ToString(),
                ReportCardId = workCard.Lecturer.ReportCardId,
                Date = workCard.Date.ToDateTime(TimeOnly.MinValue),
                WorkLoadLines = workCard.WorkLoadLines != null ?
                    workCard.WorkLoadLines.OrderBy(x => x.LineId).Select((workLoadLine, id) =>
                        ReportItemValue.Create(workLoadLine, id + 1)) :
                    new List<ReportItemValue>()
            };
        }
    }

    private class ReportItemValue
    {
        public int Id { get; set; }
        public string StudyGroup { get; set; }
        public string Discipline { get; set; }
        public int LecturerHours { get; set; }
        public int PracticeHours { get; set; }
        public int OtherHours { get; set; }

        public static ReportItemValue Create(WorkLoadLine workLoad, int lineId)
        {
            return new ReportItemValue
            {
                StudyGroup = workLoad.StudyGroup.ToString(),
                Discipline = workLoad.Discipline.ToString(),
                LecturerHours = workLoad.LectureHours,
                PracticeHours = workLoad.PracticeHours,
                OtherHours = workLoad.OtherHours,
                Id = lineId
            };
        }
    }
}