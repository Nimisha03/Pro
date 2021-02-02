using FluentValidation;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlet.Demo.BusinessServices
{
    class OutletValidator : AbstractValidator<DataServices.Data.Entities.Outlet1>
    {

        public OutletValidator()
        {

            List<string> conditions = new List<string>() { "Veg", "Non-Veg", "Both" };
            RuleFor(x => x.FoodType).Must(x => conditions.Contains(x)).WithMessage("Please Use:" + String.Join(",", conditions));

        }
    }
}
