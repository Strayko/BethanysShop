﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
