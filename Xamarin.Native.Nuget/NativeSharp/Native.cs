﻿using System;

namespace NativeSharp
{
    public static class Native
    {

        public static int Add(int x, int y)
        {
            return NativeSharp.NativeMethods.native_add(x, y);
        }

        public static int Mul(int x, int y)
        {
            return NativeSharp.NativeMethods.native_mul(x, y);
        }

    }

}