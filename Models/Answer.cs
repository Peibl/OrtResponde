using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Respuesta { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string UserId { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
