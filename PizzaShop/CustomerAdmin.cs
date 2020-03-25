using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace PizzaShop
{
    public class CustomerAdmin
    {
        private static List<Customer> customers = new List<Customer>();
        public List<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }

        Customer customer = new Customer();

        public CustomerAdmin() { }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer[] GetCustomers()
        {
            return customers.ToArray();
        }

        public void LoadCustomersFromFile()
        {
            CustomerAdmin customer = new CustomerAdmin();
            customer.Customers.Clear();
            string fileNameCustomers = "CustomersBAK";
            FileStream fs = null;
            BinaryFormatter bf = null;
                        
            try
            {
                fs = new FileStream(fileNameCustomers, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                customer.Customers = (List<Customer>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            string fileNameLastCustomerId = "LastCustomerIdBAK";
            FileStream fs2 = null;
            BinaryFormatter bf2 = null;
            try
            {
                fs2 = new FileStream(fileNameLastCustomerId, FileMode.Open, FileAccess.Read);
                bf2 = new BinaryFormatter();
                Customer.IdSeeder = (int)bf2.Deserialize(fs2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs2 != null)
                {
                    fs2.Close();
                }
            }
        }
        public void SaveCustomersToFile()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            CustomerAdmin customer = new CustomerAdmin();
            string fileNameCustomers = "CustomersBAK";
            try
            {
                fs = new FileStream(fileNameCustomers, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, customer.Customers);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            FileStream fs2 = null;
            BinaryFormatter bf2 = null;
            string fileNameLastCustomerId = "LastCustomerIdBAK";
            try
            {
                fs2 = new FileStream(fileNameLastCustomerId, FileMode.OpenOrCreate, FileAccess.Write);
                bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, Customer.IdSeeder);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs2 != null)
                {
                    fs2.Close();
                }
            }
        }
    }
}
