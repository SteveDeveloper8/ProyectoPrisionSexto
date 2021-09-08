using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class DatosCursoCurricular
    {
        public void InsertarEstudio(ActividadCurricular curricular)
        {
           
        }

        public void EliminarEstudio(string estudioDelete, string modalidad)
        {
            
        }

        public List<Object> BuscarDescripcionEstudio(string descripcion)
        {
            //aqui haz el procedimeinto almacenado con LIKE para que busque por las primeras letras que vaya ingresando el usuario.
            return null;
        }

        public List<Object> ConsultarCursosDistancia()
        {
            List<Object> cursos = new List<Object>();
            ActividadCurricular curricular = new ActividadCurricular(50, "Matematicas","Distancia", 50, Convert.ToDateTime("2019/08/05"), Convert.ToDateTime("2019/10/05"));
            cursos.Add(curricular);
            return cursos;
        }

        public List<Object> BuscarModalidadEstudio(string modalidad)
        {
            List<Object> cursos = new List<Object>();
            ActividadCurricular curricular = new ActividadCurricular(50, "Matematicas", "Distancia", 50, Convert.ToDateTime("2019/08/05"), Convert.ToDateTime("2019/10/05"));
            ActividadCurricular curricular2 = new ActividadCurricular(50, "Fisica", "Presencial", 50, Convert.ToDateTime("2019/08/05"), Convert.ToDateTime("2019/10/05"));
            cursos.Add(curricular);
            cursos.Add(curricular2);
            return cursos;
        }

        public List<object> BuscarDescripcionModalidadEstudio(string descripcion, string modalidad)
        {
            List<Object> cursos = new List<Object>();
            ActividadCurricular curricular = new ActividadCurricular(50, "Matematicas", "Distancia", 50, Convert.ToDateTime("2019/08/05"), Convert.ToDateTime("2019/10/05"));
            cursos.Add(curricular);
            return cursos;
        }
    }
}
