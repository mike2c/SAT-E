using Data.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public abstract class Service
    {
        protected SATContext context;

        public Service(SATContext context)
        {
            this.context = context;
        }
    }
}
