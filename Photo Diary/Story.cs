using System;

namespace mim_c_hash_new
{
    public class Story
    {
        public String title;
        public String story;
        public DateTime date;
        public String picturePath;
        public Story(String Title, String Story, DateTime Date, String Path)
        {
            this.title = Title;
            this.story = Story;
            this.date = Date;
            this.picturePath = Path;
        }


    }
}
