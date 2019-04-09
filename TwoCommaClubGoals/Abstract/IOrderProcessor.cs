﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoCommaClubGoals.Entities;


namespace TwoCommaClubGoals.Abstract
{
    interface IOrderProcessor
    {
        void ProcessOrder(Cart cart);
    }
}
