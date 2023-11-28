using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_po2
{
    internal class Empresa
    {
        public string cnpj { get; set; }
        public string razaosocial { get; set; }
        public string situacaoCadastral { get; set; }
        public string regimeTribu { get; set;}
        public DateTime datainicio { get; set; }    
        public string telefone { get; set;}
        public double capitalsocial { get; set; }
        public string estado { get; set; }  
        public string cidade { get; set; }
        public string tipo { get; set; }    
        public string porte { get; set; }
        public string natureza { get; set;}
        public string nomeproprie { get; set; }
        public string cpfproprie { get; set; }

        Empresa (string cnpj, string razaosocial, string situacaoCadastral, string regimeTribu, DateTime datainicio, string telefone, double capitalsocial, string estado, string cidade, string tipo, string porte, string natureza, string nomeproprie, string cpfproprie)
        {
            this.cnpj = cnpj;
            this.razaosocial = razaosocial;
            this.situacaoCadastral = situacaoCadastral;
            this.regimeTribu = regimeTribu;
            this.datainicio = datainicio;
            this.telefone = telefone;
            this.capitalsocial = capitalsocial;
            this.estado = estado;
            this.cidade = cidade;
            this.tipo = tipo;
            this.porte = porte;
            this.natureza = natureza;
            this.nomeproprie = nomeproprie;
            this.cpfproprie = cpfproprie;
        }   
        public Empresa() { }
    }
}
