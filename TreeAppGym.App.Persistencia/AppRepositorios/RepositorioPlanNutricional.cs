using TreeAppGym.App.Dominio;
using System.Linq;
using System.Collections.Generic;


namespace TreeAppGym.App.Persistencia
{

    public class RepositorioPlanNutricional : IRepositorioPlanNutricional
    {
        private readonly AppContext _appContext;

        public RepositorioPlanNutricional(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public PlanNutricional CrearPlanNutricional(PlanNutricional PlanNutricional)
        {
            var PlanNutricionalAdicionado = _appContext.PlanNutricional.Add(PlanNutricional);
            _appContext.SaveChanges();
            return PlanNutricionalAdicionado.Entity;
        }

        public PlanNutricional ConsultarPlanNutricional(int idPlanNutricional)
        {

            return _appContext.PlanNutricional.FirstOrDefault(c => c.Id == idPlanNutricional);

        }

        public IEnumerable<PlanNutricional> ConsultarPlanNutricional()
        {
            return _appContext.PlanNutricional;
        }

        public PlanNutricional ActualizarPlanNutricional(PlanNutricional PlanNutricional)
        {

            var PlanNutricionalEncontrado = _appContext.PlanNutricional.FirstOrDefault(c => pn.Id == PlanNutricional.Id);
            if (PlanNutricionalEncontrado != null)
            {
                PlanNutricionalEncontrado.Nombres = PlanNutricional.Nombres;
                PlanNutricionalEncontrado.Apellidos = PlanNutricional.Apellidos;
                PlanNutricionalEncontrado.Email = PlanNutricional.Email;
                PlanNutricionalEncontrado.Edad = PlanNutricional.Edad;
                PlanNutricionalEncontrado.Telefono = PlanNutricional.Telefono;
                PlanNutricionalEncontrado.Direccion = PlanNutricional.Direccion;
                PlanNutricionalEncontrado.Contraseña = PlanNutricional.Contraseña;
                PlanNutricionalEncontrado.Genero = PlanNutricional.Genero;
                _appContext.SaveChanges();
            }
            return PlanNutricionalEncontrado;

        }

        public void EliminarPlanNutricional(int idPlanNutricional)
        {
            var PlanNutricionalEncontrado = _appContext.PlanNutricional.FirstOrDefault(c => c.Id == idPlanNutricional);
            if (PlanNutricionalEncontrado == null)
                return;
            _appContext.PlanNutricional.Remove(PlanNutricionalEncontrado);
            _appContext.SaveChanges();
        }

    }

}