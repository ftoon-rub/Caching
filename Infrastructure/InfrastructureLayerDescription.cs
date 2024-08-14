using Core;

namespace Infrastructure
{
    public class InfrastructureLayerDescription : ILayerDescription
    {
        public void LayerDescription()
        {
            //Infrastructure Layer:
            //Repositories: Concrete implementations of the interfaces defined in the Core layer.
            //Data Access: Database context, ORM models, and database migrations typically reside here.
            //External Services: Implementations for third-party services or APIs.
            throw new NotImplementedException();
        }
    }
}
