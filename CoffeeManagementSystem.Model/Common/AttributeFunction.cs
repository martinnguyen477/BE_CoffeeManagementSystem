namespace CoffeeManagementSystem.Model.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public static class AttributeFunction
    {
        /// <summary>
        /// GetMaxLengthProperty.
        /// </summary>
        /// <param name="pModelClass">pModelClass.</param>
        /// <param name="pPropertyName">pPropertyName.</param>
        /// <returns>GetMaxLengthProperty return.</returns>
        public static int? GetMaxLengthProperty(Type pModelClass, string pPropertyName)
        => pModelClass.GetProperties()
            .Single(p => p.Name == pPropertyName)
            .GetCustomAttributes(typeof(StringLengthAttribute), true)
            .Cast<StringLengthAttribute>().FirstOrDefault()?.MaximumLength;
    }
}
