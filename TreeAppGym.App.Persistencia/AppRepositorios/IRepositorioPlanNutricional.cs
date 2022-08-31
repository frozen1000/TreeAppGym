<<<<<<< HEAD
using TreeAppGym.App.Dominio;
// para que pueda leer donde está la entidad PlanNutricional
using System.Collections.Generic;
// para que no me marque error con las listas numeradas, importa todo lo que tiene que ver con listas
// en este paquete se encuentra todo lo que tiene que ver con listas

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioPlanNutricional{

        PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional);

        PlanNutricional ConsultarPlanNutricional(int idPlanNutricional);
        // aqui quiero que me retorne todas las listas de planes nutricionales
        IEnumerable<PlanNutricional> ConsultarPlanNutricional();
        
        PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional);

        void EliminarPlanNutricional(int idPlanNutricional);
        // vacío porque no necesito que al eliminar me retorne nada
    }


}
=======
using TreeAppGym.App.Dominio;
// para que pueda leer donde está la entidad PlanNutricional
using System.Collections.Generic;
// este using es para que no me marque error con las listas numeradas
// en este paquete se encuentra todo lo que tiene que ver con listas

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioPlanNutricional{

        PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional);

        PlanNutricional ConsultarPlanNutricional(int idPlanNutricional);
        // aqui quiero que me retorne todas las listas de planes nutricionales
        IEnumerable<PlanNutricional> ConsultarPlanNutricional();
        
        PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional);

        void EliminarPlanNutricional(int idPlanNutricional);
        // vacío porque no necesito que al eliminar me retorne nada
    }


}
>>>>>>> e8591ccf4994612d39e0e1a2754dd24e89e0a02e
// En esta clase de tipo interfaz dejo la firma de los métodos, es como un contrato