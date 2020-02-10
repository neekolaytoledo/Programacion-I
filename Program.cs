using System;

namespace Simulacro01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es su tipo de contrato (1:Dependiente o 2:Independiente)?");
            double c = double.Parse(Console.ReadLine());

            if (s == 877803)
            {
                if (c == 2)
                {
                    Console.WriteLine("¿Cuál es su clase de riesgo laboral (1,2,3,4 o 5)?");
                    double r = double.Parse(Console.ReadLine());

                    //Base64FormattingOptions de cotizacion: bdc
                    double bdc = s;

                    double pension = bdc * 0.16;

                    double eps = bdc * 0.125;



                    if (r == 1)
                    {
                        double arl = bdc * 0.00522;
                        double deducciones = arl + pension + eps;
                        //Salario real:sr
                        double sr = s - deducciones;
                        //Salario anual
                        double sa = sr * 12;
                        Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                    }
                    else
                    {
                        if (r == 2)
                        {
                            double arl = bdc * 0.01044;
                            double deducciones = arl + pension + eps;
                            //Salario real:sr
                            double sr = s - deducciones;
                            //Salario anual
                            double sa = sr * 12;
                            Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                        }
                        else if (r == 3)
                        {
                            double arl = bdc * 0.02436;
                            double deducciones = arl + pension + eps;
                            //Salario real:sr
                            double sr = s - deducciones;
                            //Salario anual
                            double sa = sr * 12;
                            Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                        }
                        else
                        {
                            if (r == 4)
                            {
                                double arl = bdc * 0.0435;
                                double deducciones = arl + pension + eps;
                                //Salario real:sr
                                double sr = s - deducciones;
                                //Salario anual
                                double sa = sr * 12;
                                Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                            }
                            else if (r == 5)
                            {
                                double arl = bdc * 0.0696;
                                double deducciones = arl + pension + eps;
                                //Salario real:sr
                                double sr = s - deducciones;
                                //Salario anual
                                double sa = sr * 12;
                                Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                            }
                        }
                    }
                }

            }

            if (c == 2)
            {
                Console.WriteLine("¿Cuál es su clase de riesgo laboral (1,2,3,4 o 5)?");
                double r = double.Parse(Console.ReadLine());
                
                //Base64FormattingOptions de cotizacion: bdc
                double bdc = s * 0.4;

                double pension= bdc * 0.16;

                double eps = bdc * 0.125;


                
                if (r == 1)
                {
                    double arl = bdc * 0.00522;
                    double deducciones = arl + pension + eps;
                    //Salario real:sr
                    double sr = s - deducciones;
                    //Salario anual
                    double sa = sr * 12;
                    Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                }
                else
                {
                    if (r == 2)
                    {
                        double arl = bdc * 0.01044;
                        double deducciones = arl + pension + eps;
                        //Salario real:sr
                        double sr = s - deducciones;
                        //Salario anual
                        double sa = sr * 12;
                        Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                    }
                    else if (r == 3)
                    {
                        double arl = bdc * 0.02436;
                        double deducciones = arl + pension + eps;
                        //Salario real:sr
                        double sr = s - deducciones;
                        //Salario anual
                        double sa = sr * 12;
                        Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                    }
                    else
                    {
                        if (r == 4)
                        {
                            double arl = bdc * 0.0435;
                            double deducciones = arl + pension + eps;
                            //Salario real:sr
                            double sr = s - deducciones;
                            //Salario anual
                            double sa = sr * 12;
                            Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                        }
                        else if (r == 5)
                        {
                            double arl = bdc * 0.0696;
                            double deducciones = arl + pension + eps;
                            //Salario real:sr
                            double sr = s - deducciones;
                            //Salario anual
                            double sa = sr * 12;
                            Console.WriteLine("Pension=" + pension + "  EPS=" + eps + "  ARL=" + arl + "  Salario Real=" + sr + "  Ingresos Anuales=" + sa);
                        }
                    }
                }
            }

            if (s == 877803)
            {
                double bdc11 = s;
                double pension11 = bdc11 * 0.04;
                double eps11 = bdc11 * 0.04;
                double deducciones11 = pension11 + eps11;
                double sr11 = s - deducciones11;
                double prima11 = s * 2;
                double sa11 = (sr11 * 12) + prima11;

                Console.WriteLine("Pension=" + pension11 + "  EPS=" + eps11 + "  Salario Real=" + sr11 + "  Ingresos Anuales=" + sa11);
            }
            else
            {
                double bdc1 = s * 0.4;
                double pension1 = bdc1 * 0.04;
                double eps1 = bdc1 * 0.04;
                double deducciones1 = pension1 + eps1;
                double sr1 = s - deducciones1;
                double prima = s * 2;
                double sa1 = (sr1 * 12) + prima;

                Console.WriteLine("Pension=" + pension1 + "  EPS=" + eps1 + "  Salario Real=" + sr1 + "  Ingresos Anuales=" + sa1);
            }

            

        }
    }
}
