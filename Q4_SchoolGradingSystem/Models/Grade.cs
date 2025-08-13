namespace Q4_SchoolGradingSystem.Models
{
    public class Grade
    {
        public string Subject { get; private set; }
        public double Score { get; private set; }

        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
        }

        public override string ToString()
        {
            return Subject + ": " + Score;
        }
    }
}