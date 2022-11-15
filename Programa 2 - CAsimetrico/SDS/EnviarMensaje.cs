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
    public partial class EnviarMensaje : Form
    {
        private Users usuario;
        private Coleccion_mensajes colecionMensajes;
        public EnviarMensaje(Users usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            this.colecionMensajes = new Coleccion_mensajes();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var mensaje = new Mensaje(usuario.Id, txt_texto.Text, txt_asunto.Text, txt_key.Text);

            await colecionMensajes.InsertOneAsync(mensaje);
        }
    }
}
