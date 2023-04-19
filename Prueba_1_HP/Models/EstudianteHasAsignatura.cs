using System;
using System.Collections.Generic;

namespace Prueba_1_HP.Models;

public partial class EstudianteHasAsignatura
{
    public int EstudianteId { get; set; }

    public int AsignaturaId { get; set; }

    public int Id { get; set; }

    public virtual Asignatura Asignatura { get; set; } = null!;

    public virtual Estudiante Estudiante { get; set; } = null!;
}
