namespace Rsdo.Concordancer.ServiceModel.Interfaces;

public interface IPagedResponse
{
    int Offset { get; }

    long Total { get; }
}