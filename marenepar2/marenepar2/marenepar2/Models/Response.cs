﻿using System;
using System.Collections.Generic;
using System.Text;

namespace marenepar2.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
