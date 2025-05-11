using Xunit;
using Microsoft.EntityFrameworkCore;
using InventoryApi.Controllers;
using InventoryApi.Data;
using InventoryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace InventoryApi.Tests
{
    public class ItemsControllerTests
    {
        private InventoryContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<InventoryContext>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .Options;
            return new InventoryContext(options);
        }

        [Fact]
        public async Task GetItems_ReturnsEmptyList_WhenNoItems()
        {
            using var context = GetInMemoryDbContext();
            var controller = new ItemsController(context);
            var result = await controller.GetItems();
            var items = Assert.IsType<List<Item>>(result.Value);
            Assert.Empty(items);
        }

        [Fact]
        public async Task CreateItem_ReturnsCreatedItem()
        {
            using var context = GetInMemoryDbContext();
            var controller = new ItemsController(context);
            var item = new Item
            {
                Name = "Battery Pack",
                Quantity = 10,
                Location = "Warehouse A"
            };
            var result = await controller.CreateItem(item);
            var createdResult = Assert.IsType<CreatedAtActionResult>(result);
            var createdItem = Assert.IsType<Item>(createdResult.Value);
            Assert.Equal("Battery Pack", createdItem.Name);
        }

        [Fact]
        public async Task DeleteItem_ReturnsNotFound_WhenItemDoesNotExist()
        {
            using var context = GetInMemoryDbContext();
            var controller = new ItemsController(context);
            var result = await controller.DeleteItem(1);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}