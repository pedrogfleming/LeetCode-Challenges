using System.Linq;
using System.Text;
using System;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main
{

    public static void main(String[] args)
    {

        String filtrameEsta = "BNANANABANANABANANANANABA";
        int n = 0;

        if (quitarLetrasdeBanana(filtrameEsta))
        {
            String nueva = nuevaPalabraSinBanana(filtrameEsta);
            n++;
            if (quitarLetrasdeBanana(nueva))
            {
                String nueva2 = nuevaPalabraSinBanana(nueva);
                n++;
                if (quitarLetrasdeBanana(nueva2))
                {
                    String nueva3 = nuevaPalabraSinBanana(nueva2);
                    n++;
                    if (quitarLetrasdeBanana(nueva3))
                    {
                        String nueva4 = nuevaPalabraSinBanana(nueva3);
                        n++;
                        if (quitarLetrasdeBanana(nueva4))
                        {
                            n++;

                        }
                    }
                }
            }
        }

        System.out.println("EL RESULTADO ES " + n);
    }



    static boolean quitarLetrasdeBanana(String cadena)
    {
        List<String> letrasAquitar = Arrays.asList("B", "A", "N", "A", "N", "A");
        char[] arrayAux = cadena.toCharArray();
        List<String> cadenaAux = new ArrayList<>();
        int tamanioInicial = cadena.toCharArray().length;
        int n = 0;

        //convierto a lista la cadena pasada
        for (int i = 0; i < arrayAux.length; i++)
        {
            cadenaAux.add(String.valueOf(arrayAux[i]));
        }



        // recorro la lista de letras q quiero quitar, si existe en la cadena pasada (cadena pasada echa lista)
        // ermuevo la lista
        letrasAquitar.forEach(letra-> {
            if (cadenaAux.contains(letra))
            {
                cadenaAux.remove(letra);
            }
        });
        int tamanioFINAL = cadenaAux.size();

        // si la diferencia entra el tamanio inicial y el final es 6 significa q se quito toda la palabra banana
        boolean result = (tamanioInicial - tamanioFINAL) == 6;
        return result;

        //        StringBuilder nuevaCadena=new StringBuilder();
        //
        //        if (result){
        //
        //            for(String str : cadenaAux)
        //            {
        //                nuevaCadena.append(str);
        //            }
        //            System.out.println("nueva cadena " + nuevaCadena.toString());
        //
        //        }else{
        //            return 1;
        //        }
        //        return n += quitarLetrasdeBanana(nuevaCadena.toString());
    }

    static String nuevaPalabraSinBanana(String cadena)
    {
        List<String> letrasAquitar = Arrays.asList("B", "A", "N", "A", "N", "A");
        char[] arrayAux = cadena.toCharArray();
        List<String> cadenaAux = new ArrayList<>();
        int tamanioInicial = cadena.toCharArray().length;
        int n = 0;

        //convierto a lista la cadena pasada
        for (int i = 0; i < arrayAux.length; i++)
        {
            cadenaAux.add(String.valueOf(arrayAux[i]));
        }



        // recorro la lista de letras q quiero quitar, si existe en la cadena pasada (cadena pasada echa lista)
        // ermuevo la lista
        letrasAquitar.forEach(letra-> {
            if (cadenaAux.contains(letra))
            {
                cadenaAux.remove(letra);
            }
        });

        int tamanioFINAL = cadenaAux.size();


        // si la diferencia entra el tamanio inicial y el final es 6 significa q se quito toda la palabra banana
        boolean result = (tamanioInicial - tamanioFINAL) == 6;

        StringBuilder nuevaCadena = new StringBuilder();

        if (result)
        {
            for (String str : cadenaAux)
            {
                nuevaCadena.append(str);
            }
            return nuevaCadena.toString();
        }
        return null;
    }


}