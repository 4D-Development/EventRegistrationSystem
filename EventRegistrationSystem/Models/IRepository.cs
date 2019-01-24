﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistrationSystem.Models
{
    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface IRepository<TEnt, in TPk> where TEnt : class
    {
        IEnumerable<TEnt> Get();
        TEnt Get(TPk id);
        void Add(TEnt entity);
        void Remove(TEnt entity);
    }
}

