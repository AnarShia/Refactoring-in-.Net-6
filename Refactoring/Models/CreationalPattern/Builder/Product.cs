namespace Refactoring.Models.Builder;

public class Product
{
    private List<Object> productList = new();
    public void Add(string part)
    {
        productList.Add(part);
        
    }
}