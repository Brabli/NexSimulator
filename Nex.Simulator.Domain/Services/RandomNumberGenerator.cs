using Nex.Simulator.Domain.Interfaces;

namespace Nex.Simulator.Domain.Services;

public class RandomNumberGenerator : IRandomNumberGenerator
{
    private readonly Random _rng = new();
    
    public int GetRandomInt(int min, int max) => _rng.Next(min, max + 1);
}
