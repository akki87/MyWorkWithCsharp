using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class DiningSet
    {
        public DiningSet()
        {
        }
        public DiningSet(int chairCount, int sectionId, bool? status)
        {
            //DiningSetId = diningSetId;
            ChairCount = chairCount;
            SectionId = sectionId;
            Status = status;
        }
        [Key]
        public int DiningSetId { get; set; }
        public int ChairCount { get; set; }
        public int SectionId { get; set; }
        public bool? Status { get; set; }


        
      
    }
}
