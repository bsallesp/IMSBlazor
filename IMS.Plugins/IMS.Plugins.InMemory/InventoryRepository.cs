using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
	public class InventoryRepository : IInventoryRepository
	{
		private List<Inventory> _inventories;

		public InventoryRepository()
		{
			_inventories = new List<Inventory>()
			{
				new Inventory { InventoryID = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2 },
				new Inventory { InventoryID = 1, InventoryName = "Bike Body", Quantity = 20, Price = 15 },
				new Inventory { InventoryID = 1, InventoryName = "Abajour", Quantity = 50, Price = 111 },
				new Inventory { InventoryID = 1, InventoryName = "Bike Abajour", Quantity = 10, Price = 9 },
				new Inventory { InventoryID = 1, InventoryName = "Abajour Seat", Quantity = 3, Price = 6 },
				new Inventory { InventoryID = 1, InventoryName = "Bike Moto", Quantity = 10, Price = 8 }
			};
		}

		public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

			return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
		}
	}
}