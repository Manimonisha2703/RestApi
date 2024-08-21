namespace RestApi.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public Product Product { get; set; }
    }
}
