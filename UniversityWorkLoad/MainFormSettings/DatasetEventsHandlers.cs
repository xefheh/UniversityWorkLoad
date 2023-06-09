namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm
    {
        private void UpdateToFaculties(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetFaculties();
        }

        private void UpdateToLecturers(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetLecturers();
        }

        private void UpdateToDisciplines(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetDisciplines();
        }

        private void UpdateToPositions(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetPositions();
        }

        private void UpdateToStudyGroups(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetStudyGroups();
        }

        private void UpdateToWorkCards(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetStudyGroups();
        }

        private void UpdateToWorkLoadLine(object sender, EventArgs e)
        {
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _adapter.GetWorkLoadLines();
        }
    }
}
