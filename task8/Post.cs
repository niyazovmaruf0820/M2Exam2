namespace task8;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public List<string> Comments { get; set; } = new List<string>();
    public bool IsPublished { get; set; }
    public void Publish()
    {
        IsPublished = true;
        System.Console.WriteLine($"The post - <<{Title}>> is published.");
    }
    public void Like()
    {
        LikeCount++;
    }
    public void Comment(string message)
    {
        Comments.Add(message);
    }
    public string IsPublishedOrNo()
    {
        if (IsPublished == true)
        return "Is already published";
        else return "Isn't published yet";
    }
}
