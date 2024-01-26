using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;
public class ExamesDB : IExameCollection
{
   private readonly List<Exame> __exames = new List<Exame>();
   private int _id = 0;   
   public int Create(Exame exame)
   {
        if(__exames.Count > 0)
            _id = __exames.Max(m => m.ExameId);
        exame.ExameId = ++_id;
        __exames.Add(exame);
        return exame.ExameId;
   }
   public void Delete(int id)
   {
        __exames.RemoveAll(m => m.ExameId == id);
   }
   public ICollection<Exame> GetAll()
   {
      return __exames.ToArray();
   }
   public Exame? GetById(int id)
   {
      return __exames.FirstOrDefault(m => m.ExameId == id);
   }
   public void Update(int id, Exame exame)
   {
      var exameDB = __exames.FirstOrDefault(m => m.ExameId == id);
        if(exameDB is not null)
        {
             exameDB.Nome = exame.Nome;
        }
    }
}
