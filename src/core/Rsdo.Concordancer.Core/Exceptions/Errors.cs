using System;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Exceptions;

public static class Errors
{
    public static class Forbidden
    {
        public static string CorpusStatusIsNotValid(CorpusStatus currentStatus, CorpusStatus requiredStatus)
        {
            return $"To perform selected action, corpus status must be {requiredStatus.ToString()}. Current status is {currentStatus.ToString()}.";
        }
    }

    public static class NotFound
    {
        public static string EntityNotFound(EntityType entityType, Guid id)
        {
            return EntityNotFound(entityType, nameof(Entity.Id), id.ToString());
        }

        public static string EntityNotFound(EntityType entityType, string columnName, string value)
        {
            return $"Entity {entityType.ToString()} with {columnName}={value} not found.";
        }

        public static string FileNotFound(string path)
        {
            return $"$File {path} not found.";
        }
    }
}