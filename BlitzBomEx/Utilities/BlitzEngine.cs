using System.Net.NetworkInformation;
using System.Text.Json;

namespace BlitzBomEx.Utilities;

public class BlitzEngine
{
    private readonly HttpClient _httpClient = new HttpClient();
    // public async Task<DateTime> TimeNowAsync()
    // {
    //     string apiKey = "13cb9c000a264aa4bed79babd45abb3b";
    //     string location = "Manila, Philippines";
    //     string url = $"https://timezone.abstractapi.com/v1/current_time/?api_key={apiKey}&location={Uri.EscapeDataString(location)}";
    //     using (HttpClient client = new HttpClient())
    //     {
    //         try
    //         {
    //             
    //             HttpResponseMessage response = await client.GetAsync(url);
    //             response.EnsureSuccessStatusCode();
    //             string json = await response.Content.ReadAsStringAsync();
    //             using (JsonDocument doc = JsonDocument.Parse(json))
    //             {
    //                 JsonElement root = doc.RootElement;
    //                 DateTime datetime = root.GetProperty("datetime").GetDateTime();
    //                 return datetime;
    //             }
    //         }
    //         catch (Exception ex)
    //         {
    //             throw;
    //         }
    //     }
    // }

    public async Task<DateTime?> TimeNowAsync()
    {
        string apiKey = "13cb9c000a264aa4bed79babd45abb3b";
        string location = "Manila, Philippines";
        string url = $"https://timezone.abstractapi.com/v1/current_time/?api_key={apiKey}&location={Uri.EscapeDataString(location)}";

        HttpResponseMessage response = await _httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode) return null;

        string json = await response.Content.ReadAsStringAsync();
        using JsonDocument doc = JsonDocument.Parse(json);

        if (doc.RootElement.TryGetProperty("datetime", out JsonElement datetimeElement))
        {
            return datetimeElement.GetDateTime();
        }

        return null;
    }

    
    public string GetMacAdd()
    {
        foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                PhysicalAddress address = nic.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                return string.Join(":", bytes.Select(b=>b.ToString("X2")));
            }
        }
        return string.Empty;
    }
}