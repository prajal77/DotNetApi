﻿namespace DotNetApi.Data
{
    public class UserRepository
    {
        DataContextEf _entityFramework;

        public UserRepository(IConfiguration config)
        {
            _entityFramework = new DataContextEf(config);
        }

        public bool SaveChanges()
        {
            return _entityFramework.SaveChanges()>0;
        }

        public void AddEntity<T>(T entityToAdd)
        {
            if(entityToAdd != null)
            {
                _entityFramework.Add(entityToAdd);
            }
        }
        public void RemoveEntity<T>(T entityToRemove)
        {
            if (entityToRemove != null)
            {
                _entityFramework.Remove(entityToRemove);
            }
        }
    }
}