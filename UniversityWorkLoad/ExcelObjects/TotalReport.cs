using System.Runtime.CompilerServices;
using ClosedXML.Report;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.ExcelObjects;

public class TotalReport
{
    private IEnumerable<WorkCard> _workCard;
    private DateTime _startDate;
    private DateTime _endDate;

    public TotalReport(IEnumerable<WorkCard> workCard, DateTime startDate, DateTime endDate)
    {
        _workCard = workCard;
        _startDate = startDate;
        _endDate = endDate;
    }

    public void MakeReport()
    {
        var template = new XLTemplate("ExcelPatterns/TotalPattern.xltx");
        var sfd = new SaveFileDialog();
        sfd.Filter = "XLSX|*.xlsx|XLS|*.xls";
        if (sfd.ShowDialog() != DialogResult.OK) return;
        var reportData = ReportData.Transform(_workCard, _startDate, _endDate);
        template.AddVariable(reportData);
        template.Generate();
        template.Workbook.Worksheets.Worksheet(template.Workbook.Worksheets.First().Name).ColumnsUsed()
            .AdjustToContents();
        template.SaveAs(sfd.FileName);
    }

    private class ReportData
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<GreatReportValue> GreatReportValues { get; set; }

        public static ReportData Transform(IEnumerable<WorkCard> workCards, DateTime startDate, DateTime endDate)
        {
            var correctWorkCard = workCards.Where(workCard =>
                startDate <= workCard.Date.ToDateTime(TimeOnly.MinValue) &&
                workCard.Date.ToDateTime(TimeOnly.MaxValue) <= endDate);
            var groups = correctWorkCard.GroupBy(workCard => workCard.Lecturer);
            var reportValues = groups.Select((group, id) =>
            {
                var curId = id + 1;
                var lecturer = group.Key;
                var items = group.SelectMany(gr => gr.WorkLoadLines);
                var grouperByDiscipline = items.GroupBy(disc => disc.Discipline);
                var reportValues = grouperByDiscipline.Select(discGroup =>
                {
                    var discipline = discGroup.Key.ToString();
                    var lecturerSum = discGroup.Sum(info => info.LectureHours);
                    var practiceSum = discGroup.Sum(info => info.PracticeHours);
                    var otherSum = discGroup.Sum(info => info.OtherHours);
                    return ReportValue.Create(discipline, lecturerSum, practiceSum, otherSum);
                });
                return GreatReportValue.Create(curId, lecturer.ReportCardId, lecturer.ToString(), reportValues);
            });
            return new ReportData()
            {
                StartDate = startDate,
                EndDate = endDate,
                GreatReportValues = reportValues,
            };
        }

        internal class GreatReportValue
        {
            public int Id { get; set; }
            public int LecturerId { get; set; }
            public string Lecturer { get; set; }

            public IEnumerable<ReportValue> ReportValues { get; set; }

            public static GreatReportValue Create(int id, int lecturerId, string lecturer, IEnumerable<ReportValue> reportValues) => new()
                {
                    Id = id,
                    LecturerId = lecturerId,
                    Lecturer = lecturer,
                    ReportValues = reportValues
                };
        }
        internal class ReportValue
        {
            public string Discipline { get; set; }
            public int LecturerHours { get; set; }
            public int PracticeHours { get; set; }
            public int OtherHours { get; set; }

            public static ReportValue Create(string discipline, int lecturerHours, int practiceHours,
                int otherHours) => new()
            {
                Discipline = discipline,
                OtherHours = otherHours,
                PracticeHours = practiceHours,
                LecturerHours = lecturerHours
            };
        }
    }
}