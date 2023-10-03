using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using React_airlines_RepositoryInterface;
using React_airlines_ServiceInterface;

namespace React_airlines_Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Create(T entity)
        {
            _repository.Insert(entity);
            _repository.Save();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
