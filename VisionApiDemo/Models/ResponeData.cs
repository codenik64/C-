﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionApiDemo.Models
{
    public class Detail
    {
        public List<object> celebrities { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public double score { get; set; }
        public Detail detail { get; set; }
    }

    public class Caption
    {
        public string text { get; set; }
        public double confidence { get; set; }
    }

    public class Description
    {
        public List<string> tags { get; set; }
        public List<Caption> captions { get; set; }
    }

    public class Color
    {
        public string dominantColorForeground { get; set; }
        public string dominantColorBackground { get; set; }
        public List<string> dominantColors { get; set; }
        public string accentColor { get; set; }
        public bool isBwImg { get; set; }
    }

    public class Metadata
    {
        public int height { get; set; }
        public int width { get; set; }
        public string format { get; set; }
    }

    public class ImageInfoViewModel
    {
        public List<Category> categories { get; set; }
        public Description description { get; set; }
        public Color color { get; set; }
        public string requestId { get; set; }
        public Metadata metadata { get; set; }
    }
}
