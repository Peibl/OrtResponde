using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
