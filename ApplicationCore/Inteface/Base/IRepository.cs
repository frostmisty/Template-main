﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface.Base
{
    public interface IRepository <T> : IRepositoryBase <T> where T : class
    {

    }
}
