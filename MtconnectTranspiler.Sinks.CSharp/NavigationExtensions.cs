using Mtconnect.DataTypes;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp
{
    /// <summary>
    /// Helper methods for navigating the transpiled SysML model through <see cref="Mtconnect.MtconnectModel"/>.
    /// </summary>
    public static class NavigationExtensions
    {
        /// <summary>
        /// Returns all observation types of the specified category, excluding sub-types.
        /// </summary>
        /// <param name="category">Observation category</param>
        /// <returns>Collection of type classes.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static IEnumerable<ObservationType> GetObservationTypes(CategoryEnum category)
        {
            string categoryName = null;
            IPackage package = null;
            switch (category)
            {
                case CategoryEnum.CONDITION:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.ConditionTypesPackage;
                    categoryName = (new Mtconnect.ObservationInformationModel.ConditionClass()).Name;
                    break;
                case CategoryEnum.EVENT:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.EventTypesPackage;
                    categoryName = (new Mtconnect.ObservationInformationModel.EventClass()).Name;
                    break;
                case CategoryEnum.SAMPLE:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.SampleTypesPackage;
                    categoryName = (new Mtconnect.ObservationInformationModel.SampleClass()).Name;
                    break;
                default:
                    break;
            }
            if (package == null)
                throw new NotSupportedException("Unknown category '" + categoryName.ToString() + "' is not supported");

            return package.Classes.Where(o => !o.Name.Contains("."))
                .Select(o => new ObservationType()
                {
                    HelpUrl = o.HelpUrl,
                    Category = categoryName,
                    Name = o.Name,
                    Definition = o.Summary,
                    Introduced = o.NormativeVersion,
                    Deprecated = o.DeprecatedVersion,
                    Properties = o.Properties.Properties,
                    SubTypes = GetObservationSubTypes(o)?.ToArray(),
                });
        }
        
        /// <summary>
        /// Returns all observation types, excluding sub-types.
        /// </summary>
        /// <returns>Collection of type classes.</returns>
        public static IEnumerable<ObservationType> GetObservationTypes()
            => GetObservationTypes(CategoryEnum.CONDITION)
                .Concat(GetObservationTypes(CategoryEnum.EVENT))
                .Concat(GetObservationTypes(CategoryEnum.SAMPLE));

        /// <summary>
        /// Returns observation sub-types of the provided <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Reference to observation type to search for sub-types.</param>
        /// <returns>Collection of sub-type classes.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static IEnumerable<IClass> GetObservationSubTypes(IClass type)
        {
            IPackage package = null;
            Type eventType = typeof(Mtconnect.ObservationInformationModel.EventClass),
                sampleType = typeof(Mtconnect.ObservationInformationModel.SampleClass),
                conditionType = typeof(Mtconnect.ObservationInformationModel.ConditionClass);
            if (type.Generalization == eventType)
            {
                package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.EventTypesPackage;
            } else if (type.Generalization == sampleType)
            {
                package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.SampleTypesPackage;
            } else if (type.Generalization == conditionType)
            {
                package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.ConditionTypesPackage;
            }

            if (package == null)
                throw new NotSupportedException("Unknown observation generalization '" + type.Generalization?.Name + "' is not supported");

            return package.Classes.Where(o => o.Name.StartsWith(type.Name) && !o.Name.Equals(type.Name));
        }
    }
}
