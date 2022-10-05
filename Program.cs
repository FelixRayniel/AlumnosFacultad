// See https://aka.ms/new-console-template for more information

int P = 4;
int CapacidadAulas = 35;
int [] CAP = new int [5];
int [] E = new int [5];
int [] AP = new int [5];
int[] BP = new int[5];
int [] CP = new int [5];

Random CantE = new Random();
Random PorcentajeAP = new Random();
Random PorcentajeBP = new Random();
Random PorcentajeCP = new Random();






while (Console.ReadKey().Key != ConsoleKey.Escape)
{



    for (int i = 0; i < P; i++){

        if (i == 0)
        {
            E[i] = CantE.Next(275, 1000);
            AP[i] = ((E[i] / 100) * PorcentajeAP.Next(1, 100));
            BP[i] = ((E[i] / 100) * PorcentajeBP.Next(1, 100));
            CP[i] = ((E[i]/100) * PorcentajeCP.Next(1, 100));
            CAP[i] = (E[i] / CapacidadAulas);

        }
        
        if (i != 0)
        {
            E[i] = AP[i-1];
            AP[i] = ((E[i] / 100) * PorcentajeAP.Next(1, 100));
            BP[i] = ((E[i] / 100) * PorcentajeBP.Next(1, 100));
            CP[i] = ((E[i] / 100) * PorcentajeCP.Next(1, 100));
            CAP[i] = (E[i] / CapacidadAulas);
        }

        Console.WriteLine($"Cantidad de estudiantes Anio " + E[i]);
        Console.WriteLine($"Estudiantes Aporvados: {AP[i]}");
        Console.WriteLine($"Estudiantes Que Repiten: {BP[i]} ");
        Console.WriteLine($"Estudiantes Que Abandonaron: {CP[i]} ");
        Console.WriteLine($"Cantidad de Aula: {CAP[i]}");
        Console.WriteLine("\n\n--------------------------------------------------\n\n");
    }

    
    
}
