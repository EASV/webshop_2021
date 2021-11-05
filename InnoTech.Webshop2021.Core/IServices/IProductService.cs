using InnoTech.Webshop2021.Core.Models;

namespace InnoTech.Webshop2021.Core.IServices
{
    public interface IProductService
    {
        FilteredList GetAll();
    }
}