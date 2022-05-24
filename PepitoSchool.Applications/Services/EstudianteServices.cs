using PepitoSchool.Applications.Intefaces;
using PepitoSchool.Domain.Entities;
using PepitoSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Applications.Services
{
    public class EstudianteServices : IEstudianteServices
    {
        IEstudianteRepository estudianteRepository;
        public EstudianteServices(IEstudianteRepository EstudianteRepository)
        {
            this.estudianteRepository = EstudianteRepository;
        }

        public void Create(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Asset no puede ser null.");
            }

            estudianteRepository.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public Estudiante FindByCarnet(string carnet)
        {
            return estudianteRepository.FindByCarnet(carnet);
        }

        public Estudiante FindById(int id)
        {
            return estudianteRepository.FindById(id);
        }

        public IEnumerable<Estudiante> FindByLastnames(string lastnames)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estudiante> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> GetAll()
        {
            return estudianteRepository.GetAll();
        }

        public Estudiante Promedy(Estudiante IdEstudiante)
        {
            throw new NotImplementedException();
        }

        public int Update(Estudiante t)
        {
            throw new NotImplementedException();
        }
    }
}
