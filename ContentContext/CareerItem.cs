using Balta.ContentContext;

namespace Blazor.ContentContext;

public class CarrerItem
{
    public CarrerItem(int order, string title, string description, Course course)
    {
        if (course is null) throw new Exception("O curso não pode ser nulo");

        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
}