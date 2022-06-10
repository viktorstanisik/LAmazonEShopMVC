﻿using Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lamazon.DataAccess.Interfaces
{
    public interface IUserRepository 
    {
        User GetByUsername(string username);
        User GetById(string id);
    }
}
