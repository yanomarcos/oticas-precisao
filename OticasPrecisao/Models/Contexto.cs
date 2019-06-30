﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OticasPrecisao.Models
{
    public class Contexto : IdentityDbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
    }
}
