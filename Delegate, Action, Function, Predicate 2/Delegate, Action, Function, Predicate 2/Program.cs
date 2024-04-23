
namespace Delegate__Action__Function__Predicate_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            exams.Add(new Exam { Subject = "Math", ExamDuration = 3, StartDate = DateTime.Now.AddDays(-5) });
            exams.Add(new Exam { Subject = "English", ExamDuration = 5, StartDate = DateTime.Now.AddDays(-2) });
            exams.Add(new Exam { Subject = "Biology", ExamDuration = 1, StartDate = DateTime.Now.AddHours(-2) });

            Console.WriteLine("son 1hefte erzinde olan examlar");
            var lastWeek = exams.Where(e => (DateTime.Now - e.StartDate).TotalDays <= 7);
            PrintExamList(lastWeek);

            Console.WriteLine("\n2 saatdən uzun çəkən imtahanlar:");
            var longExams = exams.Where(e => e.ExamDuration > 2);
            PrintExamList(longExams);

            Console.WriteLine("\nBaşlayıb amma bitməmiş imtahanlar:");
            var goingExams = exams.Where(e => e.StartDate <= DateTime.Now && DateTime.Now < e.EndDate);
            PrintExamList(goingExams);
        }

        static void PrintExamList(IEnumerable<Exam> examList)
        {
            foreach (var exam in examList)
            {
                Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration} hours");
            }
        }
    }
}
