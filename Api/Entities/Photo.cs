﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sites4u.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public bool IsMain { get; set; }

        public int PublicId { get; set; }
        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }
    }
}
