  //  Realizar un programa que guarda los sueldos de 5 operarios en un arreglo de tipo vector
            int[] GuardarSueldos=null;
            GuardarSueldos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el sueldo número ");
                int ValorSueldo = int.Parse(Console.ReadLine());
                GuardarSueldos[i] = ValorSueldo;
            }

            Console.WriteLine("Los sueldos son " + GuardarSueldos[0] + +GuardarSueldos[1] + +GuardarSueldos[2] + +GuardarSueldos[3] + +GuardarSueldos[4]);
            Console.ReadLine();
        }
		
 //          Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por 
            //la tarde)
            //Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
            //Imprimir los gastos en sueldos de cada turno.
            double[] TurnoTarde;
            double[] TurnoManana;

            TurnoManana = new double[4];
            TurnoTarde = new double[4];

            double TotalSueldosManana=0;
            double TotalSueldosTarde = 0;

            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine("Ingrese sueldo del operario número " + (i+1) + " del turno mañana:");
                double SueldosTurnoManana= double.Parse(Console.ReadLine());
                TurnoManana[i] = SueldosTurnoManana;
                TotalSueldosManana = TotalSueldosManana + TurnoManana[i];
            }

            for (int j = 0; j < 4; j++)
            {
                

                Console.WriteLine("Ingrese sueldo del operario numero " + (j+1) + " del turno tarde");
                double SueldosTurnoTarde= double.Parse(Console.ReadLine());
                TurnoTarde[j] = SueldosTurnoTarde;
                TotalSueldosTarde= TotalSueldosTarde + TurnoTarde[j];
            }

            Console.WriteLine("Los gastos de sueldo del turno mañana son: " + TotalSueldosManana);
            Console.WriteLine("Los gastos de sueldo del turno tarde son: " + TotalSueldosTarde);
            Console.ReadLine();
            }
			
//Realizar un programa que defina un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.

            double[] ArrayAlturas;
            ArrayAlturas = new double[5];

            double SumaAlturas = 0;
            double promedio = 0;
            int MasAltos = 0;
            int MasBajos=0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese altura numero " + (i + 1));
                double alturas = double.Parse(Console.ReadLine());
                ArrayAlturas[i] = alturas;
                 SumaAlturas= SumaAlturas+ alturas;
                 promedio = SumaAlturas / 5;
            }
            for (int j=0; j<5 ; j++){
                if (ArrayAlturas[j] > promedio)
                { MasAltos += 1; }
                if (ArrayAlturas[j] < promedio)
                { MasBajos += 1; }
            }
            Console.WriteLine("El promedio de alturas es " + promedio);
            Console.WriteLine(" Cantidad mas alta que el promedio es " + MasAltos);
            Console.WriteLine(" Cantidad mas baja que el promedio es " + MasBajos);
            Console.ReadLine();

			
			
			
			
 public void Cargar()
{...}
 public void CalcularGastos()
 {...}
 
 static void Main(string[] args)
        {
            PruebaVector3 pv = new PruebaVector3();
            pv.Cargar();
            pv.CalcularGastos();
        }			
		
		
		
//Definir un vector donde almacenar los nombres de 5 personas. Realizar un programa que ordene alfabéticamente
            string[] nombres;
            nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nombre ");
                nombres[i] = Console.ReadLine();
             
                
            }
            Array.Sort(nombres);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" nombres ordenados " + nombres[i] );
               
            }
            Console.ReadLine();
        }



// oredenar vector

public void Ordenar()
        {
            for (int k = 0; k < vector.Length; k++)
            {
                for (int f = 0; f < vector.Length - 1 - k; f++)
                {
                    if (vector[f] > vector[f + 1])
                    {
                        int aux;
                        aux = vector[f];
                        vector[f] = vector[f + 1];
                        vector[f + 1] = aux;
                    }
                }
            }
        }

		
