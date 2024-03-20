namespace TaibStore.BLL.Dto
{
    public class PageProperties
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool FilterByName { get; set; }
        public bool FilterByActivated { get; set; }
        public string OrderBy { get; set; }
    }
}
