using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controleFinanceiro.Interfaces
{
    public class Fachada
    {
        private static Fachada instancia = null;
        private static object objBloqueado = new Object();
        
        private Fachada();

        
        public static Fachada ObterInstancia() 
        {
            lock(objBloqueado) 
            {
                if (instancia == null) 
                {
                    instancia = new Fachada();

                }

                return instancia;
            }
            
        
        }
       

        

    }
}
