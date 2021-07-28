using System;
namespace ProyectoFinal_SistemaVentas.Models{
    /* LOGIN
    Se logueara el usuario dependiendo el tipo:
    -administrador
    -vendedor
    sus atributos: tipo_usuario, usuario ,contraseña */
    public class Login{ //CLASE LOGIN
        
    //ATRIBUTOS 
    public int idusuario {get;set;}
    
    public int idrol {get;set;}
    public String nombre {set;get;}
    public String num_documento {set;get;}
    public String direccion{set;get;}
    public String telefono {set;get;}
    public String email{set;get;}
    public String password{set;get;}
        
    }
}