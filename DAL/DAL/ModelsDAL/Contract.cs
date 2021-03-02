using DAL.ModelsDAL.Serivces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelsDAL
{
    class Contract
    {
        public int Id { get; set; }
        public string Number{ get; set; }
        [Required]
        public DateTime SatartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<ServiceSoftware> ServicesSoftware { get; set; }
        public ICollection<ServiceHardware> ServicesHardware { get; set; }
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }
    }
}
