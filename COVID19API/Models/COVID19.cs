using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;





namespace COVID19API.Models
{
    public class COVID19
    {


        public int Id { get; set; }

        public DateTime LastReleaseDate { get; set; }

        public double MortalityRate { get; set; }

        public double Population { get; set; }

        public string Strategy { get; set; }

        public string CityName { get; set; }
    }
}
