﻿using System;
using static System.Console;
using System.IO;
using System.Threading.Tasks;

namespace NonEcsiste
{
    public class AsyncNaoExiste
    {
        private readonly string file = null;
        async Task FooAsync()
        {
            int n = GetInt();
            WriteLine(n);
            await Task.Delay(100);
            int o = GetInt(n);
            await Task.Delay(200);
            int p = GetInt(o);
            WriteLine(p);
            var text = await File.ReadAllTextAsync(file);
            WriteLine(text);
        }

        private int GetInt(int i = 0) => DateTime.Now.Second + i;
    }
}
