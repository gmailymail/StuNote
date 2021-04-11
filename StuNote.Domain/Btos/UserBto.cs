using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuNote.Domain.Btos
{
    public record UserBto : BtoBase
    {
        /// <summary>
        /// Email address and username is the same
        /// </summary>
        public string Username { get; set; }

    }
}
