using FC.Codeflix.Catalog.Domain.Validation;

namespace FC.Codeflix.Catalog.Domain.Exceptions;

public class EntityValidationException(
    string? message,
    IReadOnlyCollection<ValidationError>? errors = null)
    : Exception(message)
{
    public IReadOnlyCollection<ValidationError>? Errors { get; } = errors;
}