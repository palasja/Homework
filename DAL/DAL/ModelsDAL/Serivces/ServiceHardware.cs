﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelsDAL.Serivces
{
    public class ServiceHardware : IService
    {
        public int Id { get; set; }
        [DefaultValue(0)]
        public int ServerCount { get; set; }
        [Required]
        public int WorkplaceCount { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public int ServiceInfoId { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
    }
}
