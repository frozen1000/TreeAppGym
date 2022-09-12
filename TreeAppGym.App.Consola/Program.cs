using System;
using TreeAppGym.App.Dominio;
using TreeAppGym.App.Persistencia;
using System.Collections.Generic;
//permite leer los namespace
// Este repositorio implementa la interfaz
namespace TreeAppGym.App.Consola
{
    class Program
    {
        private static IRepositorioPlanNutricional _repoPlanNutricional =new RepositorioPlanNutricional(new Persistencia.AppContext());
        //Coloco un objeto que me permite llamar a cada uno de los métodos CRUD
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Gimnasio, estamos probando el CRUD Rutina");
            //AdicionarPlanNutricional();
            //ConsultarPlanNutricional(5);
            //ActualizarPlanNutricional();
            //EliminarPlanNutricional();

            //AdicionarRutina();
            //ConsultarRutina(1);
            //ActualizarRutina();
            EliminarRutina();

        }
        //Clase específica para crear el objeto PlanNutricional
        private static void AdicionarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
                Categoria=Categoria.avanzada,
                Descripcion="Ejemplo Alimentación saludable pro",
                Imagen="url.prueba Creación"
                
            };
            _repoPlanNutricional.CrearPlanNutricional(planNutricional);
            Console.WriteLine("Puede ir al Azure y confirmar la creación");

        }
        //Clase específica para consultar el objeto PlanNutricional
        private static void ConsultarPlanNutricional(int idPlanNutricional)
        {
            var planNutricional = _repoPlanNutricional.ConsultarPlanNutricional(idPlanNutricional);
            Console.WriteLine(planNutricional.Categoria+" "+planNutricional.Descripcion+" "+planNutricional.Imagen);
              
        }
        //Clase específica para eliminar el objeto PlanNutricional
        private static void EliminarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
             
            }; 
           _repoPlanNutricional.EliminarPlanNutricional(5); 
               
        }
        //Clase específica para actualizar el objeto PlanNutricional
        private static void ActualizarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
                Id=8,
                Categoria=Categoria.avanzada,
                Descripcion="Alimentación saludable actualizada",
                Imagen="url.prueba actualización del plan nutricionalr"
                 
            }; 
           _repoPlanNutricional.ActualizarPlanNutricional(planNutricional); 
           Console.WriteLine("Puede ir al Azure y confirmar la actualización");    
        }

        private static IRepositorioRutina _repoRutina =new RepositorioRutina(new Persistencia.AppContext());

        //Clase específica para crear el objeto Rutina
        private static void AdicionarRutina()
        {
            var rutina = new Rutina
            {
                Categoria=Categoria.basica,
                Descripcion="Ejemplo entrenamiento principiantes",
                Imagen="url.prueba Creación",
                Video="url.creación video rutina para definir músculo"
                
            };
            _repoRutina.CrearRutina(rutina);
            Console.WriteLine("Puede ir al Azure y confirmar la creación");

        }
        //Clase específica para consultar el objeto Rutina
        private static void ConsultarRutina(int idRutina)
        {
            var rutina = _repoRutina.ConsultarRutina(idRutina);
            Console.WriteLine(rutina.Categoria+" "+rutina.Descripcion+" "+rutina.Imagen+" "+rutina.Video);
              
        }
        //Clase específica para eliminar el objeto Rutina
        private static void EliminarRutina()
        {
            var rutina = new Rutina
            {
             
            }; 
           _repoRutina.EliminarRutina(1); 
           Console.WriteLine("Puede ir al Azure y confirmar la eliminación");    
        }
        //Clase específica para actualizar el objeto Rutina
        private static void ActualizarRutina()
        {
            var rutina = new Rutina
            {
                Id=1,
                Categoria=Categoria.avanzada,
                Descripcion="Rutina para disminución de peso",
                Imagen="url.imagen de actualización rutina para adelgazar",
                Video="url.video con la rutina para adelgazar" 
            };
            _repoRutina.ActualizarRutina(rutina); 
           Console.WriteLine("Puede ir al Azure y confirmar la actualización");    
        }

    }
}
