using System.Linq.Expressions;

double dia1, dia2, dia3, dia4, dia5, dia6, dia7;
int opcion = 0;

Console.WriteLine("Ingrese la temperatura del dia1");
dia1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia2");
dia2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia3");
dia3 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia4");
dia4 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia5");
dia5 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia6");
dia6 = Double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temperatura del dia7");
dia7 = Double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Elija la opcion a calcular");
    Console.WriteLine("1- Promedio de temperatura semanal");
    Console.WriteLine("2- temperatura mas fria y la mas calurosa");
    Console.WriteLine("3- Porcentaje de temperatura bajo cero");
    Console.WriteLine("4- SALIR");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            double resultado  = calcularPromedioTemp(dia1,dia2,dia3,dia4,dia5,dia6,dia7);

            Console.WriteLine("Promedio de temp semanal: "+ resultado);
            break;
        case 2:
            Console.WriteLine("temperatura mas fria y la mas calurosa");
            double tempMaxima = dia1;
            double tempMin = dia2;

            //dia1 20
            //dia2 3
            //dia3 30


            tempMaxima = tempMAx(tempMaxima,dia2);
            tempMaxima = tempMAx(tempMaxima, dia3);
            tempMaxima = tempMAx(tempMaxima, dia4);
            tempMaxima = tempMAx(tempMaxima, dia5);
            tempMaxima = tempMAx(tempMaxima, dia6);
            tempMaxima = tempMAx(tempMaxima, dia7);


            if (tempMin > dia2)
            {
                tempMin = dia2;
            }


            if (tempMin > dia3) {
                tempMin = dia3;
            }

            if (tempMin > dia4)
            {
                tempMin = dia4;
            }

            if (tempMin > dia5)
            {
                tempMin = dia5;
            }
            if (tempMin > dia6)
            {
                tempMin = dia6;
            }
            if (tempMin > dia7)
            {
                tempMin = dia7;
            }

            Console.WriteLine("Temperatura mas fria : " + tempMin);
            Console.WriteLine("TEmeperatura mas Calurosa : " + tempMaxima);

            break;
        case 3:
            Console.WriteLine("Porcentaje de temperatura bajo cero");
            double count = 0;

            if (dia1 < 0)
            {
                count++;
            }
            if (dia2 < 0)
            {
                count++;
            }

            if (dia3 < 0)
            {
                count++;
            }
            if (dia4 < 0)
            {
                count++;
            }
            if (dia5 < 0)
            {
                count++;
            }
            if (dia6 < 0)
            {
                count++;
            }
            if (dia7 < 0)
            {
                count++;
            }

            Console.WriteLine("Porcentajes de dias menores a 0: " + (count / 7)*100 + "%");

            break;
        case 4: 
            break;
        default: 
            break;



    }
}while (opcion!=4);





static double calcularPromedioTemp(double dia1, double dia2, double dia3, double dia4, double dia5, double dia6, double dia7 )
{
    Console.WriteLine("Promedio de temperatura semanal");
    double promedio = (dia1 + dia2 + dia3 + dia4 + dia5 + dia6 + dia7) / 7;
    return promedio;

}

static double tempMAx(double temp1, double temp2)
{   double temp_Max = 0;
    if (temp1 > temp2)
    {
        temp_Max = temp1;

    }
    else
    {
        temp_Max = temp2;
    }

    return temp_Max;
}


