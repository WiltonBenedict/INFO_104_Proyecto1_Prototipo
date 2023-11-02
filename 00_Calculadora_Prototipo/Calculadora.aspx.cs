using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _00_Calculadora_Prototipo
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //Problemas conocidos: 
        //Hay problemas con clases y acceso de variables. Variables globales no estan guardando datos. Al entrar en otras variables se 
        //quedan vacias.
        //Usar String y convertir a Double: Permite agregar tanto la comma como el - al principio
        clsDatos dato =new clsDatos();
        public static bool control = false;
        
        private void Page_Load(object sender, EventArgs e)
        {

        }
        //Numeros del 0 al 9
        protected void btt1_Click(object sender, EventArgs e)
        {
            //dato.valor = dato.valor + "1";
            Validar();
            tDato.Text += "1";
            dato.valor = tDato.Text;
        }

        protected void btt2_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "2";
            dato.valor = tDato.Text;
        }

        protected void btt3_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "3";
            dato.valor = tDato.Text;
        }

        protected void btt4_Click(object sender, EventArgs e)
        {

            Validar();
            tDato.Text += "4";
            dato.valor = tDato.Text;
        }

        protected void btt5_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "5";
            dato.valor = tDato.Text;
        }

        protected void btt6_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "6";
            dato.valor = tDato.Text;
        }

        protected void btt7_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "7";
            dato.valor = tDato.Text;
        }

        protected void btt8_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "8";
            dato.valor = tDato.Text;
        }

        protected void btt9_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "9";
            dato.valor = tDato.Text;
        }

        protected void btt0_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text += "0";
            dato.valor = tDato.Text;
        }
        /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        protected void bttSuma_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                dato.funcion = 1;
                FuncionInicio();
                tConsola.Text = "Suma Inicio";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }

        }

        protected void bttRest_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                dato.funcion = 2;
                FuncionInicio();
                tConsola.Text = "Resta Inicio";
            }
            else
            {
                tDato.Text = "-";
            }
        }
        protected void bttMult_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                dato.funcion = 3;
                FuncionInicio();
                tConsola.Text = "Multiplicacion Inicio";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }

        protected void bttDiv_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                dato.funcion = 4;
                FuncionInicio();
                tConsola.Text = "Division Inicio";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }
        protected void bttElevarXY_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                dato.funcion = 5;
                FuncionInicio();
                tConsola.Text = "Elevar X a Y Inicio";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }
        /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Fin Procesos con dos valores
 
        protected void bttIgual_Click(object sender, EventArgs e)
        {
            dato.funcion = Convert.ToInt32(tFuncion.Text);
            dato.val1Double = Convert.ToDouble(tVal1STR.Text);
            if(dato.funcion == 1)
            {
                FuncionFin();
                tValor.Text = $"{dato.val1Double} + {dato.val2Double}: ";
                dato.resultado = dato.val1Double + dato.val2Double;
                tResultado.Text = $"{dato.resultado}";
                tConsola.Text = "Suma Fin";
            }
            else if(dato.funcion == 2)
            {
                FuncionFin();
                tValor.Text = $"{dato.val1Double} - {dato.val2Double}: ";
                dato.resultado = dato.val1Double - dato.val2Double;
                tResultado.Text = $"{dato.resultado}";
                tConsola.Text = "Resta Fin";

            }
            else if(dato.funcion == 3)
            {
                FuncionFin();
                tValor.Text = $"{dato.val1Double} * {dato.val2Double}: ";
                dato.resultado = dato.val1Double * dato.val2Double;
                tResultado.Text = $"{dato.resultado}";
                tConsola.Text = "Multiplicacion Fin";
            }
            else if (dato.funcion == 4)
            {
                FuncionFin();
                tValor.Text = $"{dato.val1Double} / {dato.val2Double}: ";
                if(dato.val2Double == 0)
                {
                    tResultado.Text = "Error. No divisible por cero";
                    tConsola.Text = "Division Fin";
                }
                else
                {
                    dato.resultado = dato.val1Double / dato.val2Double;
                    tResultado.Text = $"{dato.resultado}";
                    tConsola.Text = "Division Fin";
                }

            }
            else if(dato.funcion == 5)
            {
                FuncionFin();
                tValor.Text = $"{dato.val1Double} a {dato.val2Double}: ";
                dato.resultado = Math.Pow(dato.val1Double, dato.val2Double);
                tResultado.Text = $"{dato.resultado}";
                tConsola.Text = "Elevar X a Y Fin";
                //Math.Pow(baseVal,expoVal);
            }
            else
            {
                tConsola.Text = "Default";
            }
        }

        public void Validar()
        {
            if (control == true)
            {
                tDato.Text = "";
                tVal1STR.Text = "";
                tVal2STR.Text = "";
                tVal1DO.Text = "";
                tVal2DO.Text = "";
                tConsola.Text = "";
                tFuncion.Text = "";
                tValor.Text = "";
                tResultado.Text = "";
                control = false;
            }
        }
        public void FuncionInicio()
        {
            dato.valor = tDato.Text;
            dato.val1Str = dato.valor;
            dato.val1Double = Convert.ToDouble(dato.val1Str);
            dato.valor = "";
            tDato.Text = "";
            //Consola
            tVal1STR.Text = dato.val1Str;
            tVal1DO.Text = $"Val 1T:{dato.val1Double}";
            tFuncion.Text = $"{dato.funcion}";
        }
        public void FuncionFin()
        {
            dato.valor = tDato.Text;
            dato.val2Str = dato.valor;
            dato.val2Double = Convert.ToDouble(dato.val2Str);
            dato.valor = "";
            tDato.Text = "";
            dato.funcion = 0;
            tVal2STR.Text = dato.val2Str;
            tVal2DO.Text = $"Val2:{dato.val2Double}";
            control = true;
        }

        /// ---------------------------------------------------------- Inicio Procesos con un valor
        protected void bttFactorial_Click(object sender, EventArgs e)
        {
            Validar();
            if(tDato.Text.Length > 0 )
            {
                tVal1STR.Text = tDato.Text;
                double factorial = Convert.ToDouble(tDato.Text);
                double i = factorial;
                double acumulador = 0;
                if (i > 0)
                {
                    while (i != 1)
                    {
                        if (factorial == i)
                        {
                            i = i - 1;
                            acumulador = factorial * i;
                        }
                        else
                        {
                            i = i - 1;
                            acumulador = acumulador * i;
                        }
                    }
                    control = true;
                    tDato.Text = "";
                    tValor.Text = $"{tVal1STR.Text}!";
                    tConsola.Text = "Factorial Fin";
                    tResultado.Text = $"{acumulador}";
                }
                else if (i == 0)
                {
                    tDato.Text = "";
                    tConsola.Text = "0";
                    tConsola.Text = "Factorial Fallo";
                }
                else
                {
                    tConsola.Text = "Error. Factorial solo es posible con numeros enteros.";
                }
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }

        protected void bttElevarCuadrado_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                tVal1STR.Text = tDato.Text;
                dato.val1Double = Convert.ToDouble(tVal1STR.Text);
                dato.resultado = Math.Pow(dato.val1Double, 2);
                control = true;
                tDato.Text = "";
                tValor.Text = $"{tVal1STR.Text} al cuadrado";
                tConsola.Text = "Elevar al cuadrdado Fin";
                tResultado.Text = $"{dato.resultado}";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }

        protected void bttElevar10_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                tVal1STR.Text = tDato.Text;
                dato.val1Double = Convert.ToDouble(tVal1STR.Text);
                dato.resultado = Math.Pow(10, dato.val1Double);
                control = true;
                tDato.Text = "";
                tValor.Text = $"10 al {tVal1STR.Text}";
                tConsola.Text = "Elevar 10 Fin";
                tResultado.Text = $"{dato.resultado}";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }

        protected void bttRaiz_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                tVal1STR.Text = tDato.Text;
                dato.val1Double = Convert.ToDouble(tVal1STR.Text);
                dato.resultado = Math.Sqrt(dato.val1Double);
                control = true;
                tDato.Text = "";
                tValor.Text = $"Raiz de {tVal1STR.Text}";
                tConsola.Text = "Raiz Cuadrada Fin";
                tResultado.Text = $"{dato.resultado}";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }

        }

        protected void bttLog_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Length > 0)
            {
                tVal1STR.Text = tDato.Text;
                dato.val1Double = Convert.ToDouble(tVal1STR.Text);
                dato.resultado = Math.Log(dato.val1Double);
                control = true;
                tDato.Text = "";
                tValor.Text = $"Log: {tVal1STR.Text}";
                tConsola.Text = "Logaritmo Natural Fin";
                tResultado.Text = $"{dato.resultado}";
            }
            else
            {
                tConsola.Text = "Error. No hay numero registrado";
            }
        }


        /// ---------------------------------------------------------- Fin Procesos con un valor

        /// ********************************************************** Inicio Procesos concatenacion

        protected void bttMasMenos_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Contains('-'))
            {
                tDato.Text = tDato.Text.Substring(1);
                //Se asume que - esta al principio del string y lo elimina
            }
            else
            {
                tDato.Text ="-" + tDato.Text;
                //Agrega el menos al principio del string
            }
        }

        protected void bttRemover_Click(object sender, EventArgs e)
        {
            Validar();
            if(tDato.Text.Length == 0)
            {
                tConsola.Text = "Consola: nada que remover";
            }
            else
            {
                tDato.Text = tDato.Text.Substring(0, tDato.Text.Length -1);
            }
        }

        protected void bttClear_Click(object sender, EventArgs e)
        {
            Validar();
            tDato.Text = "";
            tVal1STR.Text = "";
            tVal2STR.Text = "";
            tVal1DO.Text = "";
            tVal2DO.Text = "";

        }

        protected void bttPunto_Click(object sender, EventArgs e)
        {
            Validar();
            if (tDato.Text.Contains(","))
            {
                tConsola.Text = "Accion no posible";
            }
            else if (tDato.Text.Contains('-') && tDato.Text.Length == 1)
            {
                tConsola.Text = "Accion no posible";
                //Excepcion para prevenir (-,)
            }
            else
            {
                tDato.Text = tDato.Text + ".";
            }
        }

        /// ********************************************************** Fin Procesos concatenacion
    }

    //Estructuras intentadas
    /*
                 switch(dato.funcion)
            {
                case (dato.funcio:
                    dato.valor = tDato.Text;
                    dato.val2Str = dato.valor;
                    dato.val2Double = Convert.ToDouble(dato.val2Str);
                    dato.valor = "";
                    tDato.Text = "";
                    dato.funcion = "+";
                    tValor.Text = $"{dato.val1Double} + {dato.val2Double}: ";
                    dato.resultado = dato.val1Double + dato.val2Double;
                    tResultado.Text = $"{dato.resultado}";

                    //Consola
                    tVal2STR.Text = dato.val2Str;
                    tVal2DO.Text = $"Val2:{dato.val2Double}";
                    tConsola.Text = "Suma Fin";
                    break;
                case 0:
                    tConsola.Text = "Dummy";
                    break;
                default:
                    tConsola.Text = "Default";
                    break;
     

                if(tDato.Text.Length > 0)
            {
                dato.valor = tDato.Text;
                dato.val1Str = dato.valor;
                dato.val1Double = Convert.ToDouble(dato.val1Str);
                dato.valor = "";
                tDato.Text = "";
                funcion = 1;

                //Consola
                tVal1STR.Text = dato.val1Str;
                tVal1DO.Text = $"Val1: {dato.val1Double}";
                tConsola.Text = "Suma Inicio";
                tFuncion.Text = $"Funcion:{funcion}";
            }
            else
{
    tConsola.Text = "Error. No hay numero registrado";
}

                if(funcion == 1)
            {
                dato.valor = tDato.Text;
                dato.val2Str = dato.valor;
                dato.val2Double = Convert.ToDouble(dato.val2Str);
                dato.valor = "";
                tDato.Text = "";
                funcion = 0;//
                tValor.Text = $"{dato.val1Double} + {dato.val2Double}: ";
                dato.resultado = dato.val1Double + dato.val2Double;
                tResultado.Text = $"{dato.resultado}";

                //Consola
                tVal2STR.Text = dato.val2Str;
                tVal2DO.Text = $"Val2:{dato.val2Double}";
                tConsola.Text = "Suma Fin";
            }
            else
            {
                tConsola.Text = "Default";
            }



    */
}