using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrainStormEra.Models
{
    public class Lesson
    {
        [Key]
        public string lesson_id { get; set; }
        public string lesson_name { get; set; }
        public string lesson_description { get; set; }
        [ForeignKey("Chapter")]
        public string chapter_id { get; set; }
        public int lesson_status { get; set; }
        public int lesson_type { get; set; }
        public string? lesson_content { get; set; }
        public Lesson() { }

        public Lesson(string lesson_id, string lesson_name, string lesson_description, string chapter_id, int lesson_status, int lesson_type, string lesson_content)
        {
            this.lesson_id = lesson_id;
            this.lesson_name = lesson_name;
            this.lesson_description = lesson_description;
            this.chapter_id = chapter_id;
            this.lesson_status = lesson_status;
            this.lesson_type = lesson_type;
            this.lesson_content = lesson_content;
        }

    }
}
