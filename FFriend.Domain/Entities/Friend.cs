﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFriend.Domain.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string FriendType { get; set; }
    }
}
