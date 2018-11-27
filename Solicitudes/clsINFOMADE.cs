using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitudes
{
    public class clsINFOMADE
    {
        public string calcular_edad(DateTime  fNacimiento)
        {                        
            int edad = DateTime.Today.AddTicks(-fNacimiento.Ticks).Year - 1;
            return edad.ToString();
        }

        public string fechaLarga(string fecha)
        {
            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 2);
            string año = fecha.Substring(6);

            switch (mes)
            {
                case "01":
                    mes = "ENERO";
                    break;
                case "02":
                    mes = "FEBRERO";
                    break;
                case "03":
                    mes = "MARZO";
                    break;
                case "04":
                    mes = "ABRIL";
                    break;
                case "05":
                    mes = "MAYO";
                    break;
                case "06":
                    mes = "JUNIO";
                    break;
                case "07":
                    mes = "JULIO";
                    break;
                case "08":
                    mes = "AGOSTO";
                    break;
                case "09":
                    mes = "SEPTIEMBRE";
                    break;
                case "10":
                    mes = "OCTUBRE";
                    break;
                case "11":
                    mes = "NOVIEMBRE";
                    break;
                case "12":
                    mes = "DICIEMBRE";
                    break;
                default:
                    break;
            }
            return dia + " / " + mes + " / " + año;
        }

        public string gradoActual(string grado, int edad)
        {
            switch (grado.Trim())
            {
                case "PRINCIPIANTE":
                    return "";
                case "10° - Blanca Av":
                    return "10° KUP";
                case "9°   - Amarilla":
                    return "9° KUP";
                case "8°   - Amarilla Av":
                    return "8° KUP";
                case "7°   - Verde":
                    return "7° KUP";
                case "6°   - Verde Av":
                    return "6° KUP";
                case "5°   - Azul":
                    return "5° KUP";
                case "4°   - Azul Av":
                    return "4° KUP";
                case "3°   - Marron":
                    return "3° KUP";
                case "2°   - Marron Av":
                    return "2° KUP";
                case "1°   - Roja":
                    return "1° KUP";
                case "IEBY DAN/POOM":
                    if (edad < 17)
                    {
                        return "IEBY POOM";
                    }
                    else
                    {
                        return "IEBY DAN";
                    }
                case "1° DAN/POOM":
                    if (edad < 17)
                    {
                        return "1° POOM";
                    }
                    else
                    {
                        return "1° DAN";
                    }
                case "2° DAN/POOM":
                    if (edad < 17)
                    {
                        return "2° POOM";
                    }
                    else
                    {
                        return "2° DAN";
                    }
                case "3° DAN/POOM":
                    if (edad < 17)
                    {
                        return "3° POOM";
                    }
                    else
                    {
                        return "3° DAN";
                    }
                case "4° DAN/POOM":
                    return "4° DAN";
                case "5° DAN/POOM":
                    return "5° DAN";
                default:
                    return "";
            }
        }

        public string nuevogrado(string grado, int edad)
        {
            switch (grado.Trim())
            {
                case "PRINCIPIANTE":
                    return "10° KUP";
                case "10° - Blanca Av":
                    return "9° KUP";
                case "9°   - Amarilla":
                    return "8° KUP";
                case "8°   - Amarilla Av":
                    return "7° KUP";
                case "7°   - Verde":
                    return "6° KUP";
                case "6°   - Verde Av":
                    return "5° KUP";
                case "5°   - Azul":
                    return "4° KUP";
                case "4°   - Azul Av":
                    return "3° KUP";
                case "3°   - Marron":
                    return "2° KUP";
                case "2°   - Marron Av":
                    return "1 KUP";
                case "1°   - Roja":
                    if (edad < 17)
                    {
                        return "IEBY POOM";
                    }
                    else
                    {
                        return "IEBY DAN";
                    }
                case "IEBY DAN/POOM":
                    if (edad < 17)
                    {
                        return "1° POOM";
                    }
                    else
                    {
                        return "1° DAN";
                    }
                case "1° DAN/POOM":
                    if (edad < 17)
                    {
                        return "2° POOM";
                    }
                    else
                    {
                        return "2° DAN";
                    }
                case "2° DAN/POOM":
                    if (edad < 17)
                    {
                        return "3° POOM";
                    }
                    else
                    {
                        return "3° DAN";
                    }
                case "3° DAN/POOM":
                    return "4° DAN";
                case "4° DAN/POOM":
                    return "5° DAN";
                case "5° DAN/POOM":
                    return "6° DAN";
                default:
                    return "";
            }
        }
    }
}
