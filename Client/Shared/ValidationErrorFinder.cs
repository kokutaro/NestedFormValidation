using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace Client.Shared;

public class ValidationErrorFinder : ComponentBase
{
    [CascadingParameter]
    public EditContext CurrentEditContext { get; set; } = default!;

    [Parameter]
    public Dictionary<string, List<Expression<Func<object>>>> FieldAccessors { get; set; } = new();

    private readonly EventHandler<ValidationStateChangedEventArgs>? _validationStateChangedHandler;

    public ValidationErrorFinder()
    {
        _validationStateChangedHandler = (_, _) => StateHasChanged();
    }

    protected override void OnParametersSet()
    {
        CurrentEditContext.OnValidationStateChanged += _validationStateChangedHandler;
    }

    public bool HasValidationErrors(string tabName)
    {
        if (!FieldAccessors.ContainsKey(tabName))
        {
            return false;
        }

        var fieldAccessors = FieldAccessors[tabName];
        return fieldAccessors
            .Select(f => CurrentEditContext.GetValidationMessages(f))
            .Any(x => x.Any());
    }

    public string GetBadgeText(string tabName) => HasValidationErrors(tabName) ? "!" : "";
    public Color GetBadgeColor(string tabName) => HasValidationErrors(tabName) ? Color.Error : Color.Transparent;
}