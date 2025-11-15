public class Product
{
    private string _name;
    private decimal _price;
    private string _productId;
    private int _quantity;


    public Product(string name, decimal price, string productId, int quantity)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = quantity;
    }

    public string DisplayProduct()
    {
        return $"{_name} (ID: {_productId}) - Price: ${_price} - Quantity: {_quantity}";
    }

    public int TotalPrice()
    {
        return (int)(_price * _quantity);
    }

}