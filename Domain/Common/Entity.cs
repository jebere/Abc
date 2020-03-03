﻿using Abc.Data.Common;

namespace Abc.Domain
{
    public abstract class Entity<T> where T: PeriodData
    {
        public T Data { get;  }

        protected Entity(T data)
        {
            Data = data;
        }
    }
}