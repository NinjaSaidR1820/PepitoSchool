using System;
using System.Collections.Generic;

#nullable disable

namespace PepitoSchool.Domain.Entities
{
    public partial class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Phone { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int Matematica { get; set; }
        public int Contabilidad { get; set; }
        public int Programacion { get; set; }
        public int Estadistica { get; set; }
    }
}
