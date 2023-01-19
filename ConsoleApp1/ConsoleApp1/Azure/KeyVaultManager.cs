using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

namespace ConsoleApp1.Azure
{
    public class KeyVaultManager
    {
        readonly string tenantId;
        readonly string clientId;
        readonly string clientSecret;
        readonly string kvUri;
        public KeyVaultManager() 
        {
            tenantId = "07377ea2-4656-4388-92c3-da76edd31ef4";
            clientId = "087e8e27-5a2a-40c3-b8a9-73a8fea86ced";
            clientSecret = "n5X8Q~yZoPdTqVZ75nGE6HdNh4zITagLJwMjvdjG";
            kvUri = "https://*****.vault.azure.net";
        }

        public string GetSecret(string SecretName)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new SecretClient(new Uri(kvUri), credential);
            return client.GetSecret(SecretName).Value.Value;
        }

    }
}
