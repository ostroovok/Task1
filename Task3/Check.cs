using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Check
    {
        BinaryHeap _bh = new BinaryHeap();
        BinaryListHeap _blh = new BinaryListHeap();

        private ExpInfo bhTime = new ExpInfo();
        private ExpInfo blhTime = new ExpInfo();
        private Random _rnd;

        public ExpInfo[] Start(int size)
        {
            _rnd = new Random();
            //int size = 10000;
            OnInsert(size);
            OnIncrease(size/10);
            OnExtract();
            return new ExpInfo[] { bhTime, blhTime };
        }

        #region Insert
        public void OnInsert(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _bh.Insert(_rnd.Next(0, 101), _rnd.Next(0, 101));
                st.Stop();
                bhTime.InsertTime += st.Elapsed.Ticks;
            }
            for (int i = 0; i < size; i++)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _blh.Insert(_rnd.Next(0, 101), _rnd.Next(0, 101));
                st.Stop();
                blhTime.InsertTime += st.Elapsed.Ticks;
            }
            bhTime.InsertTime /= size;
            blhTime.InsertTime /= size;
        }
        #endregion
        public void OnExtract()
        {
            int size = _bh.Size;
            while(_bh.Size != 0)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _bh.ExtractMax();
                st.Stop();
                bhTime.ExtraxtMaxTime += st.Elapsed.Ticks;
            }
            while (_blh.Size != 0)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _blh.ExtractMax();
                st.Stop();
                blhTime.ExtraxtMaxTime += st.Elapsed.Ticks;
            }
            bhTime.ExtraxtMaxTime /= size;
            blhTime.ExtraxtMaxTime /= size;
        }
        #region ExtractMax

        #endregion

        #region Increase
        public void OnIncrease(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _bh.Insert(_rnd.Next(0, 101), _rnd.Next(0, 101));
                st.Stop();
                bhTime.InreaseTime += st.Elapsed.Ticks;
            }
            for (int i = 0; i < size; i++)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                _blh.Insert(_rnd.Next(0, 101), _rnd.Next(0, 101));
                st.Stop();
                blhTime.InreaseTime += st.Elapsed.Ticks;
            }
            bhTime.InreaseTime /= size;
            blhTime.InreaseTime /= size;
        }
        #endregion
    }
}
