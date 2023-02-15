using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class Logica
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Notificacion> Notificaciones = new List<Notificacion>();
        public List<Chat> Chats= new List<Chat>();

        public void CrearUsuario(int id, string nombre, string correo, string nickcname, string pswrd, int NumTelefono, List<Juegos> juegos)
        {
            List<int> amigos = new List<int>();
            Usuario usuario = new Usuario(id, nombre, correo, nickcname, pswrd, NumTelefono, juegos, amigos);
        }
        public void EnviarSolicitud(string titulo, string descripcion, int idreceptor, int idemisor)
        {

            SolicictudDeAmistad solicitud = new SolicictudDeAmistad(Notificaciones.Count() + 1, titulo, descripcion, idreceptor, DateTime.Today, DateTime.MinValue, idemisor, Chats.Count() + 1, DateTime.Today.AddDays(30));
            Notificaciones.Add(solicitud);
        }

        public bool CheckearListaAmigos(int idemisor, int idreceptor)
        {
            Usuario emisor = Usuarios.Find(x => x.ID == idemisor);
            
            if (emisor.Amigos.Contains(idreceptor)  )
            {
                return true;
            }
            else return false;
        }
        public Chat CrearChat(string titulo, string descripcion, int idreceptor, int idemisor)
        {
            Usuario emisor = Usuarios.Find(x => x.ID == idemisor);
            int IDNOTIFICACION = Notificaciones.Count + 1;
            if (CheckearListaAmigos(idemisor,idreceptor))
            {
                
                NuevoChat nuevochat = new NuevoChat(IDNOTIFICACION + 1, titulo, descripcion, idreceptor, DateTime.Today, DateTime.MinValue, idemisor, Chats.Count() + 1);
                Notificaciones.Add(nuevochat);
                string nickusuario = emisor.Nickname;
                List<string> listachats = new List<string> { "El usuario " + nickusuario + " ha iniciado un chat" };
                Chat chat = new Chat(Chats.Count() + 1, titulo, Estados.OPEN, listachats,IDNOTIFICACION );
                Chats.Add(chat);
                return chat;
            }
            else
            {

                EnviarSolicitud(titulo, descripcion, idreceptor, idemisor);
                string nickusuario = emisor.Nickname;
                List<string> listachats = new List<string> { "El usuario " + nickusuario + " quiere comunicarse contigo, hasta no aceptarlo como amigo no podra escribir" };
                Chat chat = new Chat(Chats.Count() + 1, titulo, Estados.IN_PROCESS, listachats, IDNOTIFICACION);
                Chats.Add(chat);
                return chat;
            }
        }
        public string EnviarMensaje(Chat chat, string mensaje)//NO PUEDO RETORNAR 2 TIPOS DE DATOS, SOLO RETORNO EL STRING O EL BOOL
        {

            if (chat.estado == Estados.OPEN)
            {
                chat.Mensajes.Add(mensaje);
                return ("Mensaje enviado");

            }
            else return ("No se pudo enviar el mensaje porque el chat se encuentra en estado: " + chat.estado);
        }
        public void AceptarSolicitud (int idnotificacion)
        {
            int idreceptor = Notificaciones.Find(x => x.ID == idnotificacion).IDReceptor;
            int idemisor = Notificaciones.Find(x => x.ID == idnotificacion).IDReceptor;
            Usuarios.Find(x => x.ID == idreceptor).Amigos.Add(idemisor);
            Usuarios.Find(x => x.ID == idemisor).Amigos.Add(idreceptor);

        }
    }
}
