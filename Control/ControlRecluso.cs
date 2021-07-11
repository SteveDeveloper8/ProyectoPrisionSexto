﻿using Data;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class ControlRecluso
    {
        DatosRecluso datosRecluso = new DatosRecluso();
        List<Recluso> reclusos = new List<Recluso>();
        Recluso recluso = null;
        internal bool ValidarCodigo(string codigo)
        {
            bool x = true;
            if (codigo.Length != 10)
            {
                x = false;
            }
            return x;
        }
        
        public bool existeCodigo(string codigo)
        {
            foreach (Recluso recluso in reclusos)
            {
                if (recluso.Codigo.Equals(codigo))
                {
                    MessageBox.Show("Código ya registrado");
                    return true;
                }
            }
            return false;
        }

        public Object buscarExpediente(string cedula)
        {
            Expediente expediente = null;
            expediente = datosRecluso.buscarExpedienteBD(cedula);

            if (expediente == null)
            {
                MessageBox.Show("no hay expedientes");
                throw new GeneralExcepcion("Expediente de recluso no existente");
            }
            else
            {
                return expediente;
            }
        }


        public void GuardarRecluso(string codigo, string nombre, string apellido, string genero, DateTime fecha, int idExpediente, string cedula)
        {
            Expediente exp = datosRecluso.buscarExpedienteBD(cedula);
            recluso = new Recluso(nombre, apellido, genero, fecha, cedula, codigo, exp);
            datosRecluso.InsertarRecluso(recluso);

            /*if (message.Equals("fallido"))
            {
                throw new GeneralExcepcion("Existio un error en base de datos");
            }*/
        }


        public List<Object> ListarReclusos()
        {
            List<Object> reclusos= datosRecluso.ConsultarReclusos();

            if (reclusos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron reclusos registrados");
            else
                return reclusos;
        }

        public Object BuscarRecluso(string cedula)
        {
            Object recluso = datosRecluso.BuscarRecluso(cedula);
            if (recluso != null)
                return recluso;
            else
                throw new Exception();
        }
        public List<Object> ListarCargos(string codigoExpediente)
        {
            List<Cargo> cargos = datosRecluso.ConsultarCargos(codigoExpediente);

            if (cargos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron cargos registrados");
            else
                return GetListaDatosCargos(cargos);
        }
        public List<Object> GetListaDatosCargos(List<Cargo> cargos)
        {
            List<Object> cargosDatos = new List<object>();
            foreach (Cargo cargo in cargos)
            {
                cargosDatos.Add(ConvertirAnonimo(cargo));
            }
            return cargosDatos;
        }
        public Object ConvertirAnonimo(Cargo cargo)
        {
            return new
            {
                delito = cargo.Delito,
                descripcion = cargo.Descripcion,
                fecha = cargo.FechaHechos,
                localidad = cargo.LugarHechos.NombreLocalidad,
                ciudad = cargo.LugarHechos.NombreCiudad,
                pais = cargo.LugarHechos.NombrePais
            };
        }
    }
}
