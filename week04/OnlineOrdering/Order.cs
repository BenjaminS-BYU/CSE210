public class Order
{
    private List<Product> _products = new List<Product>();
    private int _shippingCost;

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int ShippingCost(Customer customer)
    {
        if (customer.IsInUSA())
        {
            return _shippingCost = 5;
        }else
        {
            return _shippingCost = 35;
        }
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.DisplayProduct() + "\n";
        }
        return label;
    }

    public string ShippingLabel(Customer customer)
    {
        string label = "Shipping Label:\n";
        label += customer.ShippingInfo() + "\n";
        return label;
    }

}