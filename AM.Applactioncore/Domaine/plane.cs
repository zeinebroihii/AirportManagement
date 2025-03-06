﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Applactioncore.Domaine

{   public enum planeType
    {
        Boing,
        Airbus,

    }
    public class Plane


    {
        public int PlaneId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive integer.")]
        public int  Capacity {  get; set; }
        public DateTime ManufactureDate {  get; set; }
        public planeType planeType{  get; set; }
        public ICollection<Flight>flights{ get; set; }

        public override string? ToString()
        {
            return "Capacity"+Capacity+"Date"+ManufactureDate;
        }

        public Plane()
        {
        }

        public Plane(int capacity, DateTime manufactureDate, planeType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            this.planeType = planeType;
        }
    }
}
