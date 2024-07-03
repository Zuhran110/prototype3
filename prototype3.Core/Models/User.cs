﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype3.Core.Models;

public class User
{
    public int Id
    {
        get; set;
    }

    public string Name
    {
        get; set;
    }

    public string Password
    {
        get; set;
    }

    public string Role
    {
        get; set;
    }
}