﻿using System.Collections.Generic;

namespace Poseidon.Models.Old
{
    public class QueryLedgersResponse : ResponseBase
    {
        public Dictionary<string, LedgerInfo> Result;
    }
}