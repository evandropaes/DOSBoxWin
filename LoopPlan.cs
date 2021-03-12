using System;
using System.Collections.Generic;
using System.Text;

namespace DosBlaster
{
    public class UnrollPlan
    {
        public int StartIndex;
        public int EndIndex;
        public int Count;
        int _tailIndex;
        int _tailCount;
        int _stride;
        
        public UnrollPlan(int count, int stride)
        {
            StartIndex = -stride;
            EndIndex = 0;
            _stride = stride;
            _tailIndex = (count - (count % stride)) - stride;
            _tailCount = count % stride;
            Count = stride;
        }

        public bool NextStride()
        {
            if (StartIndex + _stride < _tailIndex)
            {
                StartIndex += _stride;
                EndIndex += _stride;
                return true;
            }
            else
            {
                StartIndex += _stride;
                EndIndex = StartIndex + _tailCount;
                Count = _tailCount;
                return false;
            }
        }
    }
}
