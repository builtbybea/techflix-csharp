using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechFlixApi.Models.Metadata;
using TechFlixApi.Models.Response;

namespace TechFlixApi
{
    
    public class CacheServices
    {
        
        Dictionary<int, FilmMetadata> cache = new Dictionary<int, FilmMetadata>();
        
        public FilmMetadata GetData(int id)
        {

            return cache[id];
            //create a dictionary that stores responses
            //add responses to dictionary 
            //check if responses in dictionary 
            //if response exist in dictionary return response
            //else make call to API and add response to dictionary 

        }

        public void addNewData(int id, FilmMetadata film)
        {
            cache.Add(id, film);
        }

        public bool isDataInCache(int id)
        {
            if (cache.ContainsKey(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}