using System;

namespace Snap.Data.Mapper.Model.ObjectModel.Annotation;

[AttributeUsage(AttributeTargets.Property)]
internal class DataArrayAttribute : Attribute
{
    public int Length { get;set; }
}
