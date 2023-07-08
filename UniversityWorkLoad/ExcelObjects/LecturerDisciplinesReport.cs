using System.Runtime.CompilerServices;
using ClosedXML.Report;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.ExcelObjects;

public class LecturerDisciplinesReport
{
    private IEnumerable<WorkCard> _workCard;
    private DateTime _startDate;
    private DateTime _endDate;
    private Lecturer _lecturer;

    public LecturerDisciplinesReport(IEnumerable<WorkCard> workCard, DateTime startDate, DateTime endDate, Lecturer lecturer)
    {
        _workCard = workCard;
        _startDate = startDate;
        _endDate = endDate;
        _lecturer = lecturer;
    }

    public void MakeReport()
    {
        var template = new XLTemplate("ExcelPatterns/LecturerDisciplinesPattern.xltx");
        var sfd = new SaveFileDialog();
        sfd.Filter = "XLSX|*.xlsx|XLS|*.xls";
        if (sfd.ShowDialog() != DialogResult.OK) return;
        var reportData = ReportData.Transform(_workCard, _startDate, _endDate, _lecturer);
        template.AddVariable(reportData);
        template.Generate();
        template.Workbook.Worksheets.Worksheet(template.Workbook.Worksheets.First().Name).ColumnsUsed()
            .AdjustToContents();
        template.SaveAs(sfd.FileName);
    }

    private class ReportData
    {
        public string Lecturer { get; set; }
        public int LecturerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<ReportValue> ReportValues { get; set; }

        public static ReportData Transform(IEnumerable<WorkCard> workCards, DateTime startDate, DateTime endDate, Lecturer lecturer)
        {
            var correctWorkCard = workCards.Where(workCard =>
                startDate <= workCard.Date.ToDateTime(TimeOnly.MinValue) &&
                workCard.Date.ToDateTime(TimeOnly.MaxValue) <= endDate && workCard.Lecturer == lecturer);
            var workLoadLines = correctWorkCard.SelectMany(workCard => workCard.WorkLoadLines);
            var groups = workLoadLines.GroupBy(workLine => workLine.Discipline);
            var reportValues = groups.Select((group, id) =>
            {
                var curId = id + 1;
                var discipline = group.Key.ToString();
                var lines = group.Select(value => value);
                var lecturerHours = lines.Sum(line => line.LectureHours);
                var otherHours = lines.Sum(line => line.OtherHours);
                var practiceHours = lines.Sum(line => line.PracticeHours);
                return ReportValue.Create(curId, discipline, lecturerHours, practiceHours, otherHours);
            });
            return new ReportData()
            {
                StartDate = startDate, EndDate = endDate, ReportValues = reportValues, Lecturer = lecturer.ToString(),
                LecturerId = lecturer.ReportCardId
            };
        }

        internal class ReportValue
        {
            public int Id { get; set; }
            public string DisciplineName { get; set; }
            public int LecturerHours { get; set; }
            public int PracticeHours { get; set; }
            public int OtherHours { get; set; }

            public static ReportValue Create(int id, string disciplineName, int lecturerHours, int practiceHours,
                int otherHours) => new()
                {
                    Id = id,
                    DisciplineName = disciplineName,
                    OtherHours = otherHours,
                    PracticeHours = practiceHours,
                    LecturerHours = lecturerHours
                };
        }
    }
}