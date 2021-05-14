using hwk12.Models;
using Microsoft.AspNetCore.Mvc;
using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace hwk12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController:ControllerBase
    {
        private readonly OrderSystemContext orderDb;

        public OrdersController(OrderSystemContext orderContext)
        {
            this.orderDb = orderContext;
        }

        //添加订单
        [HttpPost("add")]
        public  ActionResult<Order> PostOrder(Order o)
        {
            try
            {
                var customer = orderDb.DBCustomer.FirstOrDefault(c => c.Name == o.CustomerName);
                if (customer == null)
                {
                    orderDb.DBCustomer.Add(new Customer() { Name = o.CustomerName });
                }
                foreach (var detail in o.OrderDetails)
                {
                    orderDb.DBOrderDetail.Add(detail);
                    var good = new Good(detail.GoodName, detail.GoodPrice);
                    var result = orderDb.DBGood.ToList().FirstOrDefault(g => g.Name == good.Name);
                    if (result == null)
                        orderDb.DBGood.Add(good);
                }
                orderDb.DBOrder.Add(o);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return o;
        }

        //删除订单
        [HttpDelete("delete/{id}")]
        public  ActionResult DeleteOrder(long id)
        {
            try
            {
                var orders = getAll();
                var order = orders.FirstOrDefault(o => o.ID == id);
                if(order!=null)
                {
                    orderDb.DBOrder.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        //修改订单
        [HttpPut("update/{id}")]
        public ActionResult<Order> PutOrder(long id,Order order)
        {
            if(id!=order.ID)
            {
                return BadRequest("Id cannot be modified");
            }
            try
            {
                DeleteOrder(id);
                PostOrder(order);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //查询订单
        public List<Order> getAll()
        {
            var orders = orderDb.DBOrder.ToList();
            foreach (var o in orders)
            {
                List<OrderDetail> ods = orderDb.DBOrderDetail.Where(od => od.OrderId == o.ID).ToList();
            }
            return orders;
        }

        [HttpGet("queryAll")]
        public ActionResult<List<Order>> getOrders()
        {
            var orders = getAll();
            if (orders == null)
                return NotFound();
            return orders;
        }

        //按照id查询
        [HttpGet("queryById")]
        public ActionResult<Order> getOrderById(long id)
        {
            var orders = getAll();
            var order = orders.FirstOrDefault(o => o.ID == id);     
            if (order == null)
                return NotFound();      
            return order;
        }
        //按照商品名称查询订单
        [HttpGet("queryByGoodName")]
        public ActionResult<List<Order>> getOrderByGoodName(string name)
        {
            var orders = getAll();

            orders = orders.Where
                    (o => o.OrderDetails.Any(detail => detail.GoodName == name)).ToList();
            if (orders == null)
                return NotFound();
            return orders;
        }

        //按客户名称查询
        [HttpGet("queryByCustomer")]
        public ActionResult<List<Order>> getOrdersByCustomer(string name)
        {
            var orders = getAll();
            orders = orders.Where(o => o.CustomerName == name).ToList();
            if (orders == null)
                return NotFound();
            return orders;
        }
        //按总额查询
        [HttpGet("queryByTotal")]
        public ActionResult<List<Order>> getOrderByTotalPrice(double price)
        {
            var orders = getAll();
            orders = orders.Where(o => o.TotalPrice >= price).ToList();
            if(orders==null)
            {
                return NotFound();
            }
            return orders;
        }



    }
}
