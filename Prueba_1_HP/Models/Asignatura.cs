using System;
using System.Collections.Generic;

namespace Prueba_1_HP.Models;

public partial class Asignatura
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Código { get; set; }

    public DateOnly FechaActualizacion { get; set; }

    public virtual ICollection<EstudianteHasAsignatura> EstudianteHasAsignaturas { get; set; } = new List<EstudianteHasAsignatura>();
}
