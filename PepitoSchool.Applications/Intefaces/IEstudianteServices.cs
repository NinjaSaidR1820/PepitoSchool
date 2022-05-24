using PepitoSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Applications.Intefaces
{
    public interface IEstudianteServices : IServices<Estudiante>
    {
        Estudiante FindById(int id);
        Estudiante FindByCarnet(string carnet);
        Estudiante Promedy(Estudiante IdEstudiante);
        IEnumerable<Estudiante> FindByLastnames(string lastnames);
        IEnumerable<Estudiante> FindByName(string name);
    }
}
