
using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Infrastructure.Persistance
{
    abstract class DbContext
    {

        protected IDatabase _database;

        public DbContext(IDatabase database)
        {
            _database = database;
        }

        public abstract void OnModelCreating(ModelBuilder builder);

        public Boolean SaveChanges()
        {
            //TODO сохранение изменений в БД
            return true;
        }
    }

    public class ModelBuilder
    {
        public ModelBuilder ApplyConfiguration(IModelConfiguration<Note> configuration)
        {
            //TODO: добавление конфигурации маппинга объекта некоторого типа к структуре таблицы БД 
            return this;
        }
    }
}
