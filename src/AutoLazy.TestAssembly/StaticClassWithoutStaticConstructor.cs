﻿using System;
using System.Linq;

namespace AutoLazy.TestAssembly
{
    public static class StaticClassWithoutStaticConstructor
    {
        [Lazy]
        public static string GetFoo()
        {
            return "a" + 1;
        }

        public static string Foo
        {
            [Lazy]
            get
            {
                return "c" + 3;
            }
        }

        [Lazy]
        public static string Bar
        {
            get
            {
                return "d" + 4;
            }
        }
    }
}
