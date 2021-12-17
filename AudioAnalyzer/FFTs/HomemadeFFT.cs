﻿using System;
using System.Numerics;
using Aud.IO.Algorithms;

namespace AudioAnalyzer.FFTs
{
    public class HomemadeFFT : IAlgorithmFFT
    {
        /// <summary>
        /// Runder et heltal ned til nærmeste tal som går op i 2^n.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int CeilPower2(int x)
        {
            if (x < 1)
            {
                return 1;
            }

            double result = Math.Pow(2, Math.Ceiling(Math.Log(x, 2)));

            return (int)Math.Round(result);
        }

        public int AdjustWindowSize(int currentSize)
        {
            return CeilPower2(currentSize);
        }

        /// <exception cref="ArgumentNullException"></exception>
        public Complex[] FFT(double[] amplitudes)
        {
            if (amplitudes is null)
            {
                throw new ArgumentNullException(nameof(amplitudes));
            }

            // Den ændrer ikke på input array, så den kan bare returnere direkte.
            return CooleyTukey.Forward(amplitudes);
        }

        /// <exception cref="ArgumentNullException"></exception>
        public double[] IFFT(Complex[] frequencyBins)
        {
            if (frequencyBins is null)
            {
                throw new ArgumentNullException(nameof(frequencyBins));
            }

            return CooleyTukey.Backward(frequencyBins);
        }
    }
}
