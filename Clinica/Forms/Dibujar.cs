using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Forms
{
 
    class Dibujar
    {
        private int ejex;
        private int ejey;
        private Image patch;

        public Dibujar(){
            ejex = 0;
            ejey = 0;
            patch = null;
    }
        public int x   
        {
            get
            {
                return ejex;
            }
            set
            {
                ejex = value;
            }
        }
        public int y
        {
            get
            {
                return ejey;
            }
            set
            {
                ejey = value;
            }
        }
        public Image ruta
        {
            get
            {
                return patch;
            }
            set
            {
                patch = value;
            }
        }
    }
}
