﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public abstract class Pet
    {

        public int Boredom { get; set; }
        public string Species { get; set; }
        public string PetType { get; set; }
        public string Name { get; set; }


        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            
        }
        public abstract void Play();
        public abstract void Tick();
        public abstract void GetStatus();


        public void SetSpecies(string species)
        {
            Species = species;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPetType(string type)
        {
            PetType = type;
        }
        public string GetPetType()
        {
            return PetType;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSpecies()
        {
            return Species;
        }
    }
    

}
