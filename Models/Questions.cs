using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace Web_Fia41_HoeffkenV_Web_QuizQuestions.Models
{
    public class Questions
    {
        public int QID { get; set; }

        public string Question { get; set; }

        public int Level { get; set; }

        public int FID { get; set; }
    }
}
