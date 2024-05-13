using Lab_04._2.Models;
using Lab_04._2.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_04._2.Modes
{
    public interface VADICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<VADCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        VADCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(VADCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(VADCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<VADCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(VADCustomer cus);
    }
}
