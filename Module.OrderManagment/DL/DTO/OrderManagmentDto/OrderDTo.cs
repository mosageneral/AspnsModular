﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.DTO.OrderManagmentDto
{
    internal class OrderDTo
    {
        public List<OrderItemDTO> Products { get; set; }
        public Guid BuyerId { get; set; }
    }
}
