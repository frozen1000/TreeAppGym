using TreeAppGym.App.Dominio;
using System.Collections.Generic;

namespace TreeAppGym.App.Persistencia{

    public interface IRepositorioPlanNutricional{

        PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional);

        PlanNutricional ConsultarPlanNutricional(int idPlanNutricional);

        IEnumerable<PlanNutricional> ConsultarPlanNutricional();
        
        PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional);

        void EliminarPlanNutricional(int idPlanNutricional);
        
    }


}