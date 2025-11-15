public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string ShippingInfo()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }

    public bool IsInUSA()
    {
        if (_address.Country() == "USA" || _address.Country() == "United States" || _address.Country() == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}