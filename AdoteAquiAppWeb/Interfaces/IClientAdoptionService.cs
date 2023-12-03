using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Interfaces;

public interface IClientAdoptionService
{
    public IList<ClientAdoption> AllClients();
    public ClientAdoption GetClient(int idClient);
    public void SetCliente(ClientAdoption client);
}
