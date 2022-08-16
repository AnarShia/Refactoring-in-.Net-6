namespace Refactoring.Models.Builder;

public class Builder : IBuilder


{

    private Product _product = new();


    public Builder()
    {
        this.Reset();
    }

    private void Reset()
    {
        this._product= new Product();
    }

    public void BuildA()
    {
        _product.Add("PartA");
    }

    public void BuildB()
    {
        throw new NotImplementedException();
    }

    public void BuildC()
    {
        throw new NotImplementedException();
    } 
}