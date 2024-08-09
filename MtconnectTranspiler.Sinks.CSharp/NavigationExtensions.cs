using Mtconnect.DataTypes;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtconnectTranspiler.Sinks.CSharp
{
    public static class NavigationExtensions
    {
        /// <summary>
        /// Returns all observation types of the specified category, excluding sub-types.
        /// </summary>
        /// <param name="category">Observation category</param>
        /// <returns>Collection of type classes.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static IEnumerable<IClass> GetObservationTypes(CategoryEnum category)
        {
            IPackage package = null;
            switch (category)
            {
                case CategoryEnum.CONDITION:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.ConditionTypesPackage;
                    break;
                case CategoryEnum.EVENT:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.EventTypesPackage;
                    break;
                case CategoryEnum.SAMPLE:
                    package = Mtconnect.MtconnectModel.ObservationInformationModelPackage.ObservationTypesPackage.SampleTypesPackage;
                    break;
                default:
                    break;
            }
            if (package == null)
                throw new NotSupportedException("Unknown category '" + category.ToString() + "' is not supported");

            return package.Classes.Where(o => !o.Name.Contains("."));
        }
        
        /// <summary>
        /// Returns all observation types, excluding sub-types.
        /// </summary>
        /// <returns>Collection of type classes.</returns>
        public static IEnumerable<IClass> GetObservationTypes()
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
