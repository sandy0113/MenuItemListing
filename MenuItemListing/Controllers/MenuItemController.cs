using MenuItemListing.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> menuItemList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Pencil",freeDelivery=true,Price=10, dateOfLaunch=new DateTime(2022,06,13), Active=true},
                new MenuItem() {Id=2, Name="Pen",freeDelivery=true,Price=2, dateOfLaunch=new DateTime(2022,06,13), Active=true},
                new MenuItem() {Id=3, Name="Keyboard",freeDelivery=true,Price=200, dateOfLaunch=new DateTime(2022,06,14), Active=true},
                new MenuItem() {Id=4, Name="Mouse",freeDelivery=true,Price=120, dateOfLaunch=new DateTime(2022,06,14), Active=false},
                new MenuItem() {Id=5, Name="MobilePhone",freeDelivery=true,Price=20000, dateOfLaunch=new DateTime(2022,01,13), Active=true},
            };
            return menuItemList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> queryable = GetItem();
            var items = queryable.SingleOrDefault(m => m.Id == id);
            return items;
        }
    }
}
