using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IEditInventoryUsecase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}