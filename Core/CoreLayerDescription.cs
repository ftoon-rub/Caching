namespace Core
{
    public class CoreLayerDescription : ILayerDescription
    {
        public void LayerDescription()
        {
            //Core Layer(Domain):
            //Entities: Core business models, which contain the main business logic and rules.
            //Interfaces: Abstractions for repositories, services, or any other dependencies. These interfaces should have no dependencies on any other layers.
            //Domain Services: Business logic that doesn't naturally fit into a single entity but still belongs to the domain layer.
            throw new NotImplementedException();
        }
    }
}
