namespace Web_Fia41_HoeffkenV_Web_QuizQuestions.Models
{
    public interface IData
    {
        List<Questions> GetAllQuestions();

        Questions GetaSingleQuestion(int id);

        bool InsertQuestion(Questions data);

        bool DeleteQuestion(Questions data);

        bool UpdateQuestion(Questions data);

    }
}
