﻿//  Copyright (c) 2021 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
// 

using System.Threading.Tasks;
using Nethermind.Core;
using Nethermind.Core.Crypto;
using Nethermind.Crypto;

namespace Nethermind.Consensus
{
    public class NullSigner : ISigner, ISignerStore
    {
        public static readonly NullSigner Instance = new();
        
        public Address Address { get; } = Address.Zero; // TODO: why zero address 

        public ValueTask Sign(Transaction tx) => default;

        public Signature Sign(Keccak message) { return new(new byte[65]); }

        public bool CanSign { get; } = true; // TODO: why true?

        public PrivateKey Key { get; }
        
        public void SetSigner(PrivateKey key) { }

        public void SetSigner(ProtectedPrivateKey key) { }
    }
}
