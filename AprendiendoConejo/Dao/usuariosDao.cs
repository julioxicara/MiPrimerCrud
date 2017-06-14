using System;
using System.Collections.Generic;
using System.Linq;
using AprendiendoConejo.Models;
using System.Web;

namespace AprendiendoConejo.Dao
{
    public class usuariosDao:iUsuariosDao
    {
        private usuariosEntities conexion = new usuariosEntities();        

        public string crear(usuario varusuario)
        {
            try
            {
                conexion.usuario.Add(varusuario);
                conexion.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex.Message;
            }            
        }

        public string modificar(usuario varusuario)
        {
            try
            {
                conexion.Entry(varusuario).State = System.Data.EntityState.Modified;
                conexion.SaveChanges();
                return "OK";
            }

            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex.Message;
            }            
        }

        public string eliminar(string correoelectronico)
        {
            usuario user = new usuario();

            try
            {
                user = conexion.usuario.Find(correoelectronico);
                conexion.usuario.Remove(user);
                conexion.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex.Message;
            }            
        }

        public usuario buscarId(string correoelectronico)
        {
            usuario user = new usuario();

            try
            {
                user = conexion.usuario.Find(correoelectronico);
                return user;
            }

            catch
            {
                return user;
            }  
        }

        public string Login(string correoelectronico, string pass)
        {
            usuario user = new usuario();

            try
            {
                user = conexion.usuario.Find(correoelectronico);
                if (user.correoelectronico == correoelectronico && user.pass == pass)
                {
                    return "OK";
                }

                else
                {
                    return "Sus credenciales no son validas";
                }

                
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex.Message;
            }            
        }

        public List<usuario> listar()

        {
            List<usuario> lista = new List<usuario>();
            lista = conexion.usuario.ToList();
            return lista;
        }
    }
}