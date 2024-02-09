namespace pi24gui.Helpers
{
    internal class RadarClient
    {
        private readonly HttpClient _client;

        public RadarClient()
        {
            _client ??= new HttpClient();
        }

        private async Task<string> GetAsync(string fullUrl)
        {
            using HttpResponseMessage response = await _client.GetAsync(fullUrl);

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Returns the data from the Index page of the Receiver
        /// </summary>
        /// <param name="feederUrl">
        /// IP or URL in the format of http://{url}
        /// </param>
        /// <returns></returns>
        public async Task<string> GetOverview(string feederUrl)
        {
            return await GetAsync($"{feederUrl}/monitor.json");
        }

        public async Task<string> GetLogs(string feederUrl)
        {
            return await GetAsync($"{feederUrl}/logs.bin");
        }

        public async Task<string> GetFlights(string feederUrl)
        {
            return await GetAsync($"{feederUrl}/flights.json");
        }
    }
}
