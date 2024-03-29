using MathNet.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AudioAnalyzer.Algorithms.Tests
{
    [TestClass]
    public class FFTTests
    {
        [TestMethod]
        public void TestCooleyTukey()
        {
            float[] amplitudes1 = new float[] { 1, -1, 1, -1 };
            Complex32[] output1 = CooleyTukey.Forward(amplitudes1);
            Assert.AreEqual(output1[0].Magnitude, 0);
            Assert.AreEqual(output1[1].Magnitude, 0);
            Assert.AreEqual(output1[2].Magnitude, 4);
            Assert.AreEqual(output1[3].Magnitude, 0);

            float[] amplitudes2 = new float[] { 2, -2, 2, -2 };
            Complex32[] output2 = CooleyTukey.Forward(amplitudes2);
            Assert.AreEqual(output2[0].Magnitude, 0);
            Assert.AreEqual(output2[1].Magnitude, 0);
            Assert.AreEqual(output2[2].Magnitude, 8);
            Assert.AreEqual(output2[3].Magnitude, 0);

            float[] amplitudes3 = new float[] { 2, -2 };
            Complex32[] output3 = CooleyTukey.Forward(amplitudes3);
            Assert.AreEqual(output3[0].Magnitude, 0);
            Assert.AreEqual(output3[1].Magnitude, 4);

            float[] amplitudes4 = new float[] { 1, -1, 1, -1, 1, -1, 1, -1 };
            Complex32[] output4 = CooleyTukey.Forward(amplitudes4);
            Assert.AreEqual(output4[0].Magnitude, 0);
            Assert.AreEqual(output4[1].Magnitude, 0);
            Assert.AreEqual(output4[2].Magnitude, 0);
            Assert.AreEqual(output4[3].Magnitude, 0);
            Assert.AreEqual(output4[4].Magnitude, 8);
            Assert.AreEqual(output4[5].Magnitude, 0);
            Assert.AreEqual(output4[6].Magnitude, 0);
            Assert.AreEqual(output4[7].Magnitude, 0);

            float[] amplitudes5 = new float[] { 2, -2, 2, -2, 2, -2, 2, -2 };
            Complex32[] output5 = CooleyTukey.Forward(amplitudes5);
            Assert.AreEqual(output5[0].Magnitude, 0);
            Assert.AreEqual(output5[1].Magnitude, 0);
            Assert.AreEqual(output5[2].Magnitude, 0);
            Assert.AreEqual(output5[3].Magnitude, 0);
            Assert.AreEqual(output5[4].Magnitude, 16);
            Assert.AreEqual(output5[5].Magnitude, 0);
            Assert.AreEqual(output5[6].Magnitude, 0);
            Assert.AreEqual(output5[7].Magnitude, 0);

            float[] amplitudes6 = new float[] { 3, -3, 3, -3, 3, -3, 3, -3 };
            Complex32[] output6 = CooleyTukey.Forward(amplitudes6);
            Assert.AreEqual(output6[0].Magnitude, 0);
            Assert.AreEqual(output6[1].Magnitude, 0);
            Assert.AreEqual(output6[2].Magnitude, 0);
            Assert.AreEqual(output6[3].Magnitude, 0);
            Assert.AreEqual(output6[4].Magnitude, 24);
            Assert.AreEqual(output6[5].Magnitude, 0);
            Assert.AreEqual(output6[6].Magnitude, 0);
            Assert.AreEqual(output6[7].Magnitude, 0);

            float[] amplitudes7 = new float[] { 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3 };
            Complex32[] output7 = CooleyTukey.Forward(amplitudes7);

            // Inverse
            //  float[] amplitudes1 = new float[] { 1, -1, 1, -1 }; = 4
            float[] restoredAmplitudes1 = CooleyTukey.Backward(output1); // * 2
                                                                         //Assert.AreEqual(amplitudes1[0], restoredAmplitudes1[0]);
                                                                         //Assert.AreEqual(amplitudes1[1], restoredAmplitudes1[1]);
                                                                         //Assert.AreEqual(amplitudes1[2], restoredAmplitudes1[2]);
                                                                         //Assert.AreEqual(amplitudes1[3], restoredAmplitudes1[3]);

            //  float[] amplitudes2 = new float[] { 2, -2, 2, -2 }; = 4
            float[] restoredAmplitudes2 = CooleyTukey.Backward(output2); // * 2
                                                                         //Assert.AreEqual(amplitudes2[0], restoredAmplitudes2[0]);
                                                                         //Assert.AreEqual(amplitudes2[1], restoredAmplitudes2[1]);
                                                                         //Assert.AreEqual(amplitudes2[2], restoredAmplitudes2[2]);
                                                                         //Assert.AreEqual(amplitudes2[3], restoredAmplitudes2[3]);            

            //  float[] amplitudes3 = new float[] { 2, -2 }; = 2
            float[] restoredAmplitudes3 = CooleyTukey.Backward(output3); // * 1
                                                                         //Assert.AreEqual(amplitudes3[0], restoredAmplitudes3[0]);
                                                                         //Assert.AreEqual(amplitudes3[1], restoredAmplitudes3[1]);

            //  float[] amplitudes4 = new float[] { 1, -1, 1, -1, 1, -1, 1, -1 }; = 8
            float[] restoredAmplitudes4 = CooleyTukey.Backward(output4); // * 8
            //Assert.AreEqual(amplitudes4[0], restoredAmplitudes4[0]);
            //Assert.AreEqual(amplitudes4[1], restoredAmplitudes4[1]);
            //Assert.AreEqual(amplitudes4[2], restoredAmplitudes4[2]);
            //Assert.AreEqual(amplitudes4[3], restoredAmplitudes4[3]);
            //Assert.AreEqual(amplitudes4[4], restoredAmplitudes4[4]);
            //Assert.AreEqual(amplitudes4[5], restoredAmplitudes4[5]);
            //Assert.AreEqual(amplitudes4[6], restoredAmplitudes4[6]);
            //Assert.AreEqual(amplitudes4[7], restoredAmplitudes4[7]);

            //  float[] amplitudes5 = new float[] { 2, -2, 2, -2, 2, -2, 2, -2 }; = 8
            float[] restoredAmplitudes5 = CooleyTukey.Backward(output5); // * 8
            //Assert.AreEqual(amplitudes5[0], restoredAmplitudes5[0]);
            //Assert.AreEqual(amplitudes5[1], restoredAmplitudes5[1]);
            //Assert.AreEqual(amplitudes5[2], restoredAmplitudes5[2]);
            //Assert.AreEqual(amplitudes5[3], restoredAmplitudes5[3]);
            //Assert.AreEqual(amplitudes5[4], restoredAmplitudes5[4]);
            //Assert.AreEqual(amplitudes5[5], restoredAmplitudes5[5]);
            //Assert.AreEqual(amplitudes5[6], restoredAmplitudes5[6]);
            //Assert.AreEqual(amplitudes5[7], restoredAmplitudes5[7]);

            //  float[] amplitudes6 = new float[] { 3, -3, 3, -3, 3, -3, 3, -3 }; = 8
            float[] restoredAmplitudes6 = CooleyTukey.Backward(output6); // * 8
            //Assert.AreEqual(amplitudes6[0], restoredAmplitudes6[0]);
            //Assert.AreEqual(amplitudes6[1], restoredAmplitudes6[1]);
            //Assert.AreEqual(amplitudes6[2], restoredAmplitudes6[2]);
            //Assert.AreEqual(amplitudes6[3], restoredAmplitudes6[3]);
            //Assert.AreEqual(amplitudes6[4], restoredAmplitudes6[4]);
            //Assert.AreEqual(amplitudes6[5], restoredAmplitudes6[5]);
            //Assert.AreEqual(amplitudes6[6], restoredAmplitudes6[6]);
            //Assert.AreEqual(amplitudes6[7], restoredAmplitudes6[7]);

            //  float[] amplitudes7 = new float[] { 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3, 3, -3 }; = 16
            float[] restoredAmplitudes7 = CooleyTukey.Backward(output7); // * 64
            //Assert.AreEqual(amplitudes7[0], restoredAmplitudes7[0]);

        }
    }
}
