using System.Linq.Expressions;

int cantDias = 0;

Console.WriteLine("Cuantos dias desea calcular la temperatura ");
cantDias = int.Parse(Console.ReadLine());

double[] dias = new double[cantDias];

int opcion = 0;

for (int i = 0; i < dias.Length; i++)
{
    Console.WriteLine("Ingrese la temperatura del dia " + (i+1));
    dias[i] = Double.Parse(Console.ReadLine());
}




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
            double resultado  = calcularPromedioTemp(dias);

            Console.WriteLine("Promedio de temp semanal: "+ resultado);
            break;
        /*case 2:
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

            break;*/
        case 4: 
            break;
        default: 
            break;



    }
}while (opcion!=4);





double calcularPromedioTemp(double[] tempByday)
{
    double sumaTemp = 0;
    for (int i = 0; i < tempByday.Length; i++)
    {
        sumaTemp += tempByday[i];
    }


    Console.WriteLine("Promedio de temperatura semanal");
    double promedio = sumaTemp / tempByday.Length;
    return promedio;

}

double tempMAx(double temp1, double temp2)
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


