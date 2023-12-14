﻿namespace eBEST.OpenApi.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PathAttribute(string path) : Attribute
    {
        public string Path { get; } = path;
        public string TRName { get; set; } = string.Empty;
    }
}