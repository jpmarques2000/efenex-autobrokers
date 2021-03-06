﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex.controller
{
    // Strategy 
    interface IBaseController
    {
        public List<Object> Index();

        public bool Create();
        public Object Show(long id);
        public bool Update(long id, Object parametros);

        public bool Delete(long id);

    }
}
