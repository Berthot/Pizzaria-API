using Pizzaria.Domain.Commands.Contracts;

namespace Pizzaria.Domain.Handlers.Contracts
{
    // pode ser T des de que T seja ICommand
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}