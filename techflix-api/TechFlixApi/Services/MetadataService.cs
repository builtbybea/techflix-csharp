using System;
using RestSharp;
using TechFlixApi.Models.Metadata;

namespace TechFlixApi.Services
{
    public interface IMetadataService
    {
        FilmMetadata GetFilm(int id);
        PersonMetadata GetPerson(int id);
    }

    public class MyClass
    {
        public string Name { get; }
        public string Id { get;  }

        public MyClass(string name)
        {
            Name = name;
            Id = "abcd1234";
        }
    }

    public class MyOtherClass
    {
        public void DoAThing()
        {
            var myClass = new MyClass("My Name");
        }
    }
    
    
    public class MetadataService : IMetadataService
    {
        private readonly RestClient _client;
        private readonly CacheServices _cache;

        public MetadataService()
        {
            _client = new RestClient(Environment.GetEnvironmentVariable("URL_INTERNAL_METADATA"));
            _cache = new CacheServices();
        }

        public FilmMetadata GetFilm(int id)
        {
            // if cache knows the answer for my id
            // return that answer
            
            // otherwise
            // work out the answer via http request
            // add that answer to the cache
            // return the answer
            
            
            if (_cache.isDataInCache(id))
            {
                return _cache.GetData(id);
            }
            else
            {
                var request = new RestRequest($"/films/{id}"); 
                var metadata =  _client.Get<FilmMetadata>(request).Data;
                _cache.addNewData(id, metadata);
                return metadata;
            }
        }

        public PersonMetadata GetPerson(int id)
        {
            var request = new RestRequest($"/people/{id}");
            return _client.Get<PersonMetadata>(request).Data;
        }
        
    }
    
}