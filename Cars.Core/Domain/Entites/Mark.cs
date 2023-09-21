﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Core.Domain.Entites
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Model { get; set; }

        public List<Car> Cars { get; set; }
    }
}
