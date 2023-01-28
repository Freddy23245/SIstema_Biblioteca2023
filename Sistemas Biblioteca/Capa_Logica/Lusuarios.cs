using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
using Soporte.Cache;

namespace Capa_Logica
{    

    public class Lusuarios
    {

         private int id_usuario;
         private string nombre;
         private string apellido;
         private string usuario; 
         private string contraseña;
         private string email;
         private byte[] imagen;

        public Lusuarios(int id_usuario,string nombre,string apellido,string usuario, string contraseña,string email, byte[] imagen)
         {
             this.id_usuario = id_usuario;
             this.nombre = nombre;
             this.apellido = apellido;
             this.usuario = usuario;
             this.contraseña = contraseña;
             this.email = email;
             this.imagen = imagen;
         }
        public Lusuarios()
        {

        }


        Dusuarios usuarios = new Dusuarios();
     

        public string RegistrarUsuario()
        {
            usuarios.Registrar(nombre,apellido, usuario, contraseña, email,imagen);
            return "Usuario Registrado Correctamente Avise al Administrador para que otorgue los permisos correspondientes";
        }

        public string EditarPerfil()
        {
            usuarios.EditarPerfil(id_usuario, nombre, apellido, usuario, contraseña, email, imagen);
            Foto(id_usuario);
            LoginUser(usuario, contraseña);
            
            return "Tu Perfil Se Edito Correctamente";
           
        }

        public byte[] Foto(int id_usuario)
        {
            return usuarios.mostrarFotoPerfil(id_usuario);
        }


        public string recoverPassword(string userRequesting)
        {
        
            var random = new Random();
            string var; 
               var = Convert.ToString(random.Next(1000,2000));
            usuarios.CambiarContraseña(userRequesting, Seguridad.Encriptar(var));
            return usuarios.recoverPassword(userRequesting);
            
        }
        public void CambiarContraseña(string userRequesting, string var)
        {
             usuarios.CambiarContraseña(userRequesting, var);
        }
        public bool LoginUser(string user, string pass)
        {
            return usuarios.Login(user, pass);
        }
      

        public DataTable mostrar()
        {
            return  usuarios.mostrar();
        }

        public DataTable mostrarGrupos()
        {
            return usuarios.mostrarGrupos();
        }

        public DataTable mostrarPermisos()
        {
            return usuarios.mostrarPermisos();
        }
       
        public DataTable MostrarGruposPermisos()
        {
            return usuarios.mostrarGruposPermisos();
        }

        public void AgregarGruposPermisos(int id_grupo,int id_permiso,bool alta,bool baja, bool modificacion,bool lectura)
        {
            usuarios.AgregarGruposPermisos(id_grupo, id_permiso, alta, baja, modificacion, lectura);
        }

        public void Hora_Ingreso1(int id_usuario)
        {
            usuarios.Hora_ingreso(id_usuario);
        }

        public void Hora_Salida1(int id_usuario)
        {
            usuarios.Hora_salida (id_usuario);
        }

        public void AgregarGruposUsuarios(int id_usuario,int id_grupo)
        {
            usuarios.AgregarUsuarioGrupo(id_usuario, id_grupo);
        }

        public void QuitarPermisos(int id_GruposPermiso)
        {
            usuarios.QuitarPermisos(id_GruposPermiso);
        }

        public DataTable ValidarPermisos(int id_usuario)
        {
            return usuarios.validar_permisos(id_usuario);
        }
        public string GrupoDeUsuario(int id_usuario)
        {
            string mens;
            mens = usuarios.Grupos_de_Usuarios(id_usuario);
            return mens;
        }
        public DataTable ValidatBotones(int id_usuario)
        {
            return usuarios.validar_botones(id_usuario);
        }

        public void IntentoPass(string usu,string pass)
        {
            usuarios.intento_pass(usu, pass);
        }
        public void IngresoUsuario(int id_usuario)
        {
            usuarios.ingreso_usuario(id_usuario);
        }
    }

 }

