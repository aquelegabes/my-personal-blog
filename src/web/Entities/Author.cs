namespace MyPersonalBlog.Entities;

public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;
    
    public string FirstName { 
        get 
        {
            return 
                this.FullName?.Split(' ').FirstOrDefault() ??
                string.Empty;
        }
    }
    public string LastName {
        get {
            return
                this.FullName?.Split(' ').LastOrDefault() ??
                string.Empty;
        }
    }
}