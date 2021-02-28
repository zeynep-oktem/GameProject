using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string NameOfCampaign { get; set; }
        public decimal RateOfCampaign { get; set; }
    }
}
