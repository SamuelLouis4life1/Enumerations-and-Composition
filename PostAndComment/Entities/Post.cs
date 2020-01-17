using System;
using System.Collections.Generic;
using System.Text;

namespace PostAndComment.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Like);
            stringBuilder.Append(" Likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Comments:");
            foreach (Comment comment in Comments)
            {
                stringBuilder.AppendLine(comment.Text);
            }
            return stringBuilder.ToString();
        }
    }
}
