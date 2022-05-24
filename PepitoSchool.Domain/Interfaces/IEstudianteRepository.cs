using PepitoSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interfaces
{
    public interface IEstudianteRepository : IRepository<Estudiante>
    {
        Estudiante FindById(int id);
        Estudiante FindByCarnet(string carnet);
        Estudiante Promedy(Estudiante IdEstudiante);


        IEnumerable<Estudiante> FindByLastnames(string lastnames);
        IEnumerable<Estudiante> FindByName(string name);
    }
}
