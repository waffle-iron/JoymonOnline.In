﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joymononline
{
    public interface IProjectDataProvider
    {
        IEnumerable<Project> GetProjects();
    }
}