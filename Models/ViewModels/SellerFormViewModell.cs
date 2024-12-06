namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModell
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
