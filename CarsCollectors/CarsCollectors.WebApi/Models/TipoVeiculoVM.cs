﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarsCollectors.WebApi.Models
{
    public class TipoVeiculoVM
    {
        [Key]
        public Guid TipoVeiculoId { get; set; }
        public string Observacao { get; set; }
        public string TextoAoExecutarAcaoEspecial { get; set; }
    }
}