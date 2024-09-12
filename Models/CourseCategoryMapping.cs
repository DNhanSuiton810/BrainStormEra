namespace BrainStormEra.Models
{
    public class CourseCategoryMapping
    {
        public string course_id { get; set; }
        public string course_category_id { get; set; }
        public CourseCategoryMapping() { }
        public CourseCategoryMapping(string course_id, string course_category_id)
        {
            this.course_id = course_id;
            this.course_category_id = course_category_id;
        }
    }
}
