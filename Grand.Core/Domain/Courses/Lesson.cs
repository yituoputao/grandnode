﻿namespace Grand.Core.Domain.Courses
{
    public class Lesson : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the course ident
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// Gets or sets the subject ident
        /// </summary>
        public string SubjectId { get; set; }

        /// <summary>
        /// Gets or sets the video file 
        /// </summary>
        public string VideoFile { get; set; }

        /// <summary>
        /// Gets or sets the attachment ident
        /// </summary>
        public string AttachmentId { get; set; }

        /// <summary>
        /// Gets or sets the picture
        /// </summary>
        public string PictureId { get; set; }

    }
}