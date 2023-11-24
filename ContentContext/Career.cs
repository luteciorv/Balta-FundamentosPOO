using Blazor.ContentContext;

namespace Balta.ContentContext;

public class Career : Content
{
    public Career()
    {   
        Items = new List<CarrerItem>();
    }

    public int TotalCourses => Items.Count;
    public IList<CarrerItem> Items { get; set; }
}
