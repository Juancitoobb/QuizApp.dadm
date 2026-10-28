using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Maui.Models
{
    public interface IColaCircular
    {
        Pregunta ObtenerPrimeroElemento();
        Pregunta ObtenerElementoSiguiente();
        Pregunta ObtenerElementoAnterior();
    }
}
