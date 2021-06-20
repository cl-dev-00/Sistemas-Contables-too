﻿using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class UsuariosForm : Form
    {
        private UsuarioDAO userDao;
        private List<Usuario> listaUsers;
        public UsuariosForm()
        {
            InitializeComponent();
            userDao = new UsuarioDAO();
            cargarDatos();
        }

        private void cargarDatos()
        {
            if (dvgUsuarios.RowCount > 0)
            {
                dvgUsuarios.Rows.Clear();
                listaUsers.Clear();
            }

            listaUsers = userDao.getList();
            //MessageBox.Show(null, listaUsers.Count.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            //lblUsers.Text = "Numeros de propietarios: " + listaUsers.Count;

            foreach (Usuario user in listaUsers)
            {
                dvgUsuarios.Rows.Add(user.IdUsuario, user.NombreUsuario, user.Rol);
            }
        }
    }
}
