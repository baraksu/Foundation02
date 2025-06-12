namespace Matkonet2025.Q04
{
    public class Lesson
    {

        public Lesson (string subject, int duration, bool isMandatory)
        {
            this.subject = subject;
            this.duration = duration;
            this.isMandatory = isMandatory;

        }
        private string subject;

        public string GetSubject()
        {
            return this.subject;
        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }

        private int duration;

        public int GetDuration()
        {
            return this.duration;
        }
        public void SetDuration(int duration)
        {
            this.duration = duration;
        }

        private bool isMandatory;

        public bool GetIsMandatory()
        {
            return this.isMandatory;
        }
        public void SetIsMandatory(bool isMandatory)
        {
            this.isMandatory = isMandatory;
        }
        public bool SameDuration(Lesson other)
        {
            return this.duration == other.duration;
        }
        public bool SameSubject(Lesson other)
        {
            return this.subject == other.subject;
        }


    }
}