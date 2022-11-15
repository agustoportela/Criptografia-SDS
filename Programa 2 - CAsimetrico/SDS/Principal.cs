using SDS.back.colecciones;
using SDS.back.entities;
using SDS.back.entities.messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDS
{
    public partial class Principal : Form
    {
        private Users usuario;

        private Coleccion_mensajes colecionMensajes;
        private Coleccion_usuarios coleccion_usuarios;

        
        public Principal(Users user)
        {
            InitializeComponent();
            this.usuario = user;
            this.colecionMensajes = new Coleccion_mensajes();
            this.coleccion_usuarios = new Coleccion_usuarios();

            buscarMisMensajes();
            buscarMensajes();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            buscarMisMensajes();
        }

        private void buscarMisMensajes()
        {
            var mensajes = colecionMensajes.MensajesPorDestinatario(usuario.llave_publica);
            cargarMensajes(mensajes, dgv_misMensajes);
        }

        private void buscarMensajes()
        {
            var mensajes = colecionMensajes.GetAllAsync().Result;
            cargarMensajes(mensajes, dgv_mensajes);
        }

        private void cargarMensajes(List<Mensaje> mensajes, DataGridView dgv)
        {
            foreach (var item in mensajes)
            {
                llevarMensajeAGrilla(item, dgv);
            }
        }

        private void llevarMensajeAGrilla(Mensaje mensaje, DataGridView dgv)
        {
            if(dgv.Name == "dgv_misMensajes")
            mensaje.DesencriptarTexto(usuario.llave_privada);


            var nick = coleccion_usuarios.GetByIdAsync(mensaje.creador).Result.nick;

            var fila = new string[] { nick, mensaje.asunto, mensaje.texto };
            dgv.Rows.Add(fila);
        }

        private void btnMakeMessage_Click(object sender, EventArgs e)
        {
            var form = new EnviarMensaje(usuario);
            form.ShowDialog();
        }

        private void dgv_misMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
