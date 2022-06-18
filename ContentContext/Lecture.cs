using Fundamentos.ContentContext.Enums;
using Fundamentos.SharedContext;

namespace Fundamentos.ContentContext;

public class Lecture : Base
{
    public int Order { get; set; }
    public string? Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}