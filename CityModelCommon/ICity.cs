﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityModelCommon
{
    public interface ICity
    {
        int Id { get; set; }

        string Naziv { get; set; }
    }
}
