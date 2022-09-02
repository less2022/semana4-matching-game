using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana4_primer_proyecto_formulario
{
    public partial class Form1 : Form




    {
       
        Label firstClicked = null;

      

        Label secondClicked = null;


        Random random = new Random();

        // cada una de las letras es un icono interesante 
        // y cada icono aparece dos veces en esta lista


        List<string> icons = new List<string>()
    {
        "A", "A", "O", "O", "C", "C", "Ñ", "Ñ",
        "P", "P", "Q", "Q", "X", "X", "T", "T"
    };

        /// <resumen>
        /// Asigna cada icono de la lista de iconos a un cuadrado alaeatorio
        /// </resumen>


        private void AssignIconsToSquares()
        {
            // El TableLayoutPanel tiene 16 etiquetas,
            // Y la lista de iconos tiene 16 iconos,
            // Por lo que se extrae un icono al azar de la lista
            // y añadido a cada etiqueta


            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];


                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }
            }
        }


      
        }




    }
}


    
                

            

            
        
    

  