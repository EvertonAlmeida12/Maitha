﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Conta : Base
    {
        public string ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int AgenciaId { get; set; }
        public virtual Agencia Agencia { get; set; }
        public string Tipo { get; set; }
        public int NrContra { get; set; }
        public Decimal Saldo { get; set; }

    }
}
