using System;
using System.Collections.Generic;
using System.Text;

namespace AlmacenDisecForms
{
    public class Sede
    {
        private int id;
        private String codigo;
        private String nombre;
        private int telefono;
        private String direccion;
        private String pais;
        private String distrito;
        private Boolean status;


        public Sede(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public Sede(int id, string codigo, string nombre, int telefono, string direccion, string pais, string distrito)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.pais = pais;
            this.distrito = distrito;
            this.status = true;
        }

        public override string ToString()
        {
            return nombre;
        }
        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public bool Status { get => status; set => status = value; }

    }

    public class Traslados
    {
        private int id;
        private Sede origen;
        private Sede destino;
        private List<Items> item;
        private Boolean status;
        private DateTime fecha;

        public Traslados(int id, Sede origen, Sede destino, List<Items> item, bool status, DateTime fecha)
        {
            this.Id = id;
            this.Origen = origen;
            this.Destino = destino;
            this.Item = item;
            this.Status = status;
            this.Fecha = fecha;
        }
        public override string ToString()
        {
            return Item.ToString();
        }
        public int Id { get => id; set => id = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Sede Origen { get => origen; set => origen = value; }
        public Sede Destino { get => destino; set => destino = value; }
        public List<Items> Item { get => item; set => item = value; }
    }
    //Brand
    public class Brand
    {
        private string nombreBrand;
        private int idBrand;
        private int status;
        private string codBrand;

        public Brand(string nombreBrand, int idBrand, int status, string codBrand)
        {
            this.NombreBrand = nombreBrand;
            this.IdBrand = idBrand;
            this.Status = status;
            this.CodBrand = codBrand;
        }

        public string NombreBrand { get => nombreBrand; set => nombreBrand = value; }
        public int IdBrand { get => idBrand; set => idBrand = value; }
        public int Status { get => status; set => status = value; }
        public string CodBrand { get => codBrand; set => codBrand = value; }
    }

    //Categoria
    public class Category
    {
        private string nombreCategory;
        private int idCategory;
        private int status;
        private string codCategory;

        public Category(string nombreCategory, int idCategory, int status, string codCategory)
        {
            this.NombreCategory = nombreCategory;
            this.IdCategory = idCategory;
            this.Status = status;
            this.CodCategory = codCategory;
        }

        public string NombreCategory { get => nombreCategory; set => nombreCategory = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int Status { get => status; set => status = value; }
        public string CodCategory { get => codCategory; set => codCategory = value; }
    }


    //Material
    public class Items
    {

        private int id;
        private string codItem;
        private string nombre;
        private int cant;
        private int cantMinima;
        private string unidad;
        private double precio;
        private Brand brandItem;
        private string serie;
        private int status;
        private Category categoryItem;

        public Items(int id, string nombre, int cant, string unidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cant = cant;
            this.Unidad = unidad;
        }

        public Items(int id, string codItem, string nombre, int cant, int cantMinima, string unidad, double precio, Brand brandItem, string serie, int status, Category categoryItem)
        {
            this.Id = id;
            this.CodItem = codItem;
            this.Nombre = nombre;
            this.Cant = cant;
            this.CantMinima = cantMinima;
            this.Unidad = unidad;
            this.Precio = precio;
            this.BrandItem = brandItem;
            this.Serie = serie;
            this.Status = status;
            this.CategoryItem = categoryItem;
        }

