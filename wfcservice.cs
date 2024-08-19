using System;
using System.ServiceModel;

[ServiceContract]
public interface ICalculatorService
{
    [OperationContract]
    int Add(int x, int y);

    [OperationContract]
    int Subtract(int x, int y);
}

public class CalculatorService : ICalculatorService
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }
}