using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization; 
using System.Drawing.Text;

namespace Calculo_de_Notas.Net
{
    public partial class Form1 : Form
    {
        //Declarar objetos
        //ArrayList listaAlumnos = new ArrayList();

        List<Alumno> listaAlumnos = new List<Alumno>();
        ValidarCajas validacion = new ValidarCajas();

        public Form1()
        {
            InitializeComponent();
        }

      
        private void tsAddUser_Click(object sender, EventArgs e)
        {
            //---------------- Agregar Alumno
            //----------------Hace las validaciones

            insertardatos();

            if (!validacion.vacio(txtcodigoin, errorm, "El código no puede ser vacío"))
                if (validacion.TipoNumero(txtcodigoin, errorm, "Debe digitar numeros"))
                    if (!validacion.vacio(txtnombrein, errorm, "El nombre no puede ser vacío"))
                        if (validacion.TipoTexto(txtnombrein, errorm, "Debe digitar letras"))
                            if (!validacion.vacio(txtcorreoin, errorm, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(txtcorreoin, errorm, "El correo no cumple con el formato"))
                                    if (!validacion.vacio(txtnota1in, errorm, "La Nota 1 no puede estar vacía"))
                                        if (validacion.TipoNumero(txtnota1in, errorm, "Debe digitar numeros"))
                                            if (!validacion.vacio(txtnota2in, errorm, "La Nota 2 no puede estar vacía"))
                                                if (validacion.TipoNumero(txtnota2in, errorm, "Debe digitar numeros"))
                                                    if (!validacion.vacio(txtnota3in, errorm, "La Nota 3 no puede estar vacía"))
                                                        if (validacion.TipoNumero(txtnota3in, errorm, "Debe digitar numeros"))
                                                            if (!validacion.vacio(txtnota4in, errorm, "La Nota 4 no puede estar vacía"))
                                                                if (validacion.TipoNumero(txtnota4in, errorm, "Debe digitar numeros"))
                                                                    guardarcambios();
                                                                 
        }
        //---------- metodo para ver el array en consola
        
        private void tsSaveFile_Click(object sender, EventArgs e)
        {
            // Crea nuestro archivo xml....
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsOpenFile_Click(object sender, EventArgs e)
        {
            //cargar los datos del xml
            //generar una lista con esos datos
            // mostrar esa lista en el DG

            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerXml = File.OpenRead("C:/net/listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
            leerXml.Close();

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

        }
        private void insertardatos()
        {
            Alumno nuevoAlumno = new Alumno();

            // Desde los elementos del formulario creo el alumno nuevo

            nuevoAlumno.Codigo = Convert.ToInt32(txtcodigoin.Text);
            nuevoAlumno.Nombre = txtnombrein.Text;
            nuevoAlumno.Correo = txtcorreoin.Text;
            nuevoAlumno.Nota1 = Convert.ToDouble(txtnota1in.Text);
            nuevoAlumno.Nota2 = Convert.ToDouble(txtnota2in.Text);
            nuevoAlumno.Nota3 = Convert.ToDouble(txtnota3in.Text);
            nuevoAlumno.Nota4 = Convert.ToDouble(txtnota4in.Text);
            nuevoAlumno.NotaFinal = (nuevoAlumno.Nota1 + nuevoAlumno.Nota2 + nuevoAlumno.Nota3 + nuevoAlumno.Nota4) / 4;
            if (nuevoAlumno.NotaFinal >= 3.5)
                nuevoAlumno.NotaConcepto = "Aprobado";
            else
                nuevoAlumno.NotaConcepto = "Reprobado";


            //Agrego el objeto alumno al arreglo  
            listaAlumnos.Add(nuevoAlumno);
            //Alimento el datagrid o visualizo el datagrit en el arrego
            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void LimpiarCajas()
        {
            txtcodigoin.Clear();
            txtnombrein.Clear();
            txtcorreoin.Clear();
            txtnota1in.Clear();
            txtnota2in.Clear();
            txtnota3in.Clear();
            txtnota4in.Clear();
            txtcodigoin.Focus();
        }

        private void LimpiarCajas2()
        {

       
            txtnombrein.Clear();
            txtcorreoin.Clear();
            txtnota1in.Clear();
            txtnota2in.Clear();
            txtnota3in.Clear();
            txtnota4in.Clear();
            txtcodigoin.Focus();
        }

        private void verArreglo()
        {
            foreach (Alumno itemalumno in listaAlumnos)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(itemalumno.Codigo);
                Console.WriteLine(itemalumno.Nombre);
                Console.WriteLine(itemalumno.Correo);
                Console.WriteLine(itemalumno.Nota1);
                Console.WriteLine(itemalumno.Nota2);
                Console.WriteLine(itemalumno.Nota3);
                Console.WriteLine(itemalumno.Nota4);
                Console.WriteLine(itemalumno.NotaFinal);
                Console.WriteLine(itemalumno.NotaConcepto);
                Console.WriteLine("---------------");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:/net/listaAlumnos.xml"))
            {
                listaAlumnos.Clear();
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("C:/net/listaAlumnos.xml");
                listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        //vamos a usar metodos para la validación y manipulacion de datos
        // validar que el nuevo codigo no exista en la lista

        private Boolean ExisteCodigo(int codigo)
        {


            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return true;
            }
            return false;
        }

        private Alumno obtenerDatos(int codigo)
        {
            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return myAlumno;
            }
            return null;
        }



        private void guardarcambios()
        {
            // Metodo crea un objeto alumno con el "codigo que está en la caja de texto correspondiente"  
            // como el objeto es de la lista, actualiza los valores

            Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
            myAlumno.Nombre = txtnombrein.Text;
            myAlumno.Correo = txtcorreoin.Text;
            myAlumno.Nota1 = Convert.ToDouble(txtnota1in.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtnota2in.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtnota3in.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtnota4in.Text);

            myAlumno.NotaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;
            if (myAlumno.NotaFinal >= 3.5)
            {
                myAlumno.NotaConcepto = "Aprobado";
            }
            else
            {
                myAlumno.NotaConcepto = "Reprobado";
            }

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

            tsEditUser.Enabled = false;
            tsDeleteUser.Enabled = false;
            txtcodigoin.Enabled = true;
            LimpiarCajas();

        }



        private void tsExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void tsOpenFile_Click_1(object sender, EventArgs e)
        {
            //Cargar los datos del XML
            //Generar una lista xcon esos datos 
            //Mostar esa losta en el data DataGridView

            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerxml = File.OpenRead("C:/net/listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerxml);
            leerxml.Close();

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

        }

        private void dgTablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Cuando se abre lea el archivo y lo muestre

            //Cargar los datos del XML
            //Generar una lista xcon esos datos 
            //Mostar esa losta en el data DataGridView

            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerxml = File.OpenRead("C:/net/listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerxml);
            leerxml.Close();

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            // Cuando se cierra se guarde la informacion

            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

       

        private void tsDeleteUser_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmarborrar = MessageBox.Show("Se borraran todos los datos", "Confirmar borrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmarborrar == DialogResult.OK)
            {

                // Borrar datos del estudiante

                Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
                listaAlumnos.Remove(myAlumno);

                dgTablaDatos.DataSource = null;
                dgTablaDatos.DataSource = listaAlumnos;

                //Activa los botones
                tsEditUser.Enabled = false;
                tsDeleteUser.Enabled = false;
                txtcodigoin.Enabled = true;
                LimpiarCajas();
            }
        }

        private void tsSearchUser_Click_1(object sender, EventArgs e)
        {
            //buscar alumno
            // validar vacio

            if (!validacion.vacio(txtcodigoin, errorm, "Debe ingresar un codigo"))
                if (validacion.TipoNumero(txtcodigoin, errorm, "Solo numeros"))
                {
                    if (ExisteCodigo(Convert.ToInt32(txtcodigoin.Text)))
                    {
                        Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
                        txtnombrein.Text = myAlumno.Nombre;
                        txtcorreoin.Text = myAlumno.Correo;
                        txtnota1in.Text = myAlumno.Nota1.ToString();
                        txtnota2in.Text = myAlumno.Nota2.ToString();
                        txtnota3in.Text = myAlumno.Nota3.ToString();
                        txtnota4in.Text = myAlumno.Nota4.ToString();

                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtcodigoin.Enabled = false;

                    }
                    else
                    {
                        errorm.SetError(txtcodigoin, "El código no existe");
                        txtcodigoin.Focus();
                        LimpiarCajas2();
                        return;
                    }
                }
        }

        private void tsEditUser_Click(object sender, EventArgs e)
        {
            // ----------------Editar datos
            //----------------Hace las validaciones

          

            if (!validacion.vacio(txtcodigoin, errorm, "El código no puede ser vacío"))
                if (validacion.TipoNumero(txtcodigoin, errorm, "Debe digitar numeros"))
                    if (!validacion.vacio(txtnombrein, errorm, "El nombre no puede ser vacío"))
                        if (validacion.TipoTexto(txtnombrein, errorm, "Debe digitar letras"))
                            if (!validacion.vacio(txtcorreoin, errorm, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(txtcorreoin, errorm, "El correo no cumple con el formato"))
                                    if (!validacion.vacio(txtnota1in, errorm, "La Nota 1 no puede estar vacía"))
                                        if (validacion.TipoNumero(txtnota1in, errorm, "Debe digitar numeros"))
                                            if (!validacion.vacio(txtnota2in, errorm, "La Nota 2 no puede estar vacía"))
                                                if (validacion.TipoNumero(txtnota2in, errorm, "Debe digitar numeros"))
                                                    if (!validacion.vacio(txtnota3in, errorm, "La Nota 3 no puede estar vacía"))
                                                        if (validacion.TipoNumero(txtnota3in, errorm, "Debe digitar numeros"))
                                                            if (!validacion.vacio(txtnota4in, errorm, "La Nota 4 no puede estar vacía"))
                                                                if (validacion.TipoNumero(txtnota4in, errorm, "Debe digitar numeros"))
                                                                {
                                                                    if (!ExisteCodigo(Convert.ToInt32(txtcodigoin.Text)))
                                                                    {
                                                                        insertardatos();
                                                                        LimpiarCajas();
                                                                        errorm.Clear();
                                                                    }
                                                                    else
                                                                    {
                                                                        errorm.SetError(txtcodigoin, "El código ya existe");
                                                                        txtcodigoin.Focus();
                                                                        return;
                                                                    }
                                                                }

        }

        // Mis metodos

        private void guardarcambios2()
        {
            // Editar datos

            Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
            myAlumno.Nombre = txtnombrein.Text;
            myAlumno.Correo = txtcorreoin.Text;



            myAlumno.Nota1 = Convert.ToDouble(txtnota1in.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtnota2in.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtnota3in.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtnota4in.Text);
            myAlumno.NotaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;
            if (myAlumno.NotaFinal >= 3.5)
                myAlumno.NotaConcepto = "Aprobado";
            else
                myAlumno.NotaConcepto = "Reprobado";

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

            //Activar los botones

            tsEditUser.Enabled = false;
            tsDeleteUser.Enabled = false;
            txtcodigoin.Enabled = true;
            LimpiarCajas();

        }
        


    }
}