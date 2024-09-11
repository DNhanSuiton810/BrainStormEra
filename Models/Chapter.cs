namespace BrainStormEra.Models
{
    public class Chapter
    {
        public string chapter_id { get; set; }
        public string chapter_name { get; set; }
        public string chapter_description { get; set; }
        public string course_id { get; set; }
        public int chapter_status { get; set; }
        public Chapter() { }

        public Chapter(string chapter_id, string chapter_name, string chapter_description, string course_id, int chapter_status)
        {
            this.chapter_id = chapter_id;
            this.chapter_name = chapter_name;
            this.chapter_description = chapter_description;
            this.course_id = course_id;
            this.chapter_status = chapter_status;
        }
    }
}
