namespace G3_edad.Entidades
{
    public static class G3_Validador
    {
        // Valida recursivamente si un string solo contiene letras
        public static bool G3_EsSoloLetras(string texto, int indice = 0)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            if (indice >= texto.Length) return true;
            if (!char.IsLetter(texto[indice])) return false;
            return G3_EsSoloLetras(texto, indice + 1);
        }

        // Valida recursivamente si un string solo contiene dígitos
        public static bool G3_EsSoloDigitos(string texto, int indice = 0)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            if (indice >= texto.Length) return true;
            if (!char.IsDigit(texto[indice])) return false;
            return G3_EsSoloDigitos(texto, indice + 1);
        }

        // Valida recursivamente si un string tiene una longitud exacta
        public static bool G3_LongitudExacta(string texto, int longitud, int indice = 0)
        {
            if (texto == null) return false;
            if (indice == texto.Length) return texto.Length == longitud;
            return G3_LongitudExacta(texto, longitud, indice + 1);
        }
    }
}