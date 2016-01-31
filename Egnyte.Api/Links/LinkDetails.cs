﻿using System;
using System.Collections.Generic;

namespace Egnyte.Api.Links
{
    public class LinkDetails
    {
        public string Path { get; set; }
        
        public LinkType Type { get; set; }
        
        public LinkAccessibility Accessibility { get; set; }
        
        public bool Notify { get; set; }
        
        public bool LinkToCurrent { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public string CreatedBy { get; set; }
        
        public ProtectionType Protection { get; set; }
        
        public List<string> Recipients { get; set; }
        
        public string Url { get; set; }
        
        public string Id { get; set; }
    }
}
