using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }

        public State State { get; set; }
        public Animal AnimalType { get; set; }

    }

    public enum State
    {
        FreeForAdoption,
        FreeForSale
    }

    public enum Animal
    {
        Dog,
        Cat,
        Hamster,
        Rabbit
    }

}