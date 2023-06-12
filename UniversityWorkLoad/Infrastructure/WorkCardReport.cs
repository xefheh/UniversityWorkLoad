using System.Diagnostics;
using UniversityWorkLoad.DatabaseEntities;
using ClosedXML.Report;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.Infrastructure;

public class WorkCardReport
{
    private WorkCard _workCard;
    public WorkCardReport(WorkCard workCard) => _workCard = workCard;

    public void MakeReport()
    {
        var template = new XLTemplate("pattern.xltx");
        var reportData = ReportData.Transform(_workCard);
        template.AddVariable(reportData);
        template.Generate();
        template.Workbook.Worksheets.Worksheet(template.Workbook.Worksheets.First().Name).ColumnsUsed()
            .AdjustToContents();
        template.SaveAs("report.xlsx");
        Process.Start(new ProcessStartInfo("report.xlsx") { UseShellExecute = true });
    }

    private class ReportData
    {
        public int CardId { get; set; }
        public int ReportCardId { get; set; }
        public string Lecturer { get; set; }

        public string Position { get; set; }

        public DateTime StartPeriod { get; set; }

        public DateTime EndPeriod { get; set; }

        public IEnumerable<ReportItemValue> WorkLoadLines { get; set; } = new List<ReportItemValue>();

        public static ReportData Transform(WorkCard workCard)
        {
            return new ReportData()
            {
                CardId = workCard.CardId, Lecturer = workCard.Lecturer.ToString(),
                Position = workCard.Lecturer.Position.ToString(), ReportCardId = workCard.Lecturer.ReportCardId,
                StartPeriod = workCard.StartPeriod.ToDateTime(TimeOnly.MinValue),
                EndPeriod = workCard.EndPeriod.ToDateTime(TimeOnly.MinValue),
                WorkLoadLines = (workCard.WorkLoadLines != null) ? 
                    workCard.WorkLoadLines.Select(ReportItemValue.Create) :
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

        public static ReportItemValue Create(WorkLoadLine workLoad)
        {
            return new ReportItemValue
            {
                StudyGroup = workLoad.StudyGroup.ToString(), Discipline = workLoad.Discipline.ToString(),
                LecturerHours = workLoad.LectureHours, PracticeHours = workLoad.PracticeHours,
                OtherHours = workLoad.OtherHours, Id = workLoad.LineId
            };
        }
    }
}