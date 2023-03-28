using WEB_API_PROJEKT_2022_7._0.Models;

namespace WEB_API_PROJEKT_2022_7._0.Services
{
    // Used only for Mock Service
    public interface IGraczeService
    {
        
        
            Gracze[] GetGraczes_by_name(string name);

            Gracze[] GetGraczes();

            Gracze GetGracz(int id);

            void Add(Gracze gracz);

            void Update(Gracze gracz);

            void Delete(int id);
            
            void Ban(Gracze gracz);
    }
}
