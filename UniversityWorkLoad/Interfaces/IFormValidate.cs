namespace UniversityWorkLoad.Interfaces;

public interface IFormValidate
{
    bool IsValid();

    public static void NotValidMsg() =>
        MessageBox.Show("Данные введены неверно.", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
}