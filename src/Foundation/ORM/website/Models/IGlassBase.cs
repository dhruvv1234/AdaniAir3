﻿using System;
using System.Collections;
using Sitecore.Globalization;

namespace AdaniAir.Foundation.ORM.Models
{
    public interface IGlassBase
    {
        Guid Id { get; set; }
        Language Language { get; set; }
        int Version { get; set; }
        IEnumerable BaseTemplateIds { get; set; }
        string TemplateName { get; set; }
        Guid TemplateId { get; set; }
        string Name { get; set; }
    }
}
