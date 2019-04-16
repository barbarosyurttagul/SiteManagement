using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Barbarosoft.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace Barbarosoft.Core.Aspects.Postsharp
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;

        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            
            /*Business class CurrentOccupierValidator ın inherit ettiği
            * AbstractValidator sınıfının generic argümanına ulaşmak için
            */
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];

            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
