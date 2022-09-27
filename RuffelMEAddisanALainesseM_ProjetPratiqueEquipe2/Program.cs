using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

Client client1 = new Client(1, "Maxime", "555-5555");
Client client2 = new Client(3, "John", "555-5555");
Client client3 = new Client(2, "Bob", "555-5555");

SortedSet<Client> clients = new SortedSet<Client>(new Client.CompareNoClient());

clients.Add(client1);
clients.Add(client2);
clients.Add(client3);

foreach (var client in clients)
{
    Console.Out.WriteLine(client.NoClient);
}




 