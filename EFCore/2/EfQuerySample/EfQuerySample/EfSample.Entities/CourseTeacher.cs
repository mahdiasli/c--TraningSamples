﻿namespace EfSample.Entities
{
    public class CourseTeacher
    {
        public int CourseTeacherId { get; set; }

        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }

        public int SortOrder { get; set; }
    }
}