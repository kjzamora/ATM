﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Pin { get; set; }
        public int Balance { get; set; }
    }
}
