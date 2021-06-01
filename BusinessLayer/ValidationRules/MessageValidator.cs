﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.RecieverMail).NotEmpty().WithMessage("Receiver cannot be empty.");
            RuleFor(x => x.RecieverMail).EmailAddress().WithMessage("Please, Enter a valid mail address.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Subject cannot be empty.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Subject cannot be less than 3 characters.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Subject cannot be more than 50 characters.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Message cannot be empty.");
        }
    }
}
