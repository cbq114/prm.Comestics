﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation
        public ICollection<User> Users { get; set; }
    }

}
