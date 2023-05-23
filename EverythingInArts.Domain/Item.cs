﻿namespace EverythingInArts.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public List<string> Images { get; set; } = new List<string>();

    }
}