        public int Id { get => id; set => id = value; }
        public string CodItem { get => codItem; set => codItem = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cant { get => cant; set => cant = value; }
        public int CantMinima { get => cantMinima; set => cantMinima = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public Brand BrandItem { get => brandItem; set => brandItem = value; }
        public string Serie { get => serie; set => serie = value; }
        public int Status { get => status; set => status = value; }
        public Category CategoryItem { get => categoryItem; set => categoryItem = value; }
        
        public string getNameBrandItem { get => brandItem.NombreBrand; }
        public string getNameCategory { get => CategoryItem.NombreCategory; }
    }

    //Herramientas
    public class Herramienta
    {
        private int id;
        private string codHerramienta;
        private string nombre;
        private int cant;
        private string unidad;
        private double precio;
        private Brand brandHerramienta;
        private string serie;
        private int status;
        private Category categoryHerramienta;

        public Herramienta(int id, string codHerramienta, string nombre, int cant, string unidad, double precio, Brand brandHerramienta, string serie, int status, Category categoryHerramienta)
        {
            this.Id = id;
            this.CodHerramienta = codHerramienta;
            this.Nombre = nombre;
            this.Cant = cant;
            this.Unidad = unidad;
            this.Precio = precio;
            this.BrandHerramienta = brandHerramienta;
            this.Serie = serie;
            this.Status = status;
            this.CategoryHerramienta = categoryHerramienta;
        }

        public int Id { get => id; set => id = value; }
        public string CodHerramienta { get => codHerramienta; set => codHerramienta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cant { get => cant; set => cant = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public Brand BrandHerramienta { get => brandHerramienta; set => brandHerramienta = value; }
        public string Serie { get => serie; set => serie = value; }
        public int Status { get => status; set => status = value; }
        public Category CategoryHerramienta { get => categoryHerramienta; set => categoryHerramienta = value; }
    }



    //Proveedor
    public class Proveedor
    {
        private int idProveedor;
        private string nombreProveedor;
        private int ruc;
        private string pais;
        private string direccion;
        private int telefono;
        private string email;
        private string codigoProveedor;
        private string distrito;
        private int statusProveedor;

        public Proveedor(int idProveedor, string nombreProveedor, int ruc, string pais, string direccion, int telefono, string email, string codigoProveedor, string distrito, int statusProveedor)
        {
            this.IdProveedor = idProveedor;
            this.NombreProveedor = nombreProveedor;
            this.Ruc = ruc;
            this.Pais = pais;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.CodigoProveedor = codigoProveedor;
            this.Distrito = distrito;
            this.StatusProveedor = statusProveedor;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public int Ruc { get => ruc; set => ruc = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string CodigoProveedor { get => codigoProveedor; set => codigoProveedor = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public int StatusProveedor { get => statusProveedor; set => statusProveedor = value; }
    }


    //Orden de Trabajo
    public class OrdenTrabajo
    {
        private int idOrdenTrabajo;
        private int codOrdenTrabajo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int statusOrdenTrabajo;
        private string descripcion;

        public OrdenTrabajo(int idOrdenTrabajo, int codOrdenTrabajo,DateTime fechaInicio, DateTime fechaFin, int statusOrdenTrabajo, string descripcion)
        {
            this.IdOrdenTrabajo = idOrdenTrabajo;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.StatusOrdenTrabajo = statusOrdenTrabajo;
            this.Descripcion = descripcion;
            this.CodOrdenTrabajo = codOrdenTrabajo;
        }

        public int IdOrdenTrabajo { get => idOrdenTrabajo; set => idOrdenTrabajo = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int StatusOrdenTrabajo { get => statusOrdenTrabajo; set => statusOrdenTrabajo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CodOrdenTrabajo { get => codOrdenTrabajo; set => codOrdenTrabajo = value; }
    }


    //Cliente
    public class Cliente
    {
        private int idCliente;
        private string nombreCliente;
        private string codCliente;

        public Cliente(int idCliente, string nombreCliente, string codCliente)
        {
            this.IdCliente = idCliente;
            this.NombreCliente = nombreCliente;
            this.CodCliente = codCliente;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string CodCliente { get => codCliente; set => codCliente = value; }
    }

    //Empleado
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int dni;
        private int status;
        private string codEmpleado;
        private char genero;
        private int privilegio;
        private string nombreUsuario;
        private string contrasena;
        private string email;
        private double salario;
        private string direccion;
        private string pais;
        private string distrito;
        private string telefono;

        public Empleado(int idEmpleado, string nombre, string apellidoPaterno, string apellidoMaterno, int dni, int status, string codEmpleado, char genero, int privilegio, string nombreUsuario, string contrasena, string email, double salario, string direccion, string pais, string distrito, string telefono)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Dni = dni;
            this.Status = status;
            this.CodEmpleado = codEmpleado;
            this.Genero = genero;
            this.Privilegio = privilegio;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Email = email;
            this.Salario = salario;
            this.Direccion = direccion;
            this.Pais = pais;
            this.Distrito = distrito;
            this.Telefono = telefono;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Status { get => status; set => status = value; }
        public string CodEmpleado { get => codEmpleado; set => codEmpleado = value; }
        public char Genero { get => genero; set => genero = value; }
        public int Privilegio { get => privilegio; set => privilegio = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Email { get => email; set => email = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }


}

