using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprendiendoConejo.Models;

namespace AprendiendoConejo.Dao
{
    interface iUsuariosDao
    {
        string crear(usuario varusuario);
        string modificar(usuario varusuario);
        string eliminar(string correcoelectronico);
        usuario buscarId(String correoelectronico);
        String Login(String correoelectronico, String pass);
        List<usuario> listar();

    }
}
