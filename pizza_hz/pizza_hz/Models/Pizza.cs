﻿namespace pizza_hz.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string nom {  get; set; }
        public float prix { get; set; }
        public bool vegetarienne { get; set; }
        public string ingredients { get; set; }
    }
}