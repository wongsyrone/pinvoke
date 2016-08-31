﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInvoke.Primitive
{
    public struct NativeSalEntryData
    {
        public NativeSimpleId SalId { get; }
        public int Index { get; }
        public SalEntryType SalEntryType { get; }
        public string Text { get; }

        public NativeSalEntryData(NativeSimpleId id, int index, SalEntryType type, string text)
        {
            SalId = id;
            Index = index;
            SalEntryType = type;
            Text = text;
        }
    }
}
