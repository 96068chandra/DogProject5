using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogProject5.Models
{
    public class DogStore
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Description { get; set; }

        public int Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public Breed Breed { get; set; }
        //foriegn key
        public int BreedId { get; set; }
    }

    //public class AddDogViewModel
    //{
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int Height { get; set; }
    //    public double Weight { get; set; }
    //    public int Age { get; set; }
    //    public int Price { get; set; }
    //    public int BreedId { get; set; }
    //    public List<Breed> Breed { get; set;}

    //}

    //public class PetBreedMapping
    //{

    //    public int Id { get; set; }
    //    public DogStore dogStore { get; set; }
    //    public int dogId { get; set; }
    //    public Breed breed { get; set; }
    //    public int breedId { get; set; }
    //}


}