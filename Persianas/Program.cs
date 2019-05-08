
using System;
using System.Threading;

using EngineIO;

namespace EngineIO.Samples
{
    class Program
    {
        //In this sample we are switching the living room light on and off 10 times.
        static void Main(string[] args)
        {
            //We are using a MemoryBit which we get from the MemoryMap.
            //You can find all the memory addresses at the Home I/O Memory Address document.

            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                    MemoryDateTime t = MemoryMap.Instance.GetDateTime(65, MemoryType.Memory);
                    DateTime tiempo = t.Value;

                    Console.WriteLine(tiempo.Hour);
                    MemoryBit rollDup = MemoryMap.Instance.GetBit(42, MemoryType.Output);
                    MemoryBit rollDdown = MemoryMap.Instance.GetBit(43, MemoryType.Output);

                    MemoryBit rollA1up = MemoryMap.Instance.GetBit(1, MemoryType.Output);
                    MemoryBit rollA1down = MemoryMap.Instance.GetBit(2, MemoryType.Output);

                    MemoryBit rollA2up = MemoryMap.Instance.GetBit(3, MemoryType.Output);
                    MemoryBit rollA2down = MemoryMap.Instance.GetBit(4, MemoryType.Output);

                    MemoryBit rollA3up = MemoryMap.Instance.GetBit(5, MemoryType.Output);
                    MemoryBit rollA3down = MemoryMap.Instance.GetBit(6, MemoryType.Output);

                    MemoryBit rollA4up = MemoryMap.Instance.GetBit(7, MemoryType.Output);
                    MemoryBit rollA4down = MemoryMap.Instance.GetBit(8, MemoryType.Output);

                    MemoryBit rollEup = MemoryMap.Instance.GetBit(55, MemoryType.Output);
                    MemoryBit rollEdown = MemoryMap.Instance.GetBit(56, MemoryType.Output);

                    MemoryBit rollGup = MemoryMap.Instance.GetBit(84, MemoryType.Output);
                    MemoryBit rollGdown = MemoryMap.Instance.GetBit(85, MemoryType.Output);

                    MemoryBit rollFup = MemoryMap.Instance.GetBit(70, MemoryType.Output);
                    MemoryBit rollFdown = MemoryMap.Instance.GetBit(71, MemoryType.Output);

                    MemoryBit rollHup = MemoryMap.Instance.GetBit(98, MemoryType.Output);
                    MemoryBit rollHdown = MemoryMap.Instance.GetBit(99, MemoryType.Output);

                    MemoryBit rollJup = MemoryMap.Instance.GetBit(123, MemoryType.Output);
                    MemoryBit rollJdown = MemoryMap.Instance.GetBit(124, MemoryType.Output);

                    MemoryBit rollLup = MemoryMap.Instance.GetBit(147, MemoryType.Output);
                    MemoryBit rollLdown = MemoryMap.Instance.GetBit(148, MemoryType.Output);

                    MemoryBit rollMup = MemoryMap.Instance.GetBit(160, MemoryType.Output);
                    MemoryBit rollMdown = MemoryMap.Instance.GetBit(161, MemoryType.Output);

                    MemoryBit rollNup = MemoryMap.Instance.GetBit(175, MemoryType.Output);
                    MemoryBit rollNdown = MemoryMap.Instance.GetBit(176, MemoryType.Output);






                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollDup.Value == false)
                    {



                        rollDup.Value = true;
                        rollDdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollDdown.Value == false)
                    {



                        rollDdown.Value = true;
                        rollDup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollA1up.Value == false)
                    {



                        rollA1up.Value = true;
                        rollA1down.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollA1down.Value == false)
                    {



                        rollA1down.Value = true;
                        rollA1up.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollA2up.Value == false)
                    {



                        rollA2up.Value = true;
                        rollA2down.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollA2down.Value == false)
                    {



                        rollA2down.Value = true;
                        rollA2up.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollA3up.Value == false)
                    {



                        rollA3up.Value = true;
                        rollA3down.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollA3down.Value == false)
                    {



                        rollA3down.Value = true;
                        rollA3up.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollA4up.Value == false)
                    {



                        rollA4up.Value = true;
                        rollA4down.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollA4down.Value == false)
                    {



                        rollA4down.Value = true;
                        rollA4up.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollEup.Value == false)
                    {



                        rollEup.Value = true;
                        rollEdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollEdown.Value == false)
                    {



                        rollEdown.Value = true;
                        rollEup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollGup.Value == false)
                    {



                        rollGup.Value = true;
                        rollGdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollGdown.Value == false)
                    {



                        rollGdown.Value = true;
                        rollGup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollFup.Value == false)
                    {



                        rollFup.Value = true;
                        rollFdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollFdown.Value == false)
                    {



                        rollFdown.Value = true;
                        rollFup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollHup.Value == false)
                    {



                        rollHup.Value = true;
                        rollHdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollHdown.Value == false)
                    {



                        rollHdown.Value = true;
                        rollHup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollJup.Value == false)
                    {



                        rollJup.Value = true;
                        rollJdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollJdown.Value == false)
                    {



                        rollJdown.Value = true;
                        rollJup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollLup.Value == false)
                    {



                        rollLup.Value = true;
                        rollLdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollLdown.Value == false)
                    {



                        rollLdown.Value = true;
                        rollLup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollMup.Value == false)
                    {



                        rollMup.Value = true;
                        rollMdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollMdown.Value == false)
                    {



                        rollMdown.Value = true;
                        rollMup.Value = false;

                    }
                    //****************************************************************************
                    if (tiempo.Hour >= 6 && tiempo.Hour <= 18 && rollNup.Value == false)
                    {



                        rollNup.Value = true;
                        rollNdown.Value = false;

                    }

                    if ((tiempo.Hour <= 5 || tiempo.Hour >= 19) && rollNdown.Value == false)
                    {



                        rollNdown.Value = true;
                        rollNup.Value = false;

                    }


                    MemoryMap.Instance.Update();

                    Thread.Sleep(1000);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



            //When we no longer need the MemoryMap we should call the Dispose method to release all the allocated resources.
            MemoryMap.Instance.Dispose();


        }
    }
}
