﻿using BierAlyzer.Contracts.Interface.Communication;
using ProtoBuf;

namespace BierAlyzer.Contracts.Communication.Auth.Request
{
    [ProtoContract]
    public class TokenRequest : IApiRequestParameter
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Mail Address </summary>
        ///
        /// <value> The mail. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [ProtoMember(10)]
        public string Mail { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Plain Password </summary>
        ///
        /// <value> The password. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [ProtoMember(20)]
        public string Password { get; set; }
    }
}