﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TerminalCommandsApi.Domain.Models
{

    public class RefreshToken
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }
        public DateTimeOffset AddedDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }

        [ForeignKey(nameof(UserId))] public IdentityUser User { get; set; }
    }
}