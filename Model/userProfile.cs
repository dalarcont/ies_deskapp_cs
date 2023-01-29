using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Model
{
    public class userProfile
    {
        private String fechaRegistro;
        private String idPersona;
        private String nombres;
        private String apellidos;
        private String username;
        private String genero;
        private String emailLaboral;
        private String origenPais; private String origenCiudad; private String residePais; private String resideCiudad;
        private String escolaridad;
        private String pkeyUsuario;
        private String recuperarPregunta;
        private String recuperarRespuesta;
        private String nivelCargo;
        private String nombreCargo;
        private String nombreUnidad;
        private String ultimoAcceso;

        public userProfile(){}

        public userProfile(string fechaRegistro, string idPersona, string nombres, string apellidos, string username, string genero, string emailLaboral, string origenPais, string origenCiudad, string residePais, string resideCiudad, string escolaridad, string pkeyUsuario, string recuperarPregunta, string recuperarRespuesta, string nivelCargo, string nombreCargo, string nombreUnidad, string ultimoAcceso)
        {
            this.FechaRegistro = fechaRegistro;
            this.IdPersona = idPersona;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Username = username;
            this.Genero = genero;
            this.EmailLaboral = emailLaboral;
            this.OrigenPais = origenPais;
            this.OrigenCiudad = origenCiudad;
            this.ResidePais = residePais;
            this.ResideCiudad = resideCiudad;
            this.Escolaridad = escolaridad;
            this.PkeyUsuario = pkeyUsuario;
            this.RecuperarPregunta = recuperarPregunta;
            this.RecuperarRespuesta = recuperarRespuesta;
            this.NivelCargo = nivelCargo;
            this.NombreCargo = nombreCargo;
            this.NombreUnidad = nombreUnidad;
            this.UltimoAcceso = ultimoAcceso;
        }

        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Username { get => username; set => username = value; }
        public string Genero { get => genero; set => genero = value; }
        public string EmailLaboral { get => emailLaboral; set => emailLaboral = value; }
        public string OrigenPais { get => origenPais; set => origenPais = value; }
        public string OrigenCiudad { get => origenCiudad; set => origenCiudad = value; }
        public string ResidePais { get => residePais; set => residePais = value; }
        public string ResideCiudad { get => resideCiudad; set => resideCiudad = value; }
        public string Escolaridad { get => escolaridad; set => escolaridad = value; }
        public string PkeyUsuario { get => pkeyUsuario; set => pkeyUsuario = value; }
        public string RecuperarPregunta { get => recuperarPregunta; set => recuperarPregunta = value; }
        public string RecuperarRespuesta { get => recuperarRespuesta; set => recuperarRespuesta = value; }
        public string NivelCargo { get => nivelCargo; set => nivelCargo = value; }
        public string NombreCargo { get => nombreCargo; set => nombreCargo = value; }
        public string NombreUnidad { get => nombreUnidad; set => nombreUnidad = value; }
        public string UltimoAcceso { get => ultimoAcceso; set => ultimoAcceso = value; }
    }
}
