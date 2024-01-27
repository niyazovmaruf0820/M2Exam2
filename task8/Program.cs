using task8;

List<Post> posts = new List<Post>();

Post post1 = new Post();
post1.Title = "Softclub";
post1.Description = "Is a good education centre";
post1.Like();
post1.Like();
post1.Like();
post1.Publish();
post1.Comment("Nice post");

Post post2 = new Post();
post2.Title = "To school";
post2.Description = "You child's marks aren't good , please take sure of him";
post2.Like();
post2.Like();
post2.Like();
post2.Like();
post2.Comment("Thank you for information");
post2.Comment("Thank you for information lkjsga;kljg");
post2.Comment("Thank you for information lkjsga;kljg");

Post post3 = new Post();
post3.Title = "To softclub";
post3.Description = "Is a good education centre";
post3.Like();
post3.Like();
post3.Like();
post3.Publish();
post3.Comment("Nice post");
post3.Comment("Nice post");
post3.Comment("Nice post");
post3.Comment("Nice post");

Post post4 = new Post();
post4.Title = "To softclub";
post4.Description = "Is a good education centre";
post4.Like();
post4.Like();
post4.Like();
post4.Publish();
post4.Comment("Nice post");
post4.Comment("Nice post");

Post post5 = new Post();
post5.Title = "To softclub";
post5.Description = "Is a good education centre";
post5.Like();
post5.Like();
post5.Like();
post5.Comment("Nice post");
post5.Comment("jl;asdkjg");

posts.Add(post1);
posts.Add(post2);
posts.Add(post3);
posts.Add(post4);
posts.Add(post5);

foreach (var item in posts)
{
    System.Console.WriteLine("Title: " + item.Title);
    System.Console.WriteLine("Description: " + item.Description);
    System.Console.WriteLine("Likes: " + item.LikeCount);
    System.Console.WriteLine("--Comments:");
    foreach (var comment in item.Comments)
    {
        System.Console.WriteLine(">> " + comment);
    }
    System.Console.WriteLine(item.IsPublishedOrNo());
    System.Console.WriteLine();
    System.Console.WriteLine("-----------------------------------------------");
    System.Console.WriteLine();
}