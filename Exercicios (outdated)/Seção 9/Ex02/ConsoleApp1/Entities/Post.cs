﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Content = content ?? throw new ArgumentNullException(nameof(content));
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
