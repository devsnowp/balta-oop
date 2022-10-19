namespace Balta.ContentContext 
{
    public class Course : Content
    {
        public Course(){
            var Modules = new List<Module>();
        }
        public string? Tag { get; set; }

        public IList<Module> Modules { get; set; }
    }

    public class Module {

        public Module(){
            var Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string? Title { get; set; }
        
        public IList<Lecture>? Lectures { get; set; }
    }

    public class Lecture {
        public int Order { get; set; }

        public string? Title { get; set; }
    }
}
