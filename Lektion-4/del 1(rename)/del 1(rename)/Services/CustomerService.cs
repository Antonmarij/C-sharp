using del_1_rename_.Models;

namespace del_1_rename_.Services;

internal class CustomerService
{
    //fields
    private List<Customer> _customerList;



    //service = 90% Methods
    //Methods(propertyName)

    public void CreateCustomer(Customer customer)
    {
        if (!_customerList.Contains(customer)) 
            _customerList.Add(customer);
    }
    public void DeleteCustomer() { }
    public void UpdateCustomer(Customer customer) { }
    
    public List<Customer> GetCustomers()
    {
        return _customerList;
    }
}
