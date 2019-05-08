
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
                int esperaF = 10;
                int esperaB = 10;
                int esperaG = 10;
                int esperaI = 10;
                int esperaK = 10;
                int esperaE = 10;
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

                    //MemoryFloat cloud = MemoryMap.Instance.GetFloat(138, MemoryType.Memory);
                    MemoryFloat BrightA = MemoryMap.Instance.GetFloat(0, MemoryType.Input);
                    MemoryBit LightA = MemoryMap.Instance.GetBit(0, MemoryType.Output);

                    MemoryFloat BrightD = MemoryMap.Instance.GetFloat(12, MemoryType.Input);
                    MemoryBit LightD1 = MemoryMap.Instance.GetBit(40, MemoryType.Output);

                    MemoryFloat BrightH = MemoryMap.Instance.GetFloat(57, MemoryType.Input);
                    MemoryBit LightH = MemoryMap.Instance.GetBit(97, MemoryType.Output);

                    MemoryFloat BrightJ = MemoryMap.Instance.GetFloat(80, MemoryType.Input);
                    MemoryBit LightJ = MemoryMap.Instance.GetBit(122, MemoryType.Output);

                    MemoryFloat BrightL = MemoryMap.Instance.GetFloat(103, MemoryType.Input);
                    MemoryBit LightL = MemoryMap.Instance.GetBit(146, MemoryType.Output);

                    MemoryFloat BrightM = MemoryMap.Instance.GetFloat(115, MemoryType.Input);
                    MemoryBit LightM = MemoryMap.Instance.GetBit(159, MemoryType.Output);

                    MemoryFloat BrightN = MemoryMap.Instance.GetFloat(127, MemoryType.Input);
                    MemoryBit LightN = MemoryMap.Instance.GetBit(173, MemoryType.Output);

                    MemoryBit motionF= MemoryMap.Instance.GetBit(98, MemoryType.Input);
                    MemoryBit LightF2 = MemoryMap.Instance.GetBit(69, MemoryType.Output);
                    MemoryFloat BrightF = MemoryMap.Instance.GetFloat(36, MemoryType.Input);
                    
                    MemoryBit motionB = MemoryMap.Instance.GetBit(29, MemoryType.Input);
                    MemoryBit LightB = MemoryMap.Instance.GetBit(19, MemoryType.Output);
                    MemoryBit LightC = MemoryMap.Instance.GetBit(20, MemoryType.Output);

                    MemoryBit motionG = MemoryMap.Instance.GetBit(119, MemoryType.Input);
                    MemoryBit LightG = MemoryMap.Instance.GetBit(83, MemoryType.Output);

                    MemoryBit motionI = MemoryMap.Instance.GetBit(153, MemoryType.Input);
                    MemoryBit LightI1 = MemoryMap.Instance.GetBit(110, MemoryType.Output);
                    MemoryBit LightI2 = MemoryMap.Instance.GetBit(111, MemoryType.Output);

                    MemoryBit motionK = MemoryMap.Instance.GetBit(185, MemoryType.Input);
                    MemoryBit LightK = MemoryMap.Instance.GetBit(135, MemoryType.Output);

                    MemoryBit motionE = MemoryMap.Instance.GetBit(80, MemoryType.Input);
                    MemoryBit LightE = MemoryMap.Instance.GetBit(54, MemoryType.Output);
                    MemoryBit LightN1 = MemoryMap.Instance.GetBit(174, MemoryType.Output);
                    Console.WriteLine(BrightF.Value);

                    if (motionE.Value == true && (tiempo.Hour <= 5 || tiempo.Hour >= 19))
                    {
                        LightE.Value = true;
                        LightN1.Value = true;

                    }
                    if (LightE.Value == true)
                    {
                        esperaE--;
                    }
                    if (esperaE == 0)
                    {
                        LightE.Value = false;
                        LightN1.Value = false;
                        esperaE = 10;
                    }

                    if (motionK.Value == true && (tiempo.Hour <= 5 || tiempo.Hour >= 19))
                    {
                        LightK.Value = true;


                    }
                    if (LightK.Value == true)
                    {
                        esperaK--;
                    }
                    if (esperaK == 0)
                    {
                        LightK.Value = false;
                        esperaK = 10;
                    }

                    if (motionI.Value == true && (tiempo.Hour <= 5 || tiempo.Hour >= 19))
                    {
                        LightI1.Value = true;
                        LightI2.Value = true;

                    }
                    if (LightI1.Value == true)
                    {
                        esperaI--;
                    }
                    if (esperaI == 0)
                    {
                        LightI1.Value = false;
                        LightI2.Value = false;
                        esperaI = 10;
                    }


                    if (motionG.Value == true && (tiempo.Hour <= 5 || tiempo.Hour >= 19))
                    {
                        LightG.Value = true;
                       

                    }
                    if (LightG.Value == true )
                    {
                        esperaG--;
                    }
                    if (esperaG == 0)
                    {
                        LightG.Value = false;
                        esperaG = 10;
                    }

                    if (motionB.Value == true && (tiempo.Hour <= 5 || tiempo.Hour >= 19))
                    {
                        LightB.Value = true;
                        LightC.Value = true;

                    }
                    if (LightB.Value == true)
                    {
                        esperaB--;
                    }
                    if (esperaB == 0)
                    {
                        LightB.Value = false;
                        LightC.Value = false;
                        esperaB = 10;
                    }


                    if (motionF.Value == true && BrightF.Value <= 2.1 && LightF2.Value== false)
                    {
                        LightF2.Value = true;
                        
                    }
                    if (LightF2.Value == true)
                    {
                        esperaF--;
                    }
                    if (esperaF == 0)
                    {
                        LightF2.Value = false;
                        esperaF = 10;
                    }

                    //**************************************************
                    if (LightA.Value == true)
                    {
                        if (BrightA.Value - 5 > 1.5)
                        {
                            LightA.Value = false;
                        }
                    }
                    if (LightA.Value == false)
                    {
                        if (BrightA.Value <= 1.5)
                        {
                            LightA.Value = true;
                        }
                    }

                    if (LightD1.Value == true)
                    {
                        if (BrightD.Value - 3.3 > 0.8)
                        {
                            LightD1.Value = false;
                        }
                    }
                    if (LightD1.Value == false)
                    {
                        if (BrightD.Value <= 0.8)
                        {
                            LightD1.Value = true;
                        }
                    }

                    if (LightJ.Value == true)
                    {
                        if (BrightJ.Value - 5 > 1.7)
                        {
                            LightJ.Value = false;
                        }
                    }
                    if (LightJ.Value == false)
                    {
                        if (BrightJ.Value <= 1.7)
                        {
                            LightJ.Value = true;
                        }
                    }

                    if (LightL.Value == true)
                    {
                        if (BrightL.Value - 5 > 1.5)
                        {
                            LightL.Value = false;
                        }
                    }
                    if (LightL.Value == false)
                    {
                        if (BrightL.Value <= 1.5)
                        {
                            LightL.Value = true;
                        }
                    }

                    if (LightM.Value == true)
                    {
                        if (BrightM.Value - 5 > 1.5)
                        {
                            LightM.Value = false;
                        }
                    }
                    if (LightM.Value == false)
                    {
                        if (BrightM.Value <= 1.5)
                        {
                            LightM.Value = true;
                        }
                    }

                    if (LightN.Value == true)
                    {
                        if (BrightN.Value - 3.3 > 0.8)
                        {
                            LightN.Value = false;
                        }
                    }
                    if (LightN.Value == false)
                    {
                        if (BrightN.Value <= 0.8)
                        {
                            LightN.Value = true;
                        }
                    }

                    if (LightH.Value == true)
                    {
                        if (BrightH.Value - 5 > 1.5)
                        {
                            LightH.Value = false;
                        }
                    }
                    if (LightH.Value == false)
                    {
                        if (BrightH.Value <= 1.5)
                        {
                            LightH.Value = true;
                        }
                    }





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
