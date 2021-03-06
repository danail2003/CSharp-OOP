﻿namespace SpaceStation.Repositories.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using SpaceStation.Models.Planets;

    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly List<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.planets.AsReadOnly();

        public void Add(IPlanet model)
        {
            this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            return this.planets.First(x => x.Name == name);
        }

        public bool Remove(IPlanet model)
        {
            return this.planets.Remove(model);
        }
    }
}
