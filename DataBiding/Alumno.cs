using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBiding
{
    public  class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value)
                    return;
                nombre = value;
                onPopertyChnged(nameof(Nombre));
                onPopertyChnged(nameof(MostrarNombre));
                
                     
                
            }
        }        


        public string MostrarNombre => $"Nombre ingresado:{Nombre}"; 

        void onPopertyChnged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));  
        }
    }
    
}
