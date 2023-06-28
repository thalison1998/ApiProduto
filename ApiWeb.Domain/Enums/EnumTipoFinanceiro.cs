﻿using System.ComponentModel;

namespace ApiWeb.Domain.Enums;

public enum EnumTipoFinanceiro
{
    [Description("Entrada")]
    Entrada = 1,
    [Description("Saída")]
    Saida = 2,
}
