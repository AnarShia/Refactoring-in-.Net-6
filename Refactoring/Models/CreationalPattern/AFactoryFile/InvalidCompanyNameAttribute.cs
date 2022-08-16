using System.ComponentModel.DataAnnotations;

namespace Refactoring.Models.FactorFile;

public class InvalidCompanyNameAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        var tempValue = value as string;

        if (value != null && value.ToString().Contains("Company"))
        {
            return true;
        }
        return false;
    }
}