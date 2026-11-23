
using ICDIA_2026_3_AppsPortafolioEvidencias.Models;
using ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;
using ICDIA_2026_3_AppsPortafolioEvidencias.RunnersEjerciciosEquipo;
using ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;
using AppsPortafolioEvidencias.Apuntes;

namespace ICDIA_2026_3_AppsPortafolioEvidencias;

public class ProgramU1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa iniciado...\n");

        #region Introduccion
        UsoClasePersona1 programa;
        programa = new UsoClasePersona1();

        //new UsoClasePersona2();

        //new UsoClasePersona3();

        //new P4_UsoMascota1();

        //new P6_UsoPoligonos1();

       //new P7_UsoCarros();
        
     //   new R03_CarroManual();

     #endregion
    
        int tipoPrograma;
        do{
        Console.WriteLine("Quiere ejecutar un programa de Apuntes o de Ejercicios");
        Console.WriteLine("1: Apuntes");
        Console.WriteLine("2: Ejercicios");
        Console.WriteLine("3: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out tipoPrograma);
            if (!esValida)
            {
                tipoPrograma = -1;
            }

            switch (tipoPrograma)
            {
                case 1:
                    Console.WriteLine("Programas de Apuntes!!");
                    MenuProgramasApuntes();
                break;
                case 2:
                    Console.WriteLine("Programas de Ejercicios!!");
                    MenuProgramasEjercicios();
                break;
                case 3: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(tipoPrograma != 3);

    Console.WriteLine("Gracias por usuar nuestro Programa :D! alt+3");

}

public static void MenuProgramasApuntes()
    {
        int apunte;
        do{
        Console.WriteLine("Que apunte desea ejecutar?");
        Console.WriteLine("1: Clase Conjunto Datos");
        Console.WriteLine("2: Dataset");
        Console.WriteLine("3: Estudiante");
        Console.WriteLine("4: Cuenta ");
        Console.WriteLine("5: Eliminar ");
        Console.WriteLine("6: Dataset ");
        Console.WriteLine("7: Nombre ");
        Console.WriteLine("8: Precisión ");
        Console.WriteLine("9: modificación ");
        Console.WriteLine("10: Cambiar nombre ");
        Console.WriteLine("11: Calculadora ");
        Console.WriteLine("12: Constructores ");
        Console.WriteLine("13: Constructor y ToString ");
        Console.WriteLine("14: Comparar datasets con Equals ");
        Console.WriteLine("15: IComparable ");
        Console.WriteLine("16: Comparadores ");
        Console.WriteLine("17: Agregar objetos a una lista ");
        Console.WriteLine("18: Sensor de temperatura ");
        Console.WriteLine("19: Sensores de temperatura y humedad ");
        Console.WriteLine("20: Sensor de humedad ");
        Console.WriteLine("21: Sensores con herencia ");
        Console.WriteLine("22: Ordenar datasets ");
        Console.WriteLine("23: Sobrecarga y método virtual ");


        Console.WriteLine("100: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out apunte);
            if (!esValida)
            {
                apunte = -1;
            }

            switch (apunte)
            {
                //se genera un case por cada apunte que se pueda ejecutar
                case 1:
                    Console.WriteLine("Ejecución del apunte 1");
                    ///////////////////////////////////////////////////////
                    /// SECCION A MODIFICAR POR APUNTE!
                    A01_ConjuntoDatos a01 = new A01_ConjuntoDatos();
                    a01.Ejecutar();



                    ///////////////////////////////////////////////////////
                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 2:
                    Console.WriteLine("Ejecución del apunte 2");
                    A02_Dataset a02 = new A02_Dataset();
                        a02.Id = 1;
                        a02.Nombre = "Iris";
                    a02.MostrarInformacion();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 3:
                    Console.WriteLine("Ejecución del apunte 3");
                    A03_Estudiante a03 = new A03_Estudiante();
                    a03.Ejecutar(); 
                   
                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 4:
                    Console.WriteLine("Ejecución del apunte 4");
                    A04_Cuenta a04 = new A04_Cuenta();   
                    a04.Depositar(1000); 
                    
                   
                    Console.WriteLine("_Ejecución terminada!\n");
                break;
               case 5:
                    Console.WriteLine("Ejecución del apunte 5");
                    A05_Persona a05 = new A05_Persona();   
                   
                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 6:
                    Console.WriteLine("Ejecución del apunte 6");
                    A06_Dataset a06 = new A06_Dataset();
                    

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 7:
                    Console.WriteLine("Ejecución del apunte 7");
                   
                    A07_Nombre a07 = new A07_Nombre();
                    a07.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 8:
                    Console.WriteLine("Ejecución del apunte 8");
                   
                    A08_Precision a08 = new A08_Precision();
                    a08.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                 case 9:
                    Console.WriteLine("Ejecución del apunte 9");
                   
                    A09_Modificacion a09 = new A09_Modificacion();
                    a09.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 10:
                    Console.WriteLine("Ejecución del apunte 10");
                    A10_Cambiarnombre a10 = new A10_Cambiarnombre();
                    a10.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                 case 11:
                    Console.WriteLine("Ejecución del apunte 11");
                    A11_Calculadora a11 = new A11_Calculadora();
                    a11.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                 case 12:
                    Console.WriteLine("Ejecución del apunte 12");
                    A12_Const a12 = new A12_Const();
                    a12.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                case 13:
                    Console.WriteLine("Ejecución del apunte 13");
                    A13_Conscom a13 = new A13_Conscom();
                    a13.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                case 14:
                    Console.WriteLine("Ejecución del apunte 14");
                    A14_Equals a14 = new A14_Equals();
                    a14.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                    case 15:
                    Console.WriteLine("Ejecución del apunte 15");
                    A15_Icomparable a15 = new A15_Icomparable();
                    a15.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                case 16:
                    Console.WriteLine("Ejecución del apunte 16");
                    A16_Comparador a16 = new A16_Comparador();
                    a16.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 17:
                    Console.WriteLine("Ejecución del apunte 17");
                    A17_Agregarobjetos a17 = new A17_Agregarobjetos();
                    a17.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 18:
                    Console.WriteLine("Ejecución del apunte 18");
                    A18_Sensor a18 = new A18_Sensor();
                    a18.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 19:
                    Console.WriteLine("Ejecución del apunte 19");
                    A19_Sensortemp a19 = new A19_Sensortemp();
                    a19.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 20:
                    Console.WriteLine("Ejecución del apunte 20");
                    A20_SensorHumedad a20 = new A20_SensorHumedad();
                    a20.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 21:
                    Console.WriteLine("Ejecución del apunte 21");
                    A21_SensorHum a21 = new A21_SensorHum();
                    a21.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 22:
                    Console.WriteLine("Ejecución del apunte 22");
                    A22_Numerocaracteristicas a22 = new A22_Numerocaracteristicas();
                    a22.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 23:
                    Console.WriteLine("Ejecución del apunte 23");
                    A23_Calcular a23 = new A23_Calcular();
                    a23.Ejecutar();

                    Console.WriteLine("_Ejecución terminada!\n");
                break;

                case 100: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(apunte != 100);

        Console.WriteLine("Ejecución de apuntes terminada! \n");
    }

public static void MenuProgramasEjercicios()
    {
        int ejercicio;
        do{
        Console.WriteLine("Que ejercicio desea ejecutar?");
        Console.WriteLine("1:clase basica ");
        Console.WriteLine("2:encapsulamiento ");
        Console.WriteLine("3:Igualdad ");
        Console.WriteLine("4:Ordenamiento ");
        Console.WriteLine("5:Orden natural ");
        Console.WriteLine("6:Lista generica ");
        Console.WriteLine("7:Lista generica ");
        Console.WriteLine("8:Lista generica ");
        Console.WriteLine("9:Lista generica ");
        Console.WriteLine("10:Lista generica ");
        Console.WriteLine("100: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out ejercicio);
            if (!esValida)
            {
                ejercicio = -1;
            }

            switch (ejercicio)
            {
                //se genera un case por cada apunte que se pueda ejecutar
                case 1:
                    Console.WriteLine("Ejecución del ejercicio 1");
                break;
                case 2:
                    Console.WriteLine("Ejecución del ejercicio 2");
                break;
                case 3:
                    Console.WriteLine("Ejecución del ejercicio 3");
                break;


                case 100: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(ejercicio != 100);

        Console.WriteLine("Ejecución de ejercicios terminada! \n");
    }

}

