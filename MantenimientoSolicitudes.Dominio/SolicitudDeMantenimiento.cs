﻿namespace MantenimientoSolicitudes.Dominio
{
    public class SolicitudDeMantenimiento
    {
        
        public TipoSolicitudMantenimiento TipoSolicitudMantenimiento { get; set; }
        public Persona Solicitante { get; set; }

        public Persona Aprobador { get; set; }

        public string IdSubsidiaria { get; set; }

        public string Justificativa { get; set; }

        public Contrato Contrato { get; set; }

        public DateTime InicioDelMantenimiento { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public StatusDeLaSolicitud statusDeLaSolicitud { get; set; }

    }
}
