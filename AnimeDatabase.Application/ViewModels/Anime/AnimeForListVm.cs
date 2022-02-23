namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeForListVm 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AnimeTypeId { get; set; }
        public string TypeName { get; set; }
    }
}