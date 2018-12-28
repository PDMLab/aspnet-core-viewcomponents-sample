using System.Collections.Generic;

namespace ViewComponentsSample.Models
{
    public class IndexViewModel
    {
        public List<PageSection> Sections { get; set; }
    }

    public class PageSection
    {
        public string Title { get; set; }
        public List<SectionItem> SectionItems { get; set; }
    }

    public class SectionItem
    {
        public string Text { get; set; }
    }
}