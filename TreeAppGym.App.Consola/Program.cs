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
            Console.WriteLine("Bienvenidos al Gimnasio");
            AdicionarPlanNutricional();
            ConsultarPlanNutricional();
            ActualizarPlanNutricional();
            // EliminarPlanNutricional();

        }
        //Clase específica para crear el objeto PlanNutricional
        private static void AdicionarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
                Categoria=Categoria.avanzada,
                Descripcion="Alimentación saludable pro",
                Imagen="url.dietaespectacular"
                
            };
            _repoPlanNutricional.CrearPlanNutricional(planNutricional);
            
        }
        //Clase específica para consultar el objeto PlanNutricional
        private static void ConsultarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
             
            }; 
           _repoPlanNutricional.ConsultarPlanNutricional(2); 
               
        }
        //Clase específica para eliminar el objeto PlanNutricional
        private static void EliminarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
             
            }; 
           _repoPlanNutricional.EliminarPlanNutricional(2); 
               
        }
        //Clase específica para actualizar el objeto PlanNutricional
        private static void ActualizarPlanNutricional()
        {
            var planNutricional = new PlanNutricional
            {
                
                Categoria=Categoria.avanzada,
                Descripcion="Alimentación saludable pro",
                Imagen="url.dietaespectacular"
                 
            }; 
           _repoPlanNutricional.ActualizarPlanNutricional(planNutricional); 
               
        }

    }
}
