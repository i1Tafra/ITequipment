using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ITequipment.Models
{

	public enum Condition
	{
		Excelent,
		Good,
		Satisfactory,
		Poor,
		Broken
	}
	
    public class Hardware
    {
        public int HardwareId { get; set; }
        public string Serial { get; set; }
		public string Name { get; set; }
        public string Purpose { get; set; }
		public string Specs { get; set; }		
		public string AdditionalInfo { get; set; }
		public DateTime AcquiredDate { get; set; }
		public Condition Condition { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
		
		public int RoomId { get; set; }
        public Room Room { get; set; }
		
		public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public ICollection<HW_SW> HW_SWs { get; set; }
    }
}