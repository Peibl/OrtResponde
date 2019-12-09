using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Models
{
    public class Like
    {
        public int Id { get; set; }

        [DisplayName("Usuario")]
        public String UserId { get; set; }

        [DisplayName("Like/Dislike")]
        public Boolean LikeType { get; set; }

        [DisplayName("Fecha")]
        public DateTime LikedDate { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
