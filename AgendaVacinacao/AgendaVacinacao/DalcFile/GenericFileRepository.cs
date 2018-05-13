using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using AgendaVacinacao.Dalc;

namespace AgendaVacinacao.DalcFile
{
    public class GenericFileRepository<T, KeyType> : IGenericRepository<T, KeyType> where T : IGenericDBEntity<KeyType> where KeyType : IComparable
    {
        string _filename;
        public GenericFileRepository(string filename)
        {
            _filename = filename;
        }

        public T GetEntity(KeyType key)
        {
            var usercollection = GetAllEntities(_filename);
            return usercollection.FirstOrDefault(t => t.Key.Equals(key));
        }


        public void SaveEntity(T entity)
        {
            List<T> entities;
            if (DependencyService.Get<IFile>().FileExists(_filename))
            {
                entities = GetAllEntities(_filename).ToList();
                var oldEntity = entities.FirstOrDefault(t => t.Key.Equals(entity.Key));
                if (oldEntity != null)
                    entities.Remove(oldEntity);
            }
            else
                entities = new List<T>();

            entities.Add(entity);
            SaveAllEntities(entities, _filename);
        }
        public void SaveAllEntities(IEnumerable<T> entities)
        {
            SaveAllEntities(entities, _filename);
        }


        private void SaveAllEntities(IEnumerable<T> entities, string filename)
        {
            string serializedEntities = JsonConvert.SerializeObject(entities);
            DependencyService.Get<IFile>().SaveText(filename, serializedEntities);
        }

        public IEnumerable<T> GetAllEntities()
        {
            return GetAllEntities(_filename);
        }

        private IEnumerable<T> GetAllEntities(string filename)
        {
            var savedJason = DependencyService.Get<IFile>().LoadText(filename);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(savedJason);
        }

        //public delegate bool Compare<V>(V value1, V value2);

        public IEnumerable<T> GetEntities(Func<T, bool> predicate)
        {
            var entities = GetAllEntities();
            return entities.Where(predicate);
        }

    }
}
