using PepitoSchool.Domain.Entities;
using PepitoSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Infraestructure.Repository
{
    public class EFEstudianteContext : IEstudianteRepository
    {
        ISchoolDBContext SchoolDBContext;
        public EFEstudianteContext(ISchoolDBContext schoolDbContext)
        {
            this.SchoolDBContext = schoolDbContext;
        }

        public void Create(Estudiante t)
        {
            try
            {
                SchoolDBContext.Estudiantes.Add(t);
                SchoolDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Asset no puede ser null.");
                }

                Estudiante asset = FindById(t.Id);
                if (asset == null)
                {
                    throw new Exception($"El objeto con id {t.Id} no existe.");
                }

                SchoolDBContext.Estudiantes.Remove(asset);
                int result = SchoolDBContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindByCarnet(string carnet)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(carnet))
                {
                    throw new Exception($"El parametro code {carnet} no tiene el formato correcto.");
                }

                return SchoolDBContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(carnet));
            }
            catch
            {
                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return SchoolDBContext.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Estudiante> FindByLastnames(string lastnames)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lastnames))
                {
                    throw new Exception($"El parametro name '{lastnames}' no tiene el formato correcto.");
                }

                return SchoolDBContext.Estudiantes
                                        .Where(x => x.Apellidos.Equals(lastnames, StringComparison.CurrentCultureIgnoreCase))
                                        .ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Estudiante> FindByName(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception($"El parametro name '{name}' no tiene el formato correcto.");
                }

                return SchoolDBContext.Estudiantes
                                        .Where(x => x.Nombres.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                                        .ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return SchoolDBContext.Estudiantes.ToList();
        }

        public Estudiante Promedy(Estudiante IdEstudiante)
        {
            try
            {
                if (IdEstudiante == null)
                {
                    throw new ArgumentNullException("El Estudiante no puede ser null.");
                }

                Estudiante Estudiante = FindById(IdEstudiante.Id);
                if (Estudiante == null)
                {
                    throw new Exception($"El Estudiante con id {IdEstudiante.Id} no existe.");
                }

               
                

               
                
            }
            catch
            {
                throw;
            }
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto asset no puede ser null.");
                }

                Estudiante Estudiante = FindById(t.Id);
                if (Estudiante == null)
                {
                    throw new Exception($"El objeto asset con id {t.Id} no existe.");
                }

                Estudiante.Nombres = t.Nombres;
                Estudiante.Apellidos = t.Apellidos;
                Estudiante.Carnet = t.Carnet;
                Estudiante.Correo = t.Correo;
                Estudiante.Direccion = t.Direccion;
                Estudiante.Phone = t.Phone;
                Estudiante.Matematica = t.Matematica;
                Estudiante.Programacion = t.Programacion;
                Estudiante.Estadistica = t.Estadistica;
                Estudiante.Contabilidad = t.Contabilidad;

                SchoolDBContext.Estudiantes.Update(Estudiante);
                return SchoolDBContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
