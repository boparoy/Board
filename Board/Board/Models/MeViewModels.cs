﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Board.Models
{
    // Модели, возвращенные действиями MeController.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}