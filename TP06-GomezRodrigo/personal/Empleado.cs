using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    internal class Empleado
    {
        private const int aniosDeAportes = 20;
        internal string nombre { get; set; }
        internal string apellido { get; set; }
        internal DateTime fechaNacimiento { get; set; }
        internal DateTime fechaIngreso { get; set; }
        internal char estadoCivil { get; set; }
        internal char genero { get; set; }
        internal double sueldo { get; set; }
        internal Cargos cargo { get; set; }
        private int contarAnios(DateTime fecha)
        {
            int cantidad = 0;
            if (DateTime.Today.DayOfYear < fecha.DayOfYear)
            {
                cantidad = DateTime.Today.Year - fecha.Year - 1;
            }
            else
            {
                cantidad = DateTime.Today.Year - fecha.Year;
            }
            return cantidad;
        }
        internal int Antiguedad (DateTime fecha)
        {
            int cantidad = 0;
            cantidad = contarAnios(fecha);
            return cantidad;
        }
        internal int Edad (DateTime fecha)
        {
            int cantidad = 0;
            cantidad = contarAnios(fecha);
            return cantidad;
        }
        internal int jubilacion (int antiguedad, int edad)
        {
            int edadControl, aniosRestantes = 0;
            if (genero == 'm')
            {
                edadControl = 65;
            }
            else
            {
                edadControl = 60;
            }
            if (antiguedad >= 20)
            {
                if (edad >= edadControl)
                {
                    aniosRestantes = 0;
                }
                else
                {
                    aniosRestantes = edadControl - edad;
                }
            }
            else
            {
                aniosRestantes = aniosDeAportes - antiguedad;
            }
            return aniosRestantes;
        }
        internal double Salario (int antiguedad)
        {
            double adicional = 0;
            if (antiguedad < 20)
            {
                adicional += sueldo * (antiguedad / 100);
            }
            else
            {
                adicional += sueldo * .25;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional += adicional * .5;
            }
            if (estadoCivil == 'c')
            {
                adicional += 15000;
            }
            return sueldo + adicional;
        }
        internal Empleado()
        {
            fechaIngreso = DateTime.Now;
            sueldo = new Random().Next(25000, 40000);
            cargo = (Cargos)new Random().Next(5);
        }
        internal Empleado(string Nombre, string Apellido, string FechaNac, char EstadoCivil, char Genero)
        {
            nombre = Nombre;
            apellido = Apellido;
            fechaNacimiento = Convert.ToDateTime(FechaNac);
            estadoCivil = EstadoCivil;
            genero = Genero;
        }
    }
}