//SUmar pares e impares

  int[] SumaPares;
            int[] SumaImpares;
            int CantidadNumeros = 0;
            int Numero=0;
            int NumerosPares = 0;
            int NumerosImpares = 0;
            
            SumaPares= new int[12];
            SumaImpares = new int[12];

            Console.WriteLine("Ingrese cantidad de numeros para el array");
            CantidadNumeros =int.Parse(Console.ReadLine());

            for (int i = 0; i < CantidadNumeros; i++)
            {
                Console.WriteLine("ingrese numero  ");
                Numero = int.Parse(Console.ReadLine());

                if ((Numero % 2) == 0)
                {
                   // SumaPares[i]=Numero;
                    NumerosPares = NumerosPares + Numero; // SumaPares[i];
                }
                else
                {
                 //   SumaImpares[i] = Numero;
                    NumerosImpares = NumerosImpares + Numero; //+ SumaImpares[i];
                
                }
            }

            Console.WriteLine("pares: " + NumerosPares);
            Console.WriteLine("impares: " + NumerosImpares);
            Console.ReadLine();


   // mayor y menor de un arreglo de n elementos
            int mayor = 0;
            int menor=0;
            int[] array;

            array= new int[10];

            Console.WriteLine("Ingrese cantidad de elementos <10 : ");
            int CantElementos =int.Parse(Console.ReadLine());

            for (int i = 0; i < CantElementos; i++)
            {
                Console.WriteLine("Ingrese elemento {0} ", (i+1));
               int numero= int.Parse(Console.ReadLine());
                array[i]=numero;

            }
            for (int i = 0; i < CantElementos; i++)
            { menor = array[i]; }

            for (int i = 0; i < CantElementos; i++)
            {
                if (array[i] > mayor)
                { mayor = array[i]; }
              //  else menor=array[i];

                if (array[i] < menor)
                { menor = array[i]; }
            }
            Console.WriteLine("mayor : " + mayor);
            Console.WriteLine("menor : " + menor);
            Console.ReadLine();			


 //insertar un elemento en un arreglo

            string[] array;
            array = new string[6]{"a","b","c","d","e","f"};

            Console.WriteLine("en que posicion quiere introducir el elemento? (del 1 al 6) ");
            int posicion= int.Parse(Console.ReadLine());
            posicion = posicion - 1;

            Console.WriteLine("ingrese el elemento");
            string elemento = Console.ReadLine();
            Console.WriteLine(" ");
            array[posicion] = elemento;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();



 //ELIMINAR UN ELEMENTO EN UN ARREGLO

            int[] array;
            int[] arrayNuevo;

            Console.WriteLine("Cantidad de elementos del arreglo: ");
            int cantidad = int.Parse(Console.ReadLine());
            array = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese elemento numero : {0} ", (i + 1));
                int elemento = int.Parse(Console.ReadLine());

                array[i] = elemento;
            }

            Console.WriteLine("ingrese la posicion del elemento que desea elminar de 0 a 6");
            int posicion = int.Parse(Console.ReadLine());

            arrayNuevo = new int[cantidad-1];
       
            for (int j = 0; j < posicion ; j++)
            {
                arrayNuevo[j] = array[j];
            }

            int k=0; 
            for (k= posicion; k < cantidad; k++)
            {
                arrayNuevo[k-1] = array[k ];
            }
           
            for (int m = 0; m < cantidad - 1; m++)
            {
                Console.WriteLine("nuevo array : " + arrayNuevo[m]);
            }
            Console.ReadLine();



 //SUMA DE DOS ARREGLOS DE 5 ELEMENTOS

            int[] array1;
            int[] array2;
            int[] arraySuma;
            array1= new int[5];
            array2= new int[5];
            arraySuma = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero {0} del arreglo 1", (i+1));
                int numero = int.Parse(Console.ReadLine());
                array1[i] = numero;
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Ingrese numero {0} del arreglo 2", (j+1));
                int numero = int.Parse(Console.ReadLine());
                array2[j] = numero;
            }

            for (int k = 0; k < 5; k++)
            {
               arraySuma[k]= array1[k] + array2[k];
            }
            for(int m=0; m<5; m++)
            {
                Console.WriteLine("suma: " + arraySuma[m]);
              
            }
            Console.ReadLine();


//Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. Luego de realizar la carga 
  //por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años)

            string[] arrayNombre;
            int[] arrayEdad;
            int[] arrayMayorEdad;
            string[] arrayMayorNombre;

            arrayNombre= new string[5];
            arrayEdad= new int[5];
            arrayMayorEdad = new int[5];
            arrayMayorNombre = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nombre de la persona {0} ", i);
                string nombre = Console.ReadLine();
                arrayNombre[i] = nombre;

                Console.WriteLine("Ingrese edad de la persona {0} " , i);
                int edad = int.Parse(Console.ReadLine());
                arrayEdad[i]=edad;
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Nombre de la persona {0}", arrayNombre[j]);
                Console.WriteLine(" Y su edad es {0}:" , arrayEdad[j]);

                if (arrayEdad[j] >= 18)
                { 
                arrayMayorEdad[j]= arrayEdad[j];
                arrayMayorNombre[j] = arrayNombre[j];

                }

            }

            for (int k = 0; k < 5; k++ )
            {
                Console.WriteLine("Personas mayores de edad: {0} :", arrayMayorNombre[k]);
            }
            Console.ReadLine();


//Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos.
            
            // Mostrar el sueldo mayor y el nombre del operario.
            string[] arrayNombre;
            int[] arraySueldo;
            int[] arrayMayorEdad;
            string[] arrayMayorNombre;

            arrayNombre = new string[5];
            arraySueldo = new int[5];
            arrayMayorEdad = new int[5];
            arrayMayorNombre = new string[5];

            int mayorSueldo = 0;
            string nombreMayorSueldo = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nombre de la persona {0} ", (i+1));
                string nombre = Console.ReadLine();
                arrayNombre[i] = nombre;

                Console.WriteLine("Ingrese sueldo de la persona {0} ", (i + 1));
                int sueldo = int.Parse(Console.ReadLine());
                arraySueldo[i] = sueldo;
            }

            for (int j = 0; j < 5; j++)
            {

                if (arraySueldo[j] >= mayorSueldo)
                {
                    mayorSueldo = arraySueldo[j];
                    nombreMayorSueldo = arrayNombre[j];
                }
            }

            Console.WriteLine("El sueldo mayor es  " + mayorSueldo + " de " + nombreMayorSueldo);
            Console.ReadLine();


 //ORDENAMIENTO DE UN ARREGLO

            int[] vector;
            vector= new int[12];
            int aux=0;

            Console.WriteLine("cantidad de numeros: (menor que 10) ");
            int CantNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < CantNumeros; i++)
            {
                Console.WriteLine("ingrese numero {0}" , (i+1));
                int numero= int.Parse(Console.ReadLine());

                vector[i] = numero;
            }

            for (int k=0; k<CantNumeros-1; k++)
{
   for (int j=k+1; j<CantNumeros; j++)
  {
    if(vector[k]>vector[j])
    {
     aux = vector[k];
     vector[k] = vector[j];
     vector[j] = aux;
    }
  }
            }
for(int m=0; m<CantNumeros;m++)
{
                    Console.WriteLine("Vector ordenado: " + vector[m]);
                  
                }
                Console.ReadLine();




//BÚSQUEDA DE UN ELEMENTO EN UN ARREGLO
            int[] vector;
            vector = new int[12];

            Console.WriteLine("cantidad de numeros: (menor que 10) ");
            int CantNumeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < CantNumeros; i++)
            {
                Console.WriteLine("ingrese numero {0}", (i + 1));
                int numero = int.Parse(Console.ReadLine());
                vector[i]=numero;

            }

            Console.WriteLine("Que valor desea buscar? ");
            int valor = int.Parse(Console.ReadLine());


            for (int j = 0; j < CantNumeros; j++)
            {
                
                if (vector[j]==valor)
                {
                    Console.WriteLine("el valor se encuentra en la posicion " + (j+1));
                    Console.ReadLine();
                }
            }


			
// Un programa que pida tu nombre y lo muestre con un espacio entre cada par de letras, usando "foreach".

            Console.WriteLine("Escriba su nombre: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i <nombre.Length ; i++)
            {
                string resultado = nombre.Substring(i, 1) + " " ;

                if((i+1) <=nombre.Length)
                    Console.Write(resultado);
            }
            Console.ReadLine();			
			
			
			
//UNIT TEST
C#
Nuevo proyecto
Otro tipo de proyecto
soluciones de visual studio
solucion en blanco
en el nombre de la solucion agregar carpeta 
dentro de la carpeta, nuevo proyecto, aplicacion de consola		
agregar referencia a la aplicacion principal

si da error de referencia de windows.form , agregar referencia, framewoork, seleccionar windows.forms
 namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arange - planteamiento
            var instancia = new Interfaces.Factura();

            //act - prueba
            var suma = instancia.sumar(10, 10);  

            //assert - afirmacion
            Assert.AreEqual(suma, 20);
        }
    }
}

//metodo de prueba de carga de datos
public void TestMethod1()
        {
            FacturaNE pFactura = new FacturaNE();
            //arange
            var instancia = new CapaDA.FacturaDA(); // Interfaces.Factura();
            pFactura.NumeroFactura = 60;
            pFactura.Fecha = Convert.ToDateTime( "2019-09-03");
            pFactura.NombreProveedor="pepe";
            pFactura.NumeroProveedor= 23;
            pFactura.TotalImporte=334;
            int esperado = 1;
            //act
            var actual = instancia.AgregarFactura(pFactura);// instancia.sumar(10, 10);  

            //assert
            Assert.AreEqual(esperado, actual);
        }
		
//Eliminar		
  FacturaNE pFactura = new FacturaNE();
            //arange
            var instancia = new CapaDA.FacturaDA(); // Interfaces.Factura();
            pFactura.NumeroFactura = 2222;
           
            int esperado = 1;
            //act
            var actual = instancia.EliminarFactura(pFactura); 

            //assert
            Assert.AreEqual(esperado, actual);
        }		
		
//Mostrar		
public void TestMethod1()
        {
            FacturaNE pFactura = new FacturaNE();
          
            bool esperado = true;

            var instancia = new CapaDA.FacturaDA();
            List<FacturaNE> Lista;
            Lista = instancia.MostrarFactura(); 
         
            int resultado =Lista.Count;

           if( resultado>0)
            {
            bool actual = true;
            Assert.AreEqual(esperado, actual);
            }
        }
    }		
	
//TUPLAS
var tupla6= new Tuple<string,int>("d",4);
var tupla2 = new Tuple<int, int>(3, 4);
var Tupla3 = Tuple.Create(3, 4);
var tupla4 = new Tuple<double, double>(2.4 , 5.4);
var tupla7 = new Tuple<string , int , DateTime , char >("hola", 4, DateTime.Now, 'd');
//deconstruir una tupla2
var (numero,edad)= tupla4()

otro
var person = (name: "John", age: 34);

			