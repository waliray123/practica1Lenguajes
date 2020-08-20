using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Practica1Lenguajes.backend
{
    class Componentes
    {

        public String[] palabras;
        public String oracion;
        public DataGrid dataGrid;

        public Componentes(String oracion, DataGrid dataGrid) {
            char delimitador = ' ';
            palabras = oracion.Split(delimitador);
            this.oracion = oracion;
            this.dataGrid = dataGrid;
        }

        public void revisarLexemas()
        {
            for (int i = 0; i < this.oracion.Length; i++)
            {
                Lexema lexema = new Lexema();

                Char caracter = Convert.ToChar(oracion.Substring(i, 1));

                if (caracter == 'Q')
                {
                    i=revisarMoneda(i,lexema);
                }
                else if (Char.IsDigit(caracter))
                {
                    int contadorDigitos = revisarNumero(i, lexema);                        

                    i = (contadorDigitos - 1);
                }
                else if (Char.IsLetter(caracter))
                {
                    bool esLetra = true;
                    int contadorLetras = i;
                    while (esLetra == true) {
                        Char siguienteCaracter = Convert.ToChar(oracion.Substring(contadorLetras, 1));
                        if (Char.IsLetter(siguienteCaracter))
                        {
                            contadorLetras++;
                        }
                        else
                        {
                            esLetra = false;
                        }
                        if (contadorLetras >= this.oracion.Length)
                        {
                            esLetra = false;
                        }
                    }
                    lexema.nombreLexema = Convert.ToString((oracion.Substring(i, contadorLetras - i)));

                    if (contadorLetras == (i + 1))
                    {                        
                        lexema.tipoLexema = "Letra";
                    }
                    else
                    {
                        lexema.tipoLexema = "Texto";
                    }

                    i = (contadorLetras - 1);
                }
                else if (Char.IsPunctuation(caracter))
                {
                    lexema.nombreLexema = Convert.ToString(caracter);
                    lexema.tipoLexema = "Simbolo";
                }
                else if (caracter == ' ')
                {
                    lexema.nombreLexema = Convert.ToString(caracter);
                    lexema.tipoLexema = "Espacio";
                }

                dataGrid.Items.Add(lexema);
            }
        }

        public int revisarNumero(int i, Lexema lexema)
        {
            bool esDigito = true;
            int contadorDigitos = i;
            int contadorPuntos = 0;
            while (esDigito == true)
            {
                Char siguienteCaracter = Convert.ToChar(oracion.Substring(contadorDigitos, 1));
                if (Char.IsDigit(siguienteCaracter))
                {
                    contadorDigitos++;
                }
                else if (contadorPuntos == 0 && siguienteCaracter == '.')
                {
                    contadorPuntos++;
                    contadorDigitos++;
                }
                else
                {
                    esDigito = false;
                }
                if (contadorDigitos >= this.oracion.Length)
                {
                    esDigito = false;
                }
            }

            // Revisar si es entero o decimal
            String numero = oracion.Substring(i, contadorDigitos - i);
            long numeroLong = 0;
            bool canConvert = long.TryParse(numero, out numeroLong);
            lexema.nombreLexema = numero;

            if (canConvert == true)
            {
                lexema.tipoLexema = "Entero";
            }
            else
            {
                lexema.tipoLexema = "Decimal";
            }
            return contadorDigitos;
        }

        public int revisarMoneda(int i, Lexema lexema)
        {
            if (i + 1 < this.oracion.Length)
            {
                Char siguienteCaracter = Convert.ToChar(oracion.Substring(i + 1, 1));
                if (siguienteCaracter == '.')
                {
                    i++;
                    int contadorDigitos = revisarNumero(i + 1, lexema);
                    lexema.nombreLexema = "Q." + lexema.nombreLexema;
                    i = (contadorDigitos - 1);
                    lexema.tipoLexema = "Moneda " + lexema.tipoLexema;
                }
            }
            return i;
        }

    }

    
}
