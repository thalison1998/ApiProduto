﻿using ApiWeb.Application.Request;
using FluentValidation;


public class Validadores
{
    public class CriarOperacaoValidator : AbstractValidator<CriarOperacaoRequest>
    {
        public CriarOperacaoValidator()
        {
            RuleFor(x => x.Valor).Must(valor => valor >= 0).WithMessage("Valor não pode ser negativo.");
        }
    }
}
