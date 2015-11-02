using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Wox.Infrastructure.Logger;

namespace Wox.Infrastructure
{
    public class Timeit : IDisposable
    {
        private Stopwatch stopwatch = new Stopwatch();
        private string name;

        public Timeit(string name)
        {
            this.name = name;
            stopwatch.Start();
        }

        public void Dispose()
        {
            stopwatch.Stop();
            string info = name + ":" + stopwatch.ElapsedMilliseconds + "ms";
            Debug.WriteLine(info);
            Log.Info(info);
        }
    }
}
