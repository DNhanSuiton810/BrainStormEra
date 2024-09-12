namespace BrainStormEra.Models
{
    public class CourseCategory
    {
        public string course_category_id { get; set; }
        
        public string course_category_name { get; set; }

        public CourseCategory() { }
        public CourseCategory(string course_category_id, string course_id)
        {
            this.course_category_id = course_category_id;
            this.course_category_name = course_category_name;
        }
    }
}
