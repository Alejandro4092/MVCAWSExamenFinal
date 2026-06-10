using System.Net.Http.Json;
using MVCAWSExamenFinal.Models;

namespace MVCAWSExamenFinal.Services
{
    public class ServiceEventos
    {
        private HttpClient client;

        public ServiceEventos(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            // 'Eventos' con E mayúscula, 'categorias' en minúscula
            List<Categoria> categorias = await this.client.GetFromJsonAsync<List<Categoria>>("api/Eventos/categorias") ?? [];
            return categorias;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            // 'Eventos' con E mayúscula, 'eventos' en minúscula
            List<Evento> eventos = await this.client.GetFromJsonAsync<List<Evento>>("api/Eventos/eventos") ?? [];
            return eventos;
        }

        public async Task<List<Evento>> GetEventosCategoriaAsync(int idCategoria)
        {
            // 'Eventos' con E mayúscula, 'eventoscategoria' en minúscula
            List<Evento> eventos = await this.client.GetFromJsonAsync<List<Evento>>($"api/Eventos/eventoscategoria/{idCategoria}") ?? [];
            return eventos;
        }
    }
}