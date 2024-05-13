using Lab_04._2.Modes;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04._2.Models
{
    public class VADCustomerRepository : VADICustomerRepository
    {
        static readonly List<VADCustomer> data = new List<VADCustomer>()
            {
            new VADCustomer(){ CustomerId = "2210900017",
            FullName = "Vũ Anh Dương",Address = "Hà Nội",
            Email = "vuanhduong251020042@gmail.com",
            Phone = "0972471680",Balance = 15200000},
            new VADCustomer(){ CustomerId = "KH002",
            FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
            Email = "cucdt@gmail.com",Phone = "0986.767.444",
            Balance = 2200000},
            new VADCustomer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
            Email = "thangnt@gmail.com",Phone = "0924.656.542",
            Balance = 1200000},
            new VADCustomer(){ CustomerId = "KH004",
            FullName = "Lê Ngọc Hải",Address = "Hà Nội",
            Email = "hailn@gmail.com",Phone = "0996.555.267",
            Balance = 6200000}
            };
        public IList<VADCustomer> GetCustomers()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<VADCustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public VADCustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        public void AddCustomer(VADCustomer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void UpdateCustomer(VADCustomer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        //thực thi phương thức xóa khách hàng
        public void DeleteCustomer(VADCustomer cus)
        {
            data.Remove(cus);
        }
    }
}
