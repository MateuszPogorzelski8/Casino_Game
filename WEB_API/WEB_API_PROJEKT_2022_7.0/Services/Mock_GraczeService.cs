using Microsoft.AspNetCore.Mvc;
using WEB_API_PROJEKT_2022_7._0.Models;

namespace WEB_API_PROJEKT_2022_7._0.Services
{
    // Used only for Mock Service
    public class Mock_GraczeService : IGraczeService
    {

        List<Gracze> _graczeList;

        public Mock_GraczeService()
        {
            _graczeList = new List<Gracze>
            {
                new Gracze{Id=1, Name="Mateusz",Haslo="123",Cash=320},
                new Gracze{Id=2, Name="Bartek",Haslo ="234",Cash=1900},
                new Gracze{Id=3, Name="Wiktor",Haslo="345",Cash=85}
            };
            }
        


        public void Add(Gracze gracz)
        {
            lock (this)
            {
                int automatyczne_id = _graczeList.Max(x => x.Id) + 1;
                gracz.Id = automatyczne_id;
                _graczeList.Add(gracz);
            }
        }

        public void Delete(int id)
        {
            _graczeList.RemoveAll(x => x.Id == id);
        }

        public Gracze GetGracz(int id)
        {
           return  _graczeList.FirstOrDefault(x => x.Id == id)!;
        }

        public Gracze[] GetGraczes()
        {
            return _graczeList.ToArray();  
        }

        public Gracze[] GetGraczes_by_name(string name)
        {
            return _graczeList.Where(x=>x.Name == name).ToArray();
        }

        public void Update(Gracze gracz)
        {
            var update = _graczeList.FirstOrDefault(x => x.Id == gracz.Id);
            if (update != null)
            {
                update.Name=gracz.Name;
                update.Cash=gracz.Cash;
                update.Haslo=gracz.Haslo;

            }
        }
        
        
        public void Ban(Gracze gracz)
        {
            var update = _graczeList.FirstOrDefault(x => x.Id == gracz.Id);
            if (update != null)
            {
                foreach(var item in _graczeList)
                {
                    if (update.Id == item.Id)
                    {
                        if (item.Name.Contains("[BAN]")){
                            string newstr = item.Name.Remove(0, 5);
                            update.Name = newstr;
                        }
                        else
                        {
                            update.Name = "[BAN]" + item.Name;
                        }
                        
                        
                    }; 
                }
                
             

            }
        }

       
    }
}
