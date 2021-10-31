﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Moglan_Vlad_Lab2.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int BookCount { get; set; }

    }
}
