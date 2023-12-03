using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Services.Mock;
public class ClientAdoptionService : IClientAdoptionService
{
    private IList<ClientAdoption> _clientAdoptions = new List<ClientAdoption>();

    public ClientAdoptionService() { }

    public IList<ClientAdoption> AllClients() => _clientAdoptions;

    public ClientAdoption GetClient(int idClient) => AllClients().SingleOrDefault(client => client.ClientId == idClient);

    public void SetCliente(ClientAdoption client)
    {
        int nextId = _clientAdoptions.Count > 0 ? _clientAdoptions.Max(client => client.ClientId) : 0;
        client.ClientId = nextId + 1;
        _clientAdoptions.Add(client);
    }
}
