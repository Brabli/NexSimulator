namespace Nex.Simulator.Domain.Models;

public record TorvaFullHelmet : NexUnique
{
    public override string Name => "Torva Full Helm";
    public override decimal DropRate { get; } = new decimal(2) / new decimal(12);
}